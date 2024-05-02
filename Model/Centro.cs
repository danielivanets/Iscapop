using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Iscapop.Model
{
    [Table("Centro")]
    public class Centro : Base.BaseModel
    {
        private int _id;
        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set { SetProperty(ref _codigo, value); }
        }

        private string _denominacionGenericaES;
        public string DenominacionGenericaES
        {
            get { return _denominacionGenericaES; }
            set { SetProperty(ref _denominacionGenericaES, value); }
        }

        private string _denominacionGenericaVAL;
        public string DenominacionGenericaVAL
        {
            get { return _denominacionGenericaVAL; }
            set { SetProperty(ref _denominacionGenericaVAL, value); }
        }

        private string _denominacionEspecifica;
        public string DenominacionEspecifica
        {
            get { return _denominacionEspecifica; }
            set { SetProperty(ref _denominacionEspecifica, value); }
        }

        private string _denominacion;
        public string Denominacion
        {
            get { return _denominacion; }
            set { SetProperty(ref _denominacion, value); }
        }

        private string _regimen;
        public string Regimen
        {
            get { return _regimen; }
            set { SetProperty(ref _regimen, value); }
        }

        private string _tipoVia;
        public string TipoVia
        {
            get { return _tipoVia; }
            set { SetProperty(ref _tipoVia, value); }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { SetProperty(ref _direccion, value); }
        }

        private string _numero;
        public string Numero
        {
            get { return _numero; }
            set { SetProperty(ref _numero, value); }
        }

        private string _codigoPostal;
        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { SetProperty(ref _codigoPostal, value); }
        }

        private string _localidad;
        public string Localidad
        {
            get { return _localidad; }
            set { SetProperty(ref _localidad, value); }
        }

        private string _provincia;
        public string Provincia
        {
            get { return _provincia; }
            set { SetProperty(ref _provincia, value); }
        }

        private string _telefono;
        public string Telefono
        {
            get { return _telefono; }
            set { SetProperty(ref _telefono, value); }
        }

        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { SetProperty(ref _fax, value); }
        }

        private string _codEdificacion;
        public string CodEdificacion
        {
            get { return _codEdificacion; }
            set { SetProperty(ref _codEdificacion, value); }
        }

        private double _longitud;
        public double Longitud
        {
            get { return _longitud; }
            set { SetProperty(ref _longitud, value); }
        }

        private double _latitud;
        public double Latitud
        {
            get { return _latitud; }
            set { SetProperty(ref _latitud, value); }
        }

        private string _titularidad;
        public string Titularidad
        {
            get { return _titularidad; }
            set { SetProperty(ref _titularidad, value); }
        }

        private string _cif;
        public string CIF
        {
            get { return _cif; }
            set { SetProperty(ref _cif, value); }
        }

        private string _comarca;
        public string Comarca
        {
            get { return _comarca; }
            set { SetProperty(ref _comarca, value); }
        }

        public Centro() 
        { 
        
        }
        /*
        public long id;
        public String codigo;
        public String denominacionGenericaES;
        public String denominacionGenericaVAL;
        public String denominacionEspecifica;
        public String denominacion;
        public String regimen;
        public String tipoVia;
        public String direccion;
        public String numero;
        public String codigoPostal;
        public String localidad;
        public String provincia;
        public String telefono;
        public String fax;
        public String codEdificacion;
        public double longitud;
        public double latitud;
        public String titularidad;
        public String cif;
        public String comarca;

        public Centro() { }

        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }

        public String getDenominacionGenericaES()
        {
            return denominacionGenericaES;
        }

        public void setDenominacionGenericaES(String denominacionGenericaES)
        {
            this.denominacionGenericaES = denominacionGenericaES;
        }

        public String getDenominacionGenericaVAL()
        {
            return denominacionGenericaVAL;
        }

        public void setDenominacionGenericaVAL(String denominacionGenericaVAL)
        {
            this.denominacionGenericaVAL = denominacionGenericaVAL;
        }

        public String getDenominacionEspecifica()
        {
            return denominacionEspecifica;
        }

        public void setDenominacionEspecifica(String denominacionEspecifica)
        {
            this.denominacionEspecifica = denominacionEspecifica;
        }

        public String getDenominacion()
        {
            return denominacion;
        }

        public void setDenominacion(String denominacion)
        {
            this.denominacion = denominacion;
        }

        public String getRegimen()
        {
            return regimen;
        }

        public void setRegimen(String regimen)
        {
            this.regimen = regimen;
        }

        public String getTipoVia()
        {
            return tipoVia;
        }

        public void setTipoVia(String tipoVia)
        {
            this.tipoVia = tipoVia;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getNumero()
        {
            return numero;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public String getCodigoPostal()
        {
            return codigoPostal;
        }

        public void setCodigoPostal(String codigoPostal)
        {
            this.codigoPostal = codigoPostal;
        }

        public String getLocalidad()
        {
            return localidad;
        }

        public void setLocalidad(String localidad)
        {
            this.localidad = localidad;
        }

        public String getProvincia()
        {
            return provincia;
        }

        public void setProvincia(String provincia)
        {
            this.provincia = provincia;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public String getFax()
        {
            return fax;
        }

        public void setFax(String fax)
        {
            this.fax = fax;
        }

        public String getCodEdificacion()
        {
            return codEdificacion;
        }

        public void setCodEdificacion(String codEdificacion)
        {
            this.codEdificacion = codEdificacion;
        }

        public double getLongitud()
        {
            return longitud;
        }

        public void setLongitud(double longitud)
        {
            this.longitud = longitud;
        }

        public double getLatitud()
        {
            return latitud;
        }

        public void setLatitud(double latitud)
        {
            this.latitud = latitud;
        }

        public String getTitularidad()
        {
            return titularidad;
        }

        public void setTitularidad(String titularidad)
        {
            this.titularidad = titularidad;
        }

        public String getCif()
        {
            return cif;
        }

        public void setCif(String cif)
        {
            this.cif = cif;
        }

        public String getComarca()
        {
            return comarca;
        }

        public void setComarca(String comarca)
        {
            this.comarca = comarca;
        }
        */
    }

}
