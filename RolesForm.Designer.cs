namespace Millennium
{
    partial class RolesForm
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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnAsignarRol = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.cmbPersonaje = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAñoFin
            // 
            this.txtAñoFin.Location = new System.Drawing.Point(98, 233);
            this.txtAñoFin.Name = "txtAñoFin";
            this.txtAñoFin.Size = new System.Drawing.Size(39, 20);
            this.txtAñoFin.TabIndex = 48;
            // 
            // txtMesFin
            // 
            this.txtMesFin.Location = new System.Drawing.Point(53, 233);
            this.txtMesFin.Name = "txtMesFin";
            this.txtMesFin.Size = new System.Drawing.Size(39, 20);
            this.txtMesFin.TabIndex = 47;
            // 
            // txtDiaFin
            // 
            this.txtDiaFin.Location = new System.Drawing.Point(8, 234);
            this.txtDiaFin.Name = "txtDiaFin";
            this.txtDiaFin.Size = new System.Drawing.Size(39, 20);
            this.txtDiaFin.TabIndex = 46;
            // 
            // txtAñoInicio
            // 
            this.txtAñoInicio.Location = new System.Drawing.Point(98, 208);
            this.txtAñoInicio.Name = "txtAñoInicio";
            this.txtAñoInicio.Size = new System.Drawing.Size(39, 20);
            this.txtAñoInicio.TabIndex = 45;
            // 
            // txtMesInicio
            // 
            this.txtMesInicio.Location = new System.Drawing.Point(53, 208);
            this.txtMesInicio.Name = "txtMesInicio";
            this.txtMesInicio.Size = new System.Drawing.Size(39, 20);
            this.txtMesInicio.TabIndex = 44;
            // 
            // txtDiaInicio
            // 
            this.txtDiaInicio.Location = new System.Drawing.Point(8, 208);
            this.txtDiaInicio.Name = "txtDiaInicio";
            this.txtDiaInicio.Size = new System.Drawing.Size(39, 20);
            this.txtDiaInicio.TabIndex = 43;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(173, 13);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(620, 425);
            this.dgvRoles.TabIndex = 42;
            // 
            // btnAsignarRol
            // 
            this.btnAsignarRol.Location = new System.Drawing.Point(17, 139);
            this.btnAsignarRol.Name = "btnAsignarRol";
            this.btnAsignarRol.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarRol.TabIndex = 41;
            this.btnAsignarRol.Text = "Asignar Rol";
            this.btnAsignarRol.UseVisualStyleBackColor = true;
            this.btnAsignarRol.Click += new System.EventHandler(this.btnAsignarRol_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(17, 106);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 40;
            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(17, 73);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbEvento.TabIndex = 39;
            this.cmbEvento.SelectedIndexChanged += new System.EventHandler(this.cmbEvento_SelectedIndexChanged);
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(17, 40);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonaje.TabIndex = 38;
            // 
            // RolesForm
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
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.btnAsignarRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.cmbPersonaje);
            this.Name = "RolesForm";
            this.Text = "RolesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnAsignarRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.ComboBox cmbPersonaje;
    }
}