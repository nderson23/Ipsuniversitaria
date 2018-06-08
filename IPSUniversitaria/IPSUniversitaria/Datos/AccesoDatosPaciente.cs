using IPSUniversitaria.Elementos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSUniversitaria.Datos
{
    public class AccesoDatosPaciente
    {
        private static Context context = new Context();
        public static void IngresarPaciente(Elementos.Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            context.SaveChanges();
        }

        internal static List<TipoDocumento> ObtenerTiposDocumento()
        {
            return context.TiposDocumento.ToList();
        }

        internal static List<LMedicamento> ObtenerMedicamentos()
        {
            return context.XMedicamentos.ToList();
        }

        internal static List<Paciente> ObtenerPacientes()
        {
            return context.Pacientes.ToList();
        }

        internal static List<Ciudad> ObtenerCiudades()
        {
            return context.Ciudades.ToList();
        }

        internal static List<FormaFarmaceutica> ObtenerFormasFarmaceuticas()
        {
            return context.FormasFarmaceuticas.ToList();
        }

        internal static void IngresarMedicamento(LMedicamento XMedicamentos)
        {
            context.XMedicamentos.Add(XMedicamentos);
            context.SaveChanges();
        }
    }
}
