namespace MillenniumApp
{
    partial class CargosPersonajesForm
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
            this.txtAñoFin = new System.Windows.Forms.TextBox();
            this.txtMesFin = new System.Windows.Forms.TextBox();
            this.txtDiaFin = new System.Windows.Forms.TextBox();
            this.txtAñoInicio = new System.Windows.Forms.TextBox();
            this.txtMesInicio = new System.Windows.Forms.TextBox();
            this.txtDiaInicio = new System.Windows.Forms.TextBox();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.cmbTiposDeCargos = new System.Windows.Forms.ComboBox();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.cmbPersonaje = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(98, 233);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(39, 20);
            this.txtAñoFin.TabIndex = 37;
            this.txtAñoFin.Visible = false;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(53, 233);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(39, 20);
            this.txtMesFin.TabIndex = 36;
            this.txtMesFin.Visible = false;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(8, 234);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(39, 20);
            this.txtDiaFin.TabIndex = 35;
            this.txtDiaFin.Visible = false;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(98, 208);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(39, 20);
            this.txtAñoInicio.TabIndex = 34;
            this.txtAñoInicio.Visible = false;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(53, 208);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(39, 20);
            this.txtMesInicio.TabIndex = 33;
            this.txtMesInicio.Visible = false;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(8, 208);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(39, 20);
            this.txtDiaInicio.TabIndex = 32;
            this.txtDiaInicio.Visible = false;
            // 
            // dgvCargos
            // 
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(173, 13);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(620, 425);
            this.dgvCargos.TabIndex = 31;
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Location = new System.Drawing.Point(17, 139);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCargo.TabIndex = 30;
            this.btnAgregarCargo.Text = "Agregar";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // cmbTiposDeCargos
            // 
            this.cmbTiposDeCargos.FormattingEnabled = true;
            this.cmbTiposDeCargos.Location = new System.Drawing.Point(17, 106);
            this.cmbTiposDeCargos.Name = "cmbTiposDeCargos";
            this.cmbTiposDeCargos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposDeCargos.TabIndex = 29;
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(17, 73);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(121, 21);
            this.cmbInstitucion.TabIndex = 28;
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(17, 40);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonaje.TabIndex = 27;
            // 
            // CargosPersonajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAñoFin);
            this.Controls.Add(this.txtMesFin);
            this.Controls.Add(this.txtDiaFin);
            this.Controls.Add(this.txtAñoInicio);
            this.Controls.Add(this.txtMesInicio);
            this.Controls.Add(this.txtDiaInicio);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.btnAgregarCargo);
            this.Controls.Add(this.cmbTiposDeCargos);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.cmbPersonaje);
            this.Name = "CargosPersonajesForm";
            this.Text = "CargosPetsonajeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAñoFin;
        private System.Windows.Forms.TextBox txtMesFin;
        private System.Windows.Forms.TextBox txtDiaFin;
        private System.Windows.Forms.TextBox txtAñoInicio;
        private System.Windows.Forms.TextBox txtMesInicio;
        private System.Windows.Forms.TextBox txtDiaInicio;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.ComboBox cmbTiposDeCargos;
        private System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.ComboBox cmbPersonaje;
    }
}