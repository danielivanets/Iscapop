
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace Iscapop.Model
{
    [Table("Material")]
    public class Material : Base.BaseModel
    {
        private int _id;
        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _nombre;
        [NotNull]
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { SetProperty(ref _descripcion, value); }
        }
        private string _uso;
        public string Uso  // para qué se puede usar, ejemplo: para el taller del ciclo formativo de electrónica
        {
            get { return _uso; }
            set { SetProperty(ref _uso, value); }
        }

        private int _stock;
        public int Stock
        {
            get { return _stock; }
            set { SetProperty(ref _stock, value); }

        }
        //public EnumEstadoMaterial Estado { get; set; }
        private string _state;
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        //Foto
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Foto> Fotos { get; set; }

        //Organisme
        [ForeignKey(typeof(Organismo))]
        public int OrganismoId { get; set; }
        [ManyToOne]
        public Organismo Organismo { get; set; }


        public Material()
        {
            Fotos = new List<Foto>();
        }

    }


}
