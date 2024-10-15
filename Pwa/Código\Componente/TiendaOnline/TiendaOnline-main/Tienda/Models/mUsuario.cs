using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Tienda.Models
{
    public class mUsuario
    {
        #region propiedades
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string nombres { get; set; }
        public string apellidos { get; set; }

        public string fecha_nacimiento { get; set; }
        public int telefono { get; set; }

        public string usuario { get; set; }
        public string pass { get; set; }

        public string direccion { get; set; }

        #endregion
    }

    public class mValidateUs
    {
        #region propiedades
        public string user { get; set; }
        public string password { get; set; }

        #endregion
    }

    public class mProductos
    {
        #region propiedades
        [BsonRepresentation(BsonType.ObjectId)]
        
        public string id { get; set; }

        public string nombre { get; set; }

        public string marca { get; set; }

        public string talla { get; set; }
        public string detalle { get; set; }
        public string categoria { get; set; }
        public int cantidad_inventario { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
        #endregion
    }
}