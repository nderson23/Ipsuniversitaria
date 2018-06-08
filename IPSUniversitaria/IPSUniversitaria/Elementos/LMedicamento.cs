using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSUniversitaria.Elementos
{
    [Table("Medicamentos")]
    public class LMedicamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public long  Dosis { get; set; }
        public long Concentracion { get; set; }
        public long CantidadTotal { get; set; }
        public string Observacion { get; set; }
        public int IdFormaFarmaceutica { get; set; }
        public virtual FormaFarmaceutica FormasFarmaceuticas { get; set; }


        public virtual ICollection<Paciente> Pacientes { get; set; }

        
    }
}
