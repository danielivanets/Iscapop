using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace Iscapop.Model
{
    [Table("Solicitud")]
    public class Solicitud : Base.BaseModel
    {
        private int _id;
        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private DateTime _momento;
        public DateTime Momento
        {
            get { return _momento; }
            set { SetProperty(ref _momento, value); }
        }

        [ForeignKey(typeof(Organismo))]
        public int OrganismoId { get; set; }

        [ManyToOne]
        public Organismo Organismo { get; set; }

        [ForeignKey(typeof(Material))]
        public int MaterialId { get; set; }

        [ManyToOne]
        public Material Material { get; set; }

        public Solicitud()
        {
        }
    }
}