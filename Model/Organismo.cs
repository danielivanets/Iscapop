using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Iscapop.Model
{
    [Table("Organismo")]
    public class Organismo : Base.BaseModel
    {
        private int _id;
        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { SetProperty(ref _codigo, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _nom;
        public string Nom 
        { 
            get { return _nom; } 
            set { SetProperty(ref _nom, value); } 
        }

        private DateTime _momento; //momento en que se envio el codigo para la doble validacion
        public DateTime Momento
        {
            get { return _momento; }
            set { SetProperty(ref _momento, value); }
        }


        [OneToMany]
        public List<Material> Materiales { get; set; }
        [OneToMany]
        public List<Solicitud> Solicitudes { get; set; }


        /*
        //relacion con material
        private List<Material> _materiales;
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Material> Materiales { get; set; }

        //relacion con solicitud
        private List<Solicitud> _solicitudes;
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Solicitud> Solicitudes { get; set; }
        */

        public Organismo()
        {
            Materiales = new List<Material>();
            Solicitudes = new List<Solicitud>();

        }
    }
}
