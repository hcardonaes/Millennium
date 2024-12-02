namespace Millennium
{
    partial class RelacionesSociopoliticasForm
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
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.dgvRelaciones = new System.Windows.Forms.DataGridView();
            this.txtAñoFin = new System.Windows.Forms.TextBox();
            this.txtMesFin = new System.Windows.Forms.TextBox();
            this.txtDiaFin = new System.Windows.Forms.TextBox();
            this.txtAñoInicio = new System.Windows.Forms.TextBox();
            this.txtMesInicio = new System.Windows.Forms.TextBox();
            this.txtDiaInicio = new System.Windows.Forms.TextBox();
            this.cmbTipoRelacion = new System.Windows.Forms.ComboBox();
            this.btnAgregarRelacion = new System.Windows.Forms.Button();
            this.btnEliminarRelacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonajes.Size = new System.Drawing.Size(296, 268);
            this.dgvPersonajes.TabIndex = 0;
            // 
            // dgvRelaciones
            // 
            this.dgvRelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelaciones.Location = new System.Drawing.Point(307, 9);
            this.dgvRelaciones.Name = "dgvRelaciones";
            this.dgvRelaciones.Size = new System.Drawing.Size(584, 426);
            this.dgvRelaciones.TabIndex = 1;
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(109, 338);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(39, 20);
            this.txtAñoFin.TabIndex = 32;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(64, 338);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(39, 20);
            this.txtMesFin.TabIndex = 31;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(19, 339);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(39, 20);
            this.txtDiaFin.TabIndex = 30;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(109, 313);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(39, 20);
            this.txtAñoInicio.TabIndex = 29;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(64, 313);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(39, 20);
            this.txtMesInicio.TabIndex = 28;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(19, 313);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(39, 20);
            this.txtDiaInicio.TabIndex = 27;
            // 
            // cmbTipoRelacion
            // 
            this.cmbTipoRelacion.FormattingEnabled = true;
            this.cmbTipoRelacion.Location = new System.Drawing.Point(180, 288);
            this.cmbTipoRelacion.Name = "cmbTipoRelacion";
            this.cmbTipoRelacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoRelacion.TabIndex = 33;
            // 
            // btnAgregarRelacion
            // 
            this.btnAgregarRelacion.Location = new System.Drawing.Point(28, 387);
            this.btnAgregarRelacion.Name = "btnAgregarRelacion";
            this.btnAgregarRelacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRelacion.TabIndex = 34;
            this.btnAgregarRelacion.Text = "Agregar";
            this.btnAgregarRelacion.UseVisualStyleBackColor = true;
            this.btnAgregarRelacion.Click += new System.EventHandler(this.btnAgregarRelacion_Click);
            // 
            // btnEliminarRelacion
            // 
            this.btnEliminarRelacion.Location = new System.Drawing.Point(165, 387);
            this.btnEliminarRelacion.Name = "btnEliminarRelacion";
            this.btnEliminarRelacion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRelacion.TabIndex = 35;
            this.btnEliminarRelacion.Text = "Eliminar";
            this.btnEliminarRelacion.UseVisualStyleBackColor = true;
            // 
            // RelacionesSociopoliticasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.btnEliminarRelacion);
            this.Controls.Add(this.btnAgregarRelacion);
            this.Controls.Add(this.cmbTipoRelacion);
            this.Controls.Add(this.txtAñoFin);
            this.Controls.Add(this.txtMesFin);
            this.Controls.Add(this.txtDiaFin);
            this.Controls.Add(this.txtAñoInicio);
            this.Controls.Add(this.txtMesInicio);
            this.Controls.Add(this.txtDiaInicio);
            this.Controls.Add(this.dgvRelaciones);
            this.Controls.Add(this.dgvPersonajes);
            this.Name = "RelacionesSociopoliticasForm";
            this.Text = "RelacionesSociopoliticasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.DataGridView dgvRelaciones;
        private System.Windows.Forms.TextBox txtAñoFin;
        private System.Windows.Forms.TextBox txtMesFin;
        private System.Windows.Forms.TextBox txtDiaFin;
        private System.Windows.Forms.TextBox txtAñoInicio;
        private System.Windows.Forms.TextBox txtMesInicio;
        private System.Windows.Forms.TextBox txtDiaInicio;
        private System.Windows.Forms.ComboBox cmbTipoRelacion;
        private System.Windows.Forms.Button btnAgregarRelacion;
        private System.Windows.Forms.Button btnEliminarRelacion;
    }
}