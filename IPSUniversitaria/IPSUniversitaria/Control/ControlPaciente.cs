using IPSUniversitaria.Datos;
using IPSUniversitaria.Elementos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSUniversitaria.Control
{
    public class ControlPaciente
    {
        public static void IngresarPaciente(Elementos.Paciente paciente)
        {
            AccesoDatosPaciente.IngresarPaciente(paciente);
        }

        public static void IngresarMedicamento(Elementos.LMedicamento XMedicamentos)
        {
            AccesoDatosPaciente.IngresarMedicamento(XMedicamentos);
        }

        internal static List<Elementos.TipoDocumento> ObtenerTiposDocumento()
        {
            return AccesoDatosPaciente.ObtenerTiposDocumento();
        }
        
        internal static List<Elementos.Paciente> ObtenerPacientes()
        {
            return AccesoDatosPaciente.ObtenerPacientes();
        }
      
        internal static List<Elementos.Ciudad> ObtenerCiudades()
        {
            return AccesoDatosPaciente.ObtenerCiudades();
        }
        internal static List<Elementos.FormaFarmaceutica> ObtenerFormasFarmaceuticas()
        {
            return AccesoDatosPaciente.ObtenerFormasFarmaceuticas();
        }

        internal static List<Elementos.LMedicamento> ObtenerMedicamentos()
        {
            return AccesoDatosPaciente.ObtenerMedicamentos();
        }
    }
}
