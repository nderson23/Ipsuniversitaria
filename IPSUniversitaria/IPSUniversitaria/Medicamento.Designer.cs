namespace IPSUniversitaria
{
    partial class Medicamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamento));
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.lblDosis = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.cboMedicamento = new System.Windows.Forms.ComboBox();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.erpMensajeM = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.cboPresentacion = new System.Windows.Forms.ComboBox();
            this.lblConcentracion = new System.Windows.Forms.Label();
            this.txtConcentracion = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensajeM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(301, 29);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(179, 18);
            this.lblMedicamento.TabIndex = 0;
            this.lblMedicamento.Text = "Medicamento a Consumir";
            // 
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosis.Location = new System.Drawing.Point(301, 70);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(47, 18);
            this.lblDosis.TabIndex = 1;
            this.lblDosis.Text = "Dosis";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(322, 169);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(92, 18);
            this.lblObservacion.TabIndex = 2;
            this.lblObservacion.Text = "Observacion";
            // 
            // cboMedicamento
            // 
            this.cboMedicamento.FormattingEnabled = true;
            this.cboMedicamento.Location = new System.Drawing.Point(500, 26);
            this.cboMedicamento.Name = "cboMedicamento";
            this.cboMedicamento.Size = new System.Drawing.Size(261, 21);
            this.cboMedicamento.TabIndex = 3;
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(364, 70);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(53, 20);
            this.txtDosis.TabIndex = 4;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(500, 167);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(290, 20);
            this.txtObservaciones.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(566, 198);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 59);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Medicamento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // erpMensajeM
            // 
            this.erpMensajeM.ContainerControl = this;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(325, 213);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(138, 31);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(301, 129);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(193, 18);
            this.lblPresentacion.TabIndex = 10;
            this.lblPresentacion.Text = "Presentacion Farmaceutica ";
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(500, 130);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(159, 21);
            this.cboPresentacion.TabIndex = 11;
            // 
            // lblConcentracion
            // 
            this.lblConcentracion.AutoSize = true;
            this.lblConcentracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcentracion.Location = new System.Drawing.Point(440, 72);
            this.lblConcentracion.Name = "lblConcentracion";
            this.lblConcentracion.Size = new System.Drawing.Size(105, 18);
            this.lblConcentracion.TabIndex = 12;
            this.lblConcentracion.Text = "Concentracion";
            this.lblConcentracion.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtConcentracion
            // 
            this.txtConcentracion.Location = new System.Drawing.Point(566, 68);
            this.txtConcentracion.Name = "txtConcentracion";
            this.txtConcentracion.Size = new System.Drawing.Size(104, 20);
            this.txtConcentracion.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(578, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(103, 18);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad Total";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(715, 97);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // Medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(809, 280);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtConcentracion);
            this.Controls.Add(this.lblConcentracion);
            this.Controls.Add(this.cboPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.cboMedicamento);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblDosis);
            this.Controls.Add(this.lblMedicamento);
            this.Name = "Medicamento";
            this.Text = "Medicamento";
            this.Load += new System.EventHandler(this.Medicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensajeM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.ComboBox cboMedicamento;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider erpMensajeM;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cboPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConcentracion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}