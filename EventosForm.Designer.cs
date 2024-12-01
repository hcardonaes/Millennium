namespace MillenniumApp
{
    partial class EventosForm
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.txtAñoFin = new System.Windows.Forms.TextBox();
            this.txtMesFin = new System.Windows.Forms.TextBox();
            this.txtDiaFin = new System.Windows.Forms.TextBox();
            this.txtAñoInicio = new System.Windows.Forms.TextBox();
            this.txtMesInicio = new System.Windows.Forms.TextBox();
            this.txtDiaInicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(164, 8);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersWidth = 62;
            this.dgvEventos.RowTemplate.Height = 28;
            this.dgvEventos.Size = new System.Drawing.Size(616, 341);
            this.dgvEventos.TabIndex = 0;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(9, 14);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(8, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(68, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(8, 113);
            this.cmbLugar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(82, 21);
            this.cmbLugar.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(8, 152);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(91, 20);
            this.txtDescripcion.TabIndex = 10;
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.Location = new System.Drawing.Point(9, 172);
            this.btnAgregarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(91, 33);
            this.btnAgregarEvento.TabIndex = 11;
            this.btnAgregarEvento.Text = "Agregar";
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(9, 205);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(91, 33);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Guarda";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(9, 238);
            this.btnEliminarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(91, 33);
            this.btnEliminarEvento.TabIndex = 13;
            this.btnEliminarEvento.Text = "Elimina";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(97, 82);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(39, 20);
            this.txtAñoFin.TabIndex = 32;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(51, 82);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(39, 20);
            this.txtMesFin.TabIndex = 31;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(6, 83);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(39, 20);
            this.txtDiaFin.TabIndex = 30;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(97, 57);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(39, 20);
            this.txtAñoInicio.TabIndex = 29;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(51, 57);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(39, 20);
            this.txtMesInicio.TabIndex = 28;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(6, 57);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(39, 20);
            this.txtDiaInicio.TabIndex = 27;
            // 
            // EventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 360);
            this.Controls.Add(this.txtAñoFin);
            this.Controls.Add(this.txtMesFin);
            this.Controls.Add(this.txtDiaFin);
            this.Controls.Add(this.txtAñoInicio);
            this.Controls.Add(this.txtMesInicio);
            this.Controls.Add(this.txtDiaInicio);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvEventos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventosForm";
            this.Text = "EventosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.TextBox txtAñoFin;
        private System.Windows.Forms.TextBox txtMesFin;
        private System.Windows.Forms.TextBox txtDiaFin;
        private System.Windows.Forms.TextBox txtAñoInicio;
        private System.Windows.Forms.TextBox txtMesInicio;
        private System.Windows.Forms.TextBox txtDiaInicio;
    }
}