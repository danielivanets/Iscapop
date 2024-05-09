using Iscapop.Dao;
using Iscapop.Model;

namespace Iscapop.ViewModel
{
    public class LoginConfirmPasswordVM : Base.BaseViewModel
    {
        private OrganismoDAO organismoDAO;
        private Organismo _organismo;
        public Organismo Organismo 
        { 
            get { return _organismo; } 
            set { SetProperty(ref _organismo, value); } 
        }
        public LoginConfirmPasswordVM()
        {
            organismoDAO = new OrganismoDAO();
        }
        internal void AssignData(Organismo organismo)
        {
            this.Organismo = organismo;
        }
        internal void InsertOrganismo()
        {
            organismoDAO.insertarOrganismo(Organismo);
        }

    }
}
