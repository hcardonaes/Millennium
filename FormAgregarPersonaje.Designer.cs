namespace MillenniumApp
{
    partial class FormAgregarPersonaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMote = new System.Windows.Forms.TextBox();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.nudImportancia = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaNac = new System.Windows.Forms.TextBox();
            this.txtMesNac = new System.Windows.Forms.TextBox();
            this.txtAñoNac = new System.Windows.Forms.TextBox();
            this.txtDiaMuerte = new System.Windows.Forms.TextBox();
            this.txtMesMuerte = new System.Windows.Forms.TextBox();
            this.txtAñoMuerte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudImportancia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Biografia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importancia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtMote
            // 
            this.txtMote.Location = new System.Drawing.Point(104, 72);
            this.txtMote.Name = "txtMote";
            this.txtMote.Size = new System.Drawing.Size(150, 20);
            this.txtMote.TabIndex = 7;
            // 
            // txtBiografia
            // 
            this.txtBiografia.Location = new System.Drawing.Point(104, 99);
            this.txtBiografia.Multiline = true;
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(150, 20);
            this.txtBiografia.TabIndex = 8;
            // 
            // nudImportancia
            // 
            this.nudImportancia.Location = new System.Drawing.Point(104, 132);
            this.nudImportancia.Name = "nudImportancia";
            this.nudImportancia.Size = new System.Drawing.Size(150, 20);
            this.nudImportancia.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(104, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Muerte";
            // 
            // txtDiaNac
            // 
            this.txtDiaNac.Location = new System.Drawing.Point(104, 155);
            this.txtDiaNac.Name = "txtDiaNac";
            this.txtDiaNac.Size = new System.Drawing.Size(39, 20);
            this.txtDiaNac.TabIndex = 15;
            // 
            // txtMesNac
            // 
            this.txtMesNac.Location = new System.Drawing.Point(149, 155);
            this.txtMesNac.Name = "txtMesNac";
            this.txtMesNac.Size = new System.Drawing.Size(39, 20);
            this.txtMesNac.TabIndex = 16;
            // 
            // txtAñoNac
            // 
            this.txtAñoNac.Location = new System.Drawing.Point(194, 155);
            this.txtAñoNac.Name = "txtAñoNac";
            this.txtAñoNac.Size = new System.Drawing.Size(39, 20);
            this.txtAñoNac.TabIndex = 17;
            // 
            // txtDiaMuerte
            // 
            this.txtDiaMuerte.Location = new System.Drawing.Point(104, 181);
            this.txtDiaMuerte.Name = "txtDiaMuerte";
            this.txtDiaMuerte.Size = new System.Drawing.Size(39, 20);
            this.txtDiaMuerte.TabIndex = 18;
            // 
            // txtMesMuerte
            // 
            this.txtMesMuerte.Location = new System.Drawing.Point(149, 180);
            this.txtMesMuerte.Name = "txtMesMuerte";
            this.txtMesMuerte.Size = new System.Drawing.Size(39, 20);
            this.txtMesMuerte.TabIndex = 19;
            // 
            // txtAñoMuerte
            // 
            this.txtAñoMuerte.Location = new System.Drawing.Point(194, 180);
            this.txtAñoMuerte.Name = "txtAñoMuerte";
            this.txtAñoMuerte.Size = new System.Drawing.Size(39, 20);
            this.txtAñoMuerte.TabIndex = 20;
            // 
            // FormAgregarPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAñoMuerte);
            this.Controls.Add(this.txtMesMuerte);
            this.Controls.Add(this.txtDiaMuerte);
            this.Controls.Add(this.txtAñoNac);
            this.Controls.Add(this.txtMesNac);
            this.Controls.Add(this.txtDiaNac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudImportancia);
            this.Controls.Add(this.txtBiografia);
            this.Controls.Add(this.txtMote);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarPersonaje";
            this.Text = "AgregarPersonaje";
            ((System.ComponentModel.ISupportInitialize)(this.nudImportancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMote;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.NumericUpDown nudImportancia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaNac;
        private System.Windows.Forms.TextBox txtMesNac;
        private System.Windows.Forms.TextBox txtAñoNac;
        private System.Windows.Forms.TextBox txtDiaMuerte;
        private System.Windows.Forms.TextBox txtMesMuerte;
        private System.Windows.Forms.TextBox txtAñoMuerte;
    }
}