using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Iscapop.Model
{
    [Table("Foto")]
    public class Foto : Base.BaseModel
    {
        private int _id;
        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        private string _path;
        public string Path
        {
            get { return _path; }
            set { SetProperty(ref _path, value); }
        }

        private byte[] _foto;
        public byte[] foto
        {
            get { return _foto; }
            set { SetProperty(ref _foto, value); }
        }

        //relacion con material
        [ForeignKey(typeof(Material))]
        public int MaterialId { get; set; }
        [ManyToOne]
        public Material Material { get; set; }


        public Foto()
        {

        }
    }
}
