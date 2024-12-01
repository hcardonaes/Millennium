namespace MillenniumApp
{
    partial class LugaresForm
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
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.labelLatitud = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLugares
            // 
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Location = new System.Drawing.Point(204, 12);
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.Size = new System.Drawing.Size(591, 434);
            this.dgvLugares.TabIndex = 0;
            this.dgvLugares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLugares_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(89, 72);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(100, 20);
            this.txtLatitud.TabIndex = 3;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(89, 102);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 20);
            this.txtLongitud.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(89, 128);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(34, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Lugar";
            // 
            // labelLatitud
            // 
            this.labelLatitud.AutoSize = true;
            this.labelLatitud.Location = new System.Drawing.Point(13, 76);
            this.labelLatitud.Name = "labelLatitud";
            this.labelLatitud.Size = new System.Drawing.Size(25, 13);
            this.labelLatitud.TabIndex = 8;
            this.labelLatitud.Text = "Lat.";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(13, 105);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(25, 13);
            this.lblLongitud.TabIndex = 9;
            this.lblLongitud.Text = "Lon";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.Location = new System.Drawing.Point(89, 172);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLugar.TabIndex = 11;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(89, 225);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // LugaresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnAgregarLugar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.labelLatitud);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvLugares);
            this.Name = "LugaresForm";
            this.Text = "LugaresForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label labelLatitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}