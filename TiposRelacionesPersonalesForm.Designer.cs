namespace MillenniumApp
{
    partial class TiposRelacionesPersonalesForm
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
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTiposDeRelacionesPersonales = new System.Windows.Forms.ComboBox();
            this.btnAgregarTipoDeRol = new System.Windows.Forms.Button();
            this.lblRelacion = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Location = new System.Drawing.Point(25, 103);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(39, 13);
            this.lblNueva.TabIndex = 41;
            this.lblNueva.Text = "Nuevo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 40;
            // 
            // cmbTiposDeRelacionesPersonales
            // 
            this.cmbTiposDeRelacionesPersonales.FormattingEnabled = true;
            this.cmbTiposDeRelacionesPersonales.Location = new System.Drawing.Point(73, 57);
            this.cmbTiposDeRelacionesPersonales.Name = "cmbTiposDeRelacionesPersonales";
            this.cmbTiposDeRelacionesPersonales.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposDeRelacionesPersonales.TabIndex = 39;
            // 
            // btnAgregarTipoDeRol
            // 
            this.btnAgregarTipoDeRol.Location = new System.Drawing.Point(93, 123);
            this.btnAgregarTipoDeRol.Name = "btnAgregarTipoDeRol";
            this.btnAgregarTipoDeRol.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoDeRol.TabIndex = 38;
            this.btnAgregarTipoDeRol.Text = "Agregar";
            this.btnAgregarTipoDeRol.UseVisualStyleBackColor = true;
            // 
            // lblRelacion
            // 
            this.lblRelacion.AutoSize = true;
            this.lblRelacion.Location = new System.Drawing.Point(22, 60);
            this.lblRelacion.Name = "lblRelacion";
            this.lblRelacion.Size = new System.Drawing.Size(49, 13);
            this.lblRelacion.TabIndex = 37;
            this.lblRelacion.Text = "Relacion";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(22, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 36;
            this.labelId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(73, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 35;
            this.txtId.Visible = false;
            // 
            // TiposRelacionesPersonalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 171);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTiposDeRelacionesPersonales);
            this.Controls.Add(this.btnAgregarTipoDeRol);
            this.Controls.Add(this.lblRelacion);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtId);
            this.Name = "TiposRelacionesPersonalesForm";
            this.Text = "TiposRelacionesPersonalesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTiposDeRelacionesPersonales;
        private System.Windows.Forms.Button btnAgregarTipoDeRol;
        private System.Windows.Forms.Label lblRelacion;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
    }
}