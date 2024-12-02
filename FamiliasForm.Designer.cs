namespace MillenniumApp
{
    partial class FamiliasForm
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
            this.cmbPersonaje1 = new System.Windows.Forms.ComboBox();
            this.cmbPersonaje2 = new System.Windows.Forms.ComboBox();
            this.cmbTipoParentesco = new System.Windows.Forms.ComboBox();
            this.btnAgregarRelacion = new System.Windows.Forms.Button();
            this.dgvRelaciones = new System.Windows.Forms.DataGridView();
            this.txtAñoFin = new System.Windows.Forms.TextBox();
            this.txtMesFin = new System.Windows.Forms.TextBox();
            this.txtDiaFin = new System.Windows.Forms.TextBox();
            this.txtAñoInicio = new System.Windows.Forms.TextBox();
            this.txtMesInicio = new System.Windows.Forms.TextBox();
            this.txtDiaInicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersonaje1
            // 
            this.cmbPersonaje1.FormattingEnabled = true;
            this.cmbPersonaje1.Location = new System.Drawing.Point(12, 40);
            this.cmbPersonaje1.Name = "cmbPersonaje1";
            this.cmbPersonaje1.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonaje1.TabIndex = 0;
            // 
            // cmbPersonaje2
            // 
            this.cmbPersonaje2.FormattingEnabled = true;
            this.cmbPersonaje2.Location = new System.Drawing.Point(12, 73);
            this.cmbPersonaje2.Name = "cmbPersonaje2";
            this.cmbPersonaje2.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonaje2.TabIndex = 1;
            // 
            // cmbTipoParentesco
            // 
            this.cmbTipoParentesco.FormattingEnabled = true;
            this.cmbTipoParentesco.Location = new System.Drawing.Point(12, 106);
            this.cmbTipoParentesco.Name = "cmbTipoParentesco";
            this.cmbTipoParentesco.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoParentesco.TabIndex = 2;
            this.cmbTipoParentesco.SelectedIndexChanged += new System.EventHandler(this.cmbTipoParentesco_SelectedIndexChanged);
            // 
            // btnAgregarRelacion
            // 
            this.btnAgregarRelacion.Location = new System.Drawing.Point(12, 139);
            this.btnAgregarRelacion.Name = "btnAgregarRelacion";
            this.btnAgregarRelacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRelacion.TabIndex = 3;
            this.btnAgregarRelacion.Text = "Agregar";
            this.btnAgregarRelacion.UseVisualStyleBackColor = true;
            this.btnAgregarRelacion.Click += new System.EventHandler(this.btnAgregarRelacion_Click);
            // 
            // dgvRelaciones
            // 
            this.dgvRelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelaciones.Location = new System.Drawing.Point(168, 13);
            this.dgvRelaciones.Name = "dgvRelaciones";
            this.dgvRelaciones.Size = new System.Drawing.Size(620, 425);
            this.dgvRelaciones.TabIndex = 4;
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(93, 233);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(39, 20);
            this.txtAñoFin.TabIndex = 26;
            this.txtAñoFin.Visible = false;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(48, 233);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(39, 20);
            this.txtMesFin.TabIndex = 25;
            this.txtMesFin.Visible = false;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(3, 234);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(39, 20);
            this.txtDiaFin.TabIndex = 24;
            this.txtDiaFin.Visible = false;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(93, 208);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(39, 20);
            this.txtAñoInicio.TabIndex = 23;
            this.txtAñoInicio.Visible = false;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(48, 208);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(39, 20);
            this.txtMesInicio.TabIndex = 22;
            this.txtMesInicio.Visible = false;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(3, 208);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(39, 20);
            this.txtDiaInicio.TabIndex = 21;
            this.txtDiaInicio.Visible = false;
            // 
            // FamiliasForm
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
            this.Controls.Add(this.dgvRelaciones);
            this.Controls.Add(this.btnAgregarRelacion);
            this.Controls.Add(this.cmbTipoParentesco);
            this.Controls.Add(this.cmbPersonaje2);
            this.Controls.Add(this.cmbPersonaje1);
            this.Name = "FamiliasForm";
            this.Text = "FamiliasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonaje1;
        private System.Windows.Forms.ComboBox cmbPersonaje2;
        private System.Windows.Forms.ComboBox cmbTipoParentesco;
        private System.Windows.Forms.Button btnAgregarRelacion;
        private System.Windows.Forms.DataGridView dgvRelaciones;
        private System.Windows.Forms.TextBox txtAñoFin;
        private System.Windows.Forms.TextBox txtMesFin;
        private System.Windows.Forms.TextBox txtDiaFin;
        private System.Windows.Forms.TextBox txtAñoInicio;
        private System.Windows.Forms.TextBox txtMesInicio;
        private System.Windows.Forms.TextBox txtDiaInicio;
    }
}