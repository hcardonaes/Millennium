namespace MillenniumApp
{
    partial class CargosPersonajeForm
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
            this.lblPersonaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInstitucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(142, 269);
            this.txtAñoFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(56, 26);
            this.txtAñoFin.TabIndex = 37;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(75, 269);
            this.txtMesFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(56, 26);
            this.txtMesFin.TabIndex = 36;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(8, 271);
            this.txtDiaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(56, 26);
            this.txtDiaFin.TabIndex = 35;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(142, 231);
            this.txtAñoInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(56, 26);
            this.txtAñoInicio.TabIndex = 34;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(75, 231);
            this.txtMesInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(56, 26);
            this.txtMesInicio.TabIndex = 33;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(8, 231);
            this.txtDiaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(56, 26);
            this.txtDiaInicio.TabIndex = 32;
            // 
            // dgvCargos
            // 
            this.dgvCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(260, 20);
            this.dgvCargos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.RowHeadersWidth = 62;
            this.dgvCargos.Size = new System.Drawing.Size(696, 340);
            this.dgvCargos.TabIndex = 31;
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Location = new System.Drawing.Point(52, 325);
            this.btnAgregarCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarCargo.TabIndex = 30;
            this.btnAgregarCargo.Text = "Agregar";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // cmbTiposDeCargos
            // 
            this.cmbTiposDeCargos.FormattingEnabled = true;
            this.cmbTiposDeCargos.Location = new System.Drawing.Point(12, 111);
            this.cmbTiposDeCargos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTiposDeCargos.Name = "cmbTiposDeCargos";
            this.cmbTiposDeCargos.Size = new System.Drawing.Size(192, 28);
            this.cmbTiposDeCargos.TabIndex = 29;
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(12, 175);
            this.cmbInstitucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(192, 28);
            this.cmbInstitucion.TabIndex = 28;
            this.cmbInstitucion.SelectedIndexChanged += new System.EventHandler(this.cmbInstitucion_SelectedIndexChanged);
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(12, 46);
            this.cmbPersonaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(192, 28);
            this.cmbPersonaje.TabIndex = 27;
            // 
            // lblPersonaje
            // 
            this.lblPersonaje.AutoSize = true;
            this.lblPersonaje.Location = new System.Drawing.Point(12, 20);
            this.lblPersonaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonaje.Name = "lblPersonaje";
            this.lblPersonaje.Size = new System.Drawing.Size(80, 20);
            this.lblPersonaje.TabIndex = 38;
            this.lblPersonaje.Text = "Personaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cargo";
            // 
            // labelInstitucion
            // 
            this.labelInstitucion.AutoSize = true;
            this.labelInstitucion.Location = new System.Drawing.Point(12, 149);
            this.labelInstitucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstitucion.Name = "labelInstitucion";
            this.labelInstitucion.Size = new System.Drawing.Size(120, 20);
            this.labelInstitucion.TabIndex = 40;
            this.labelInstitucion.Text = "en la Institución";
            // 
            // CargosPersonajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 426);
            this.Controls.Add(this.labelInstitucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPersonaje);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CargosPersonajeForm";
            this.Text = "CargosPersonajeForm";
           // this.Load += new System.EventHandler(this.CargosPersonajesForm_Load);
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
        private System.Windows.Forms.Label lblPersonaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInstitucion;
    }
}