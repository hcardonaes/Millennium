namespace MillenniumApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.btnAgregarPersonaje = new System.Windows.Forms.Button();
            this.btnFamiliasForm = new System.Windows.Forms.Button();
            this.btnLugaresForm = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToAddRows = false;
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Location = new System.Drawing.Point(20, 20);
            this.dgvPersonajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.ReadOnly = true;
            this.dgvPersonajes.RowHeadersWidth = 62;
            this.dgvPersonajes.Size = new System.Drawing.Size(1170, 654);
            this.dgvPersonajes.TabIndex = 0;
            this.dgvPersonajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonajes_CellContentClick);
            this.dgvPersonajes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonajes_CellDoubleClick);
            // 
            // btnAgregarPersonaje
            // 
            this.btnAgregarPersonaje.Location = new System.Drawing.Point(1257, 20);
            this.btnAgregarPersonaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarPersonaje.Name = "btnAgregarPersonaje";
            this.btnAgregarPersonaje.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarPersonaje.TabIndex = 1;
            this.btnAgregarPersonaje.Text = "Agregar Personaje";
            this.btnAgregarPersonaje.UseVisualStyleBackColor = true;
            this.btnAgregarPersonaje.Click += new System.EventHandler(this.btnAgregarPersonaje_Click);
            // 
            // btnFamiliasForm
            // 
            this.btnFamiliasForm.Location = new System.Drawing.Point(1258, 112);
            this.btnFamiliasForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFamiliasForm.Name = "btnFamiliasForm";
            this.btnFamiliasForm.Size = new System.Drawing.Size(124, 49);
            this.btnFamiliasForm.TabIndex = 2;
            this.btnFamiliasForm.Text = "Familia";
            this.btnFamiliasForm.UseVisualStyleBackColor = true;
            this.btnFamiliasForm.Click += new System.EventHandler(this.btnFamiliasForm_Click);
            // 
            // btnLugaresForm
            // 
            this.btnLugaresForm.Location = new System.Drawing.Point(1257, 217);
            this.btnLugaresForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLugaresForm.Name = "btnLugaresForm";
            this.btnLugaresForm.Size = new System.Drawing.Size(112, 35);
            this.btnLugaresForm.TabIndex = 3;
            this.btnLugaresForm.Text = "Lugares";
            this.btnLugaresForm.UseVisualStyleBackColor = true;
            this.btnLugaresForm.Click += new System.EventHandler(this.btnLugaresForm_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Location = new System.Drawing.Point(1277, 290);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(75, 23);
            this.btnEventos.TabIndex = 4;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 692);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnLugaresForm);
            this.Controls.Add(this.btnFamiliasForm);
            this.Controls.Add(this.btnAgregarPersonaje);
            this.Controls.Add(this.dgvPersonajes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.Button btnAgregarPersonaje;
        private System.Windows.Forms.Button btnFamiliasForm;
        private System.Windows.Forms.Button btnLugaresForm;
        private System.Windows.Forms.Button btnEventos;
    }
}

