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
    public partial class IPSU : Form
    {
        public IPSU()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // no permitir nombre vacio
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpMensaje.SetError(txtNombre, "Debe ingresar un nombre");
                return;
            }
            else
            {
                erpMensaje.SetError(txtNombre, "");

            }


            // no permitir apellido vacio
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                erpMensaje.SetError(txtApellido, "Debe ingresar un apellido");
                return;
            }
            else
            {
                erpMensaje.SetError(txtApellido, "");

            }

            // no permitir  numero de documento vacio
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                erpMensaje.SetError(txtIdentificacion, "Debe ingresar un numero de documento");
                return;
            }
            // SOLO PERMITIR NUMERO DE DOCUMENTO MAYOR A 0
            if (Convert.ToInt64(txtIdentificacion.Text) <= 0)
            {
                erpMensaje.SetError(txtIdentificacion, "El numero ingresado debe ser mayor a 0");
                return;
            }
            else
            {
                erpMensaje.SetError(txtIdentificacion, "");

            }
            // no permitir direccion vacia
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                erpMensaje.SetError(txtDireccion, "Debe ingresar una direccion");
                return;
            }
            else
            {
                erpMensaje.SetError(txtDireccion, "");

            }
            // no permitir telefono vacio
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                erpMensaje.SetError(txtTelefono, "Debe ingresar una direccion");
                return;
            }
            else
            {
                erpMensaje.SetError(txtTelefono, "");

            }

            // no permitir numero de cama vacio
            if (string.IsNullOrEmpty(txtNumCama.Text))
            {
                erpMensaje.SetError(txtNumCama, "Debe ingresar una direccion");
                return;
            }
            else
            {
                erpMensaje.SetError(txtNumCama, "");

            }

            // mostrar mensaje de  registro ingresado exitosamente
            Elementos.Paciente Registro = new Elementos.Paciente();
            Registro.Nombre = txtNombre.Text;
            Registro.Identificacion = Convert.ToInt64 (txtIdentificacion.Text);
            Registro.Direccion = txtDireccion.Text;
            Registro.Telefono = Convert.ToInt64(txtTelefono.Text);
            Registro.NumCama = Convert.ToInt64(txtNumCama.Text);
            Registro.Apellido = txtApellido.Text;
            Registro.IdCiudad = (cboCiudad.SelectedItem  as Ciudad).Id;
            if (rbFemenino.Checked == true) { Registro.sexo = "Femenino"; }
            else if (rbMasculino.Checked == true){Registro.sexo = "Masculino";}
            Registro.IdTipoDocumento = (cboTipoId.SelectedItem  as TipoDocumento ).Id;
         
            

           // ControlPaciente.IngresarPaciente(Registro);

            MessageBox.Show("Registro Ingresado Exitosamente");



        }

        private void IPSU_Load(object sender, EventArgs e)
        {
            // DEFINIR TIPOS DE DOCUMENTO
            System.Collections.Generic.List<Elementos.TipoDocumento>
                tiposDocumento = new List<Elementos.TipoDocumento>();

            tiposDocumento.Add(new Elementos.TipoDocumento() { Id = 1, Nombre = "Cedula Ciudania" });
            tiposDocumento.Add(new Elementos.TipoDocumento() { Id = 2, Nombre = "Tarjeta de  extranjeria" });
            tiposDocumento.Add(new Elementos.TipoDocumento() { Id = 3, Nombre = "NUIP" });
            tiposDocumento.Add(new Elementos.TipoDocumento() { Id = 4, Nombre = "Tarjeta de identidad" });
            tiposDocumento.Add(new Elementos.TipoDocumento() { Id = 5, Nombre = "Permiso De Permanencia " });

            cboTipoId.DataSource = tiposDocumento;
            cboTipoId.DisplayMember = "Nombre";

            // DEFINIR CIUDADES
            System.Collections.Generic.List<Elementos.Ciudad>
                ciudades = new List<Elementos.Ciudad>();

            ciudades.Add(new Elementos.Ciudad() { Id = 1, Nombre = "Apartado" });
            ciudades.Add(new Elementos.Ciudad() { Id = 2, Nombre = "San Andres" });
            ciudades.Add(new Elementos.Ciudad() { Id = 3, Nombre = "Medellin Sede Prado" });
            ciudades.Add(new Elementos.Ciudad() { Id = 4, Nombre = "Medellin Sede Universitaria" });
           

            cboCiudad.DataSource = ciudades;
            cboCiudad.DisplayMember = "Nombre";
        
        }


     
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((int)e.KeyChar == 8 ||
            (int)e.KeyChar >= 48 && (int)e.KeyChar <= 59))
            {
                e.Handled = true;
            }
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();
            medicamento.Show();


        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            ListadoPacientes Listado = new ListadoPacientes();
            Listado.Show();
        }
    }
}
