using Tienda.Models;
using Tienda.Interfaces;
using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;

namespace Tienda.Services
{
    public class sUsuario:IUsaurioscs
    {

        #region Private variables
        private MongoClient _mongoclient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<mUsuario> tablausuarios = null;
        #endregion


        #region Methods

        #region Constructor
        public sUsuario()
        {
            _mongoclient = new MongoClient("mongodb://127.0.0.1:27017/");
            _database = _mongoclient.GetDatabase("TiendaOnline");
            tablausuarios = _database.GetCollection<mUsuario>("Usuarios");
        }

        #endregion

        public void Add_Update(mUsuario datos)
        {
            
            var usuario = tablausuarios.Find(x => x.Id == datos.Id).FirstOrDefault();
            if (usuario == null)
            {
                tablausuarios.InsertOne(datos);
            }
            else
            {
                tablausuarios.ReplaceOne(x => x.Id == datos.Id, usuario);
            }
        }


        public mUsuario ValidateUs(mValidateUs data)
        {
            var usuario = tablausuarios.Find(x => x.usuario == data.user && x.pass == data.password).FirstOrDefault();

            if (usuario != null){

                return usuario;
            }

            return null; // Return null if user not found
        }
        #endregion
    }
}
