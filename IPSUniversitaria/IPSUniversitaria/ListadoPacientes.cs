﻿using IPSUniversitaria.Control;
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
    public partial class ListadoPacientes : Form
    {
        public ListadoPacientes()
        {
            InitializeComponent();
        }

        private void ListadoPacientes_Load(object sender, EventArgs e)
        {
            dgvListadoPacientes.AutoGenerateColumns = false;
            List<Elementos.Paciente> pacientes = ControlPaciente.ObtenerPacientes();
            dgvListadoPacientes.DataSource = pacientes;
        }

       
    }
}
