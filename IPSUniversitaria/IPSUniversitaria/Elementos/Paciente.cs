using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSUniversitaria.Elementos
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Identificacion { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public long NumCama { get; set; }
       

        public string sexo { get; set;}

        public int IdTipoDocumento { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }

        public int IdMedicamento { get; set; }
        public virtual LMedicamento XMedicamentos { get; set; }

        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudades { get; set; }

        public int IdFormaFarmaceutica { get; set; }
        public virtual FormaFarmaceutica FormasFarmaceuticas { get; set; }



        public Elementos.TipoDocumento TiposDocumento { get; set; }
    }
}
