using Tienda.Models;

namespace Tienda.Interfaces
{
    public interface IProducto
    {
        #region Methods
        void Add_Producto(mProductos producto);


        List<mProductos> GetProducts();

        string DeleteProduct(string productId);
        #endregion
    }
}
