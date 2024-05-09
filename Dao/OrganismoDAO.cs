using Iscapop.Model;
using SQLiteNetExtensionsAsync.Extensions;


namespace Iscapop.Dao
{
    public class OrganismoDAO
    {
        public OrganismoDAO() { }
        public void insertarOrganismo(Organismo organismo)
        {
            BaseDades.BaseDades.GetConnection().InsertWithChildrenAsync(organismo);
        }
        public void modificarOrganismo(Organismo organismo)
        {
            BaseDades.BaseDades.GetConnection().UpdateWithChildrenAsync(organismo);
        }
        public void eliminarOrganismo(Organismo organismo)
        {
            BaseDades.BaseDades.GetConnection().DeleteAsync(organismo);
        }

        public Organismo buscarPerfil(string email, string password)
        {
            Organismo organismo = BaseDades.BaseDades.GetConnection().GetAllWithChildrenAsync<Organismo>(o => o.Email.Equals(email) && o.Password.Equals(password)).Result.FirstOrDefault();
            return organismo;
        }

    }
}
