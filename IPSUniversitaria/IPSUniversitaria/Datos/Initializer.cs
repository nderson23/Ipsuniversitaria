using IPSUniversitaria.Elementos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSUniversitaria.Datos
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Ciudadanía", Id = 1 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Extranjería", Id = 2 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Tarjeta de Identidad", Id = 3 });

            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Acetaminofen", Id = 1 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Acetaminofen + acido acetil salicilico + cafeina", Id = 2 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Aluminio Acetato", Id = 3 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Aluminio Hidroxido", Id = 4 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Ampicilina", Id = 5 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Azitromicina", Id = 6 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Betametasona", Id = 7 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Ciprofloxacina", Id = 8 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Diclofenaco Sódico", Id = 9 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Dipirona", Id = 10 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Enalapril + Hidroclorotiazida", Id = 11 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Esomeprazol", Id = 12 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Hioscina N-Butil Bromuro", Id = 13 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Ibuprofeno", Id = 14 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Loratadina", Id = 15 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Naproxeno", Id = 16 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Omeprazol", Id = 17 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Ranitidina (Clorhidrato)", Id = 18 });
            context.XMedicamentos.Add(new LMedicamento() { Nombre = "Sildenafil", Id = 19 });

            context.Ciudades.Add(new Ciudad() { Nombre = "Apartado", Id = 1 });
            context.Ciudades.Add(new Ciudad() { Nombre = "San Andres", Id = 2 });
            context.Ciudades.Add(new Ciudad() { Nombre = "Medellin Sede Prado", Id = 3 });
            context.Ciudades.Add(new Ciudad() { Nombre = "Medellin Sede Universitaria", Id = 4 });

            context.FormasFarmaceuticas.Add(new FormaFarmaceutica() { Nombre = "Tabletas", Id = 1 });
            context.FormasFarmaceuticas.Add(new FormaFarmaceutica() { Nombre = "Locion", Id = 2 });
            context.FormasFarmaceuticas.Add(new FormaFarmaceutica() { Nombre = "Suspencion", Id = 3 });
            context.FormasFarmaceuticas.Add(new FormaFarmaceutica() { Nombre = "Ampolla", Id = 4 });
            context.FormasFarmaceuticas.Add(new FormaFarmaceutica() { Nombre = "comprimido Recubierto", Id = 5 });

            base.Seed(context);
        }
    }
}
