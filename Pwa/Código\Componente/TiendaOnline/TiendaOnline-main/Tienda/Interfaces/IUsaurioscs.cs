using Tienda.Models;


namespace Tienda.Interfaces
{
    public interface IUsaurioscs
    {
        #region Methods
        void Add_Update(mUsuario datos);

        mUsuario ValidateUs(mValidateUs datauser);

        // List<mUsuario> GetUsers();


        #endregion
    }
}
