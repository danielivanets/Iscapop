using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Iscapop.Model
{
    [Table("Foto")]
    public class Foto : Base.BaseModel
    {
        private int _id;
        [AutoIncrement, PrimaryKey]
        public int Id { 
            get { return _id; } 
            set { SetProperty(ref _id, value); } 
        }

        public String nombre { get; set; }
        public String path { get; set; }
        public byte[] foto { get; set; }

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
