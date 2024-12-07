namespace Millennium
{
    partial class ProtagonistasForm
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
            this.dgvProtagonistas = new System.Windows.Forms.DataGridView();
            this.cmbPersonaje = new System.Windows.Forms.ComboBox();
            this.txtDescripcionProtagonista = new System.Windows.Forms.TextBox();
            this.btnAgregarProtagonista = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.lblPersonajes = new System.Windows.Forms.Label();
            this.txtBuscarEvento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.labelRoles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtagonistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProtagonistas
            // 
            this.dgvProtagonistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtagonistas.Location = new System.Drawing.Point(280, 5);
            this.dgvProtagonistas.Name = "dgvProtagonistas";
            this.dgvProtagonistas.Size = new System.Drawing.Size(572, 433);
            this.dgvProtagonistas.TabIndex = 0;
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(29, 10);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(107, 21);
            this.cmbPersonaje.TabIndex = 1;
            // 
            // txtDescripcionProtagonista
            // 
            this.txtDescripcionProtagonista.Location = new System.Drawing.Point(12, 309);
            this.txtDescripcionProtagonista.Multiline = true;
            this.txtDescripcionProtagonista.Name = "txtDescripcionProtagonista";
            this.txtDescripcionProtagonista.Size = new System.Drawing.Size(240, 74);
            this.txtDescripcionProtagonista.TabIndex = 2;
            // 
            // btnAgregarProtagonista
            // 
            this.btnAgregarProtagonista.Location = new System.Drawing.Point(76, 389);
            this.btnAgregarProtagonista.Name = "btnAgregarProtagonista";
            this.btnAgregarProtagonista.Size = new System.Drawing.Size(100, 35);
            this.btnAgregarProtagonista.TabIndex = 3;
            this.btnAgregarProtagonista.Text = "Agregar";
            this.btnAgregarProtagonista.UseVisualStyleBackColor = true;
            this.btnAgregarProtagonista.Click += new System.EventHandler(this.btnAgregarProtagonista_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(220, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 20);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(12, 94);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(240, 142);
            this.dgvEventos.TabIndex = 6;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // lblPersonajes
            // 
            this.lblPersonajes.AutoSize = true;
            this.lblPersonajes.Location = new System.Drawing.Point(142, 18);
            this.lblPersonajes.Name = "lblPersonajes";
            this.lblPersonajes.Size = new System.Drawing.Size(59, 13);
            this.lblPersonajes.TabIndex = 8;
            this.lblPersonajes.Text = "Personajes";
            // 
            // txtBuscarEvento
            // 
            this.txtBuscarEvento.Location = new System.Drawing.Point(11, 254);
            this.txtBuscarEvento.Name = "txtBuscarEvento";
            this.txtBuscarEvento.Size = new System.Drawing.Size(240, 20);
            this.txtBuscarEvento.TabIndex = 9;
            this.txtBuscarEvento.TextChanged += new System.EventHandler(this.txtBuscarEvento_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(54, 280);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "BUSCAR EVENTO";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(30, 56);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(106, 21);
            this.cmbRol.TabIndex = 11;
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Location = new System.Drawing.Point(142, 59);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(34, 13);
            this.labelRoles.TabIndex = 12;
            this.labelRoles.Text = "Roles";
            // 
            // ProtagonistasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.labelRoles);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarEvento);
            this.Controls.Add(this.lblPersonajes);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAgregarProtagonista);
            this.Controls.Add(this.txtDescripcionProtagonista);
            this.Controls.Add(this.cmbPersonaje);
            this.Controls.Add(this.dgvProtagonistas);
            this.Name = "ProtagonistasForm";
            this.Text = "ProtagonistasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtagonistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProtagonistas;
        private System.Windows.Forms.ComboBox cmbPersonaje;
        private System.Windows.Forms.TextBox txtDescripcionProtagonista;
        private System.Windows.Forms.Button btnAgregarProtagonista;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label lblPersonajes;
        private System.Windows.Forms.TextBox txtBuscarEvento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label labelRoles;
    }
}