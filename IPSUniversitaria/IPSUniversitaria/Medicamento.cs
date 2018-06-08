using IPSUniversitaria.Control;
using IPSUniversitaria.Elementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSUniversitaria
{
    public partial class Medicamento : Form
    {
        public Medicamento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // no permitir dosis vacia
            if (string.IsNullOrEmpty(txtDosis.Text))
            {
                erpMensajeM.SetError(txtDosis, "Debe ingresar una dosis");
                return;
            }
            else
            {
                erpMensajeM.SetError(txtDosis, "");

            }

            // no permitir concentracion total vacia
            if (string.IsNullOrEmpty(txtConcentracion.Text))
            {
                erpMensajeM.SetError(txtConcentracion , "Debe ingresar una concentracion");
                return;
            }
            else
            {
                erpMensajeM.SetError(txtConcentracion, "");

            }

            // no permitir cantidad total vacia
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                erpMensajeM.SetError(txtCantidad, "Debe ingresar una cantidad");
                return;
            }
            else
            {
                erpMensajeM.SetError(txtCantidad, "");

            }


            // mostrar mensaje de  registro ingresado exitosamente
            Elementos.LMedicamento Registro = new Elementos.LMedicamento();
            Registro.Dosis = Convert.ToInt64( txtDosis.Text);
            Registro.Concentracion = Convert.ToInt64(txtConcentracion.Text);
            Registro.CantidadTotal = Convert.ToInt64(txtCantidad.Text);
            Registro.Observacion = txtObservaciones.Text;
            Registro.IdFormaFarmaceutica = (cboPresentacion.SelectedItem as FormaFarmaceutica).Id;

            /*Elementos.Paciente Registro2 = new Elementos.Paciente();
            Registro2.IdMedicamento = (cboMedicamento.SelectedItem as Medicamento).Id;*/

            //ControlPaciente.IngresarMedicamento(Registro);

            MessageBox.Show("Medicamento  Ingresado Exitosamente");




        }

        private void Medicamento_Load(object sender, EventArgs e)
        {
            // DEFINIR MEDICAMENTOS
            System.Collections.Generic.List<Elementos.LMedicamento>
                farmacos  = new List<Elementos.LMedicamento>();

            farmacos.Add(new Elementos.LMedicamento() { Id = 1, Nombre = "Acetaminofen", Codigo = "N02BE01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 2, Nombre = "Acetaminofen + acido acetil salicilico + cafeina", Codigo = "N02BE51" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 3, Nombre = "Aluminio Acetato", Codigo = "D02AX" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 4, Nombre = "Aluminio Hidroxido", Codigo = "A02AB01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 5, Nombre = "Ampicilina", Codigo = "J01CA01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 6, Nombre = "Azitromicina", Codigo = "J01FA10" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 7, Nombre = "Betametasona", Codigo = "H02AB01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 8, Nombre = "Ciprofloxacina", Codigo = "J01MA02" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 9, Nombre = "Diclofenaco Sódico", Codigo = "M01AB05" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 10, Nombre = "Dipirona", Codigo = "N02BB02" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 11, Nombre = "Enalapril + Hidroclorotiazida", Codigo = "C09BA02" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 12, Nombre = "Esomeprazol", Codigo = "A02BC05" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 13, Nombre = "Hioscina N-Butil Bromuro", Codigo = "A03BB01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 14, Nombre = "Ibuprofeno", Codigo = "M01AE01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 15, Nombre = "Loratadina", Codigo = "R06AX13" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 16, Nombre = "Naproxeno", Codigo = "M01AE02" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 17, Nombre = "Omeprazol", Codigo = "A02BC01" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 18, Nombre = "Ranitidina (Clorhidrato) ", Codigo = "A02BA02" });
            farmacos.Add(new Elementos.LMedicamento() { Id = 19, Nombre = "Sildenafil", Codigo = "G04BE03" });

            cboMedicamento.DataSource = farmacos;
            cboMedicamento.DisplayMember = "Nombre" ;

            // DEFINIR FORMA FARMACEUTICA
            System.Collections.Generic.List<Elementos.FormaFarmaceutica>
                forma = new List<Elementos.FormaFarmaceutica>();

            forma.Add(new Elementos.FormaFarmaceutica() { Id = 1, Nombre = "Tabletas"});
            forma.Add(new Elementos.FormaFarmaceutica() { Id = 2, Nombre = "Locion" });
            forma.Add(new Elementos.FormaFarmaceutica() { Id = 3, Nombre = "Suspencion" });
            forma.Add(new Elementos.FormaFarmaceutica() { Id = 4, Nombre = "Ampolla" });
            forma.Add(new Elementos.FormaFarmaceutica() { Id = 5, Nombre = "comprimido Recubierto" });
            

            cboPresentacion.DataSource = forma;
            cboPresentacion.DisplayMember = "Nombre";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string Nombre { get; set; }

        public int Id { get; set; }

       // public ICollection<TTargetEntity> Pacientes { get; set; }
    }
}
