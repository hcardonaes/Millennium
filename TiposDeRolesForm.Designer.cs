namespace MillenniumApp
{
    partial class TiposDeRol
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTiposDeRoles = new System.Windows.Forms.ComboBox();
            this.btnAgregarTipoDeRol = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // cmbTiposDeRoles
            // 
            this.cmbTiposDeRoles.FormattingEnabled = true;
            this.cmbTiposDeRoles.Location = new System.Drawing.Point(73, 54);
            this.cmbTiposDeRoles.Name = "cmbTiposDeRoles";
            this.cmbTiposDeRoles.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposDeRoles.TabIndex = 32;
            // 
            // btnAgregarTipoDeRol
            // 
            this.btnAgregarTipoDeRol.Location = new System.Drawing.Point(93, 120);
            this.btnAgregarTipoDeRol.Name = "btnAgregarTipoDeRol";
            this.btnAgregarTipoDeRol.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoDeRol.TabIndex = 31;
            this.btnAgregarTipoDeRol.Text = "Agregar";
            this.btnAgregarTipoDeRol.UseVisualStyleBackColor = true;
            this.btnAgregarTipoDeRol.Click += new System.EventHandler(this.btnAgregarTipoDeRol_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(22, 57);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 30;
            this.lblRol.Text = "Rol";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(22, 28);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 29;
            this.labelId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(73, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 28;
            this.txtId.Visible = false;
            // 
            // TiposDeRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 185);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTiposDeRoles);
            this.Controls.Add(this.btnAgregarTipoDeRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtId);
            this.Name = "TiposDeRol";
            this.Text = "TiposDeRolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTiposDeRoles;
        private System.Windows.Forms.Button btnAgregarTipoDeRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
    }
}