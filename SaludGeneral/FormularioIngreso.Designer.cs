namespace SaludGeneral
{
    partial class FormularioIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioIngreso));
            this.gboUsuario = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.picIngreso = new System.Windows.Forms.PictureBox();
            this.gboUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // gboUsuario
            // 
            this.gboUsuario.Controls.Add(this.txtClave);
            this.gboUsuario.Controls.Add(this.lblClave);
            this.gboUsuario.Controls.Add(this.txtUsuario);
            this.gboUsuario.Controls.Add(this.lblUsuario);
            this.gboUsuario.Location = new System.Drawing.Point(231, 64);
            this.gboUsuario.Name = "gboUsuario";
            this.gboUsuario.Size = new System.Drawing.Size(541, 200);
            this.gboUsuario.TabIndex = 0;
            this.gboUsuario.TabStop = false;
            this.gboUsuario.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(143, 127);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(371, 23);
            this.txtClave.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(52, 135);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(36, 15);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(371, 23);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(52, 47);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "&Usuario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Location = new System.Drawing.Point(0, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(800, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.Location = new System.Drawing.Point(0, 312);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(800, 41);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // picIngreso
            // 
            this.picIngreso.Image = global::SaludGeneral.Properties.Resources.building_healthcare_hospital_medical_nursing_icon1;
            this.picIngreso.Location = new System.Drawing.Point(12, 73);
            this.picIngreso.Name = "picIngreso";
            this.picIngreso.Size = new System.Drawing.Size(199, 191);
            this.picIngreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIngreso.TabIndex = 3;
            this.picIngreso.TabStop = false;
            // 
            // FormularioIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.picIngreso);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gboUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularioIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.gboUsuario.ResumeLayout(false);
            this.gboUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboUsuario;
        private Button btnCancelar;
        private Button btnIngresar;
        private PictureBox picIngreso;
        private TextBox txtClave;
        private Label lblClave;
        private TextBox txtUsuario;
        private Label lblUsuario;
    }
}