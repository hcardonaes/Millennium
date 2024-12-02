namespace MillenniumApp
{
    partial class SocialesForm
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
            this.dgvRelacionesSociales = new System.Windows.Forms.DataGridView();
            this.btnAgregarRelacion = new System.Windows.Forms.Button();
            this.cmbRelSocial = new System.Windows.Forms.ComboBox();
            this.cmbPersonaje2 = new System.Windows.Forms.ComboBox();
            this.cmbPersonaje1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacionesSociales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(105, 233);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(39, 20);
            this.txtAñoFin.TabIndex = 37;
            this.txtAñoFin.Visible = false;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(60, 233);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(39, 20);
            this.txtMesFin.TabIndex = 36;
            this.txtMesFin.Visible = false;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(15, 234);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(39, 20);
            this.txtDiaFin.TabIndex = 35;
            this.txtDiaFin.Visible = false;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(105, 208);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(39, 20);
            this.txtAñoInicio.TabIndex = 34;
            this.txtAñoInicio.Visible = false;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(60, 208);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(39, 20);
            this.txtMesInicio.TabIndex = 33;
            this.txtMesInicio.Visible = false;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(15, 208);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(39, 20);
            this.txtDiaInicio.TabIndex = 32;
            this.txtDiaInicio.Visible = false;
            // 
            // dgvRelacionesSociales
            // 
            this.dgvRelacionesSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacionesSociales.Location = new System.Drawing.Point(166, 13);
            this.dgvRelacionesSociales.Name = "dgvRelacionesSociales";
            this.dgvRelacionesSociales.Size = new System.Drawing.Size(620, 425);
            this.dgvRelacionesSociales.TabIndex = 31;
            // 
            // btnAgregarRelacion
            // 
            this.btnAgregarRelacion.Location = new System.Drawing.Point(24, 139);
            this.btnAgregarRelacion.Name = "btnAgregarRelacion";
            this.btnAgregarRelacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRelacion.TabIndex = 30;
            this.btnAgregarRelacion.Text = "Agregar";
            this.btnAgregarRelacion.UseVisualStyleBackColor = true;
            this.btnAgregarRelacion.Click += new System.EventHandler(this.btnAgregarRelacion_Click);
            // 
            // cmbRelSocial
            // 
            this.cmbRelSocial.FormattingEnabled = true;
            this.cmbRelSocial.Location = new System.Drawing.Point(24, 106);
            this.cmbRelSocial.Name = "cmbRelSocial";
            this.cmbRelSocial.Size = new System.Drawing.Size(121, 21);
            this.cmbRelSocial.TabIndex = 29;
            // 
            // cmbPersonaje2
            // 
            this.cmbPersonaje2.FormattingEnabled = true;
            this.cmbPersonaje2.Location = new System.Drawing.Point(24, 73);
            this.cmbPersonaje2.Name = "cmbPersonaje2";
            this.cmbPersonaje2.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonaje2.TabIndex = 28;
            // 
            // cmbPersonaje1
            // 
            this.cmbPersonaje1.FormattingEnabled = true;
            this.cmbPersonaje1.Location = new System.Drawing.Point(24, 40);
            this.cmbPersonaje1.Name = "cmbPersonaje1";
            this.cmbPersonaje1.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonaje1.TabIndex = 27;
            // 
            // SocialesForm
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
            this.Controls.Add(this.dgvRelacionesSociales);
            this.Controls.Add(this.btnAgregarRelacion);
            this.Controls.Add(this.cmbRelSocial);
            this.Controls.Add(this.cmbPersonaje2);
            this.Controls.Add(this.cmbPersonaje1);
            this.Name = "SocialesForm";
            this.Text = "SocialesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacionesSociales)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRelacionesSociales;
        private System.Windows.Forms.Button btnAgregarRelacion;
        private System.Windows.Forms.ComboBox cmbRelSocial;
        private System.Windows.Forms.ComboBox cmbPersonaje2;
        private System.Windows.Forms.ComboBox cmbPersonaje1;
    }
}