namespace MillenniumApp
{
    partial class TiposCargoForm
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
            this.btnAgregarTipoDeCargo = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbTiposDeCargos = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarTipoDeCargo
            // 
            this.btnAgregarTipoDeCargo.Location = new System.Drawing.Point(84, 114);
            this.btnAgregarTipoDeCargo.Name = "btnAgregarTipoDeCargo";
            this.btnAgregarTipoDeCargo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoDeCargo.TabIndex = 24;
            this.btnAgregarTipoDeCargo.Text = "Agregar";
            this.btnAgregarTipoDeCargo.UseVisualStyleBackColor = true;
            this.btnAgregarTipoDeCargo.Click += new System.EventHandler(this.btnAgregarTipoDeCargo_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(13, 51);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 20;
            this.lblCargo.Text = "Cargo";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 19;
            this.labelId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 14;
            this.txtId.Visible = false;
            // 
            // cmbTiposDeCargos
            // 
            this.cmbTiposDeCargos.FormattingEnabled = true;
            this.cmbTiposDeCargos.Location = new System.Drawing.Point(64, 48);
            this.cmbTiposDeCargos.Name = "cmbTiposDeCargos";
            this.cmbTiposDeCargos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposDeCargos.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // TiposCargoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 156);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTiposDeCargos);
            this.Controls.Add(this.btnAgregarTipoDeCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtId);
            this.Name = "TiposCargoForm";
            this.Text = "TiposCargoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarTipoDeCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbTiposDeCargos;
        private System.Windows.Forms.TextBox txtNombre;
    }
}