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
            this.btnProtagonistas = new System.Windows.Forms.Button();
            this.btnRelacionesSP = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToAddRows = false;
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Location = new System.Drawing.Point(13, 13);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.ReadOnly = true;
            this.dgvPersonajes.RowHeadersWidth = 62;
            this.dgvPersonajes.Size = new System.Drawing.Size(780, 425);
            this.dgvPersonajes.TabIndex = 0;
            this.dgvPersonajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonajes_CellContentClick);
            this.dgvPersonajes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonajes_CellDoubleClick);
            // 
            // btnAgregarPersonaje
            // 
            this.btnAgregarPersonaje.Location = new System.Drawing.Point(838, 13);
            this.btnAgregarPersonaje.Name = "btnAgregarPersonaje";
            this.btnAgregarPersonaje.Size = new System.Drawing.Size(63, 23);
            this.btnAgregarPersonaje.TabIndex = 1;
            this.btnAgregarPersonaje.Text = "Agregar Personaje";
            this.btnAgregarPersonaje.UseVisualStyleBackColor = true;
            this.btnAgregarPersonaje.Click += new System.EventHandler(this.btnAgregarPersonaje_Click);
            // 
            // btnFamiliasForm
            // 
            this.btnFamiliasForm.Location = new System.Drawing.Point(839, 68);
            this.btnFamiliasForm.Name = "btnFamiliasForm";
            this.btnFamiliasForm.Size = new System.Drawing.Size(63, 32);
            this.btnFamiliasForm.TabIndex = 2;
            this.btnFamiliasForm.Text = "Familia";
            this.btnFamiliasForm.UseVisualStyleBackColor = true;
            this.btnFamiliasForm.Click += new System.EventHandler(this.btnFamiliasForm_Click);
            // 
            // btnLugaresForm
            // 
            this.btnLugaresForm.Location = new System.Drawing.Point(838, 132);
            this.btnLugaresForm.Name = "btnLugaresForm";
            this.btnLugaresForm.Size = new System.Drawing.Size(63, 23);
            this.btnLugaresForm.TabIndex = 3;
            this.btnLugaresForm.Text = "Lugares";
            this.btnLugaresForm.UseVisualStyleBackColor = true;
            this.btnLugaresForm.Click += new System.EventHandler(this.btnLugaresForm_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Location = new System.Drawing.Point(838, 187);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(63, 27);
            this.btnEventos.TabIndex = 4;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnProtagonistas
            // 
            this.btnProtagonistas.Location = new System.Drawing.Point(838, 240);
            this.btnProtagonistas.Name = "btnProtagonistas";
            this.btnProtagonistas.Size = new System.Drawing.Size(75, 23);
            this.btnProtagonistas.TabIndex = 5;
            this.btnProtagonistas.Text = "Protagonistas";
            this.btnProtagonistas.UseVisualStyleBackColor = true;
            this.btnProtagonistas.Click += new System.EventHandler(this.btnProtagonistas_Click);
            // 
            // btnRelacionesSP
            // 
            this.btnRelacionesSP.Location = new System.Drawing.Point(838, 290);
            this.btnRelacionesSP.Name = "btnRelacionesSP";
            this.btnRelacionesSP.Size = new System.Drawing.Size(75, 23);
            this.btnRelacionesSP.TabIndex = 6;
            this.btnRelacionesSP.Text = "Rel. sociales";
            this.btnRelacionesSP.UseVisualStyleBackColor = true;
            this.btnRelacionesSP.Click += new System.EventHandler(this.btnRelacionesSP_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(838, 339);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(75, 23);
            this.btnCargos.TabIndex = 7;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(839, 380);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(75, 23);
            this.btnRoles.TabIndex = 8;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnRelacionesSP);
            this.Controls.Add(this.btnProtagonistas);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnLugaresForm);
            this.Controls.Add(this.btnFamiliasForm);
            this.Controls.Add(this.btnAgregarPersonaje);
            this.Controls.Add(this.dgvPersonajes);
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
        private System.Windows.Forms.Button btnProtagonistas;
        private System.Windows.Forms.Button btnRelacionesSP;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnRoles;
    }
}

