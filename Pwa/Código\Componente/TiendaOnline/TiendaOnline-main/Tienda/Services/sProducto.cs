using Tienda.Models;
using Tienda.Interfaces;
using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;

namespace Tienda.Services
{
    public class sProducto : IProducto


    {

        #region Private variables
        private MongoClient _mongoclient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<mProductos> tablaproductos = null;
        #endregion


        public sProducto()
        {
            _mongoclient = new MongoClient("mongodb://127.0.0.1:27017/");
            _database = _mongoclient.GetDatabase("TiendaOnline");
            tablaproductos = _database.GetCollection<mProductos>("Productos");
        }

        public void Add_Producto(mProductos productos)
        {
            var producto = tablaproductos.Find(x => x.id == productos.id).FirstOrDefault();
            if (producto == null)
            {
                tablaproductos.InsertOne(productos);
            }
            else
            {
                tablaproductos.ReplaceOne(x => x.id == productos.id, producto);
            }
        }

        public string DeleteProduct(string productId)
        {
            tablaproductos.DeleteOne(x =>x.id == productId);
            return "Producto Eliminado";
        }

        public List<mProductos> GetProducts()
        {
            return tablaproductos.Find(FilterDefinition<mProductos>.Empty).ToList();

        }
    }
}
