namespace SaludGeneral
{
    partial class FormularioIngresoPaciente
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
            this.components = new System.ComponentModel.Container();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.chkTitular = new System.Windows.Forms.CheckBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCopago = new System.Windows.Forms.Label();
            this.txtCopago = new System.Windows.Forms.TextBox();
            this.rdbIntersexual = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(65, 49);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(89, 15);
            this.lblPrimerNombre.TabIndex = 0;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(227, 41);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(342, 23);
            this.txtPrimerNombre.TabIndex = 1;
            this.ttpMensaje.SetToolTip(this.txtPrimerNombre, "Ingrese el primer nombre");
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(498, 545);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(252, 43);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(227, 80);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(342, 23);
            this.txtSegundoNombre.TabIndex = 3;
            this.ttpMensaje.SetToolTip(this.txtSegundoNombre, "Ingrese el segundo nombre");
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(65, 88);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(101, 15);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(227, 166);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(342, 23);
            this.txtSegundoApellido.TabIndex = 7;
            this.ttpMensaje.SetToolTip(this.txtSegundoApellido, "Ingrese el segundo apellido");
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(65, 174);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(101, 15);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(227, 127);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(342, 23);
            this.txtPrimerApellido.TabIndex = 5;
            this.ttpMensaje.SetToolTip(this.txtPrimerApellido, "Ingrese el primer apellido");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primer Apellido";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Cédula de Ciudadanía",
            "Tarjeta de Identidad",
            "Cédula de Extranjería",
            "Permiso Especial"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(227, 225);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(342, 23);
            this.cboTipoDocumento.TabIndex = 9;
            this.ttpMensaje.SetToolTip(this.cboTipoDocumento, "Seleccione el tipo de documento");
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(65, 233);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(112, 15);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(227, 277);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(342, 23);
            this.txtNumeroDocumento.TabIndex = 11;
            this.ttpMensaje.SetToolTip(this.txtNumeroDocumento, "Ingrese el número de documento");
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(65, 285);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(133, 15);
            this.lblNumeroDocumento.TabIndex = 10;
            this.lblNumeroDocumento.Text = "Número de Documento";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(234, 334);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 13;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(370, 334);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 14;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(65, 334);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "Sexo";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(233, 384);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(336, 23);
            this.dtpFechaNacimiento.TabIndex = 17;
            this.ttpMensaje.SetToolTip(this.dtpFechaNacimiento, "Seleccione la fecha de nacimiento");
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(65, 392);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(119, 15);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // chkTitular
            // 
            this.chkTitular.AutoSize = true;
            this.chkTitular.Location = new System.Drawing.Point(231, 451);
            this.chkTitular.Name = "chkTitular";
            this.chkTitular.Size = new System.Drawing.Size(15, 14);
            this.chkTitular.TabIndex = 19;
            this.chkTitular.UseVisualStyleBackColor = true;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(65, 455);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(40, 15);
            this.lblTitular.TabIndex = 18;
            this.lblTitular.Text = "Titular";
            // 
            // lblCopago
            // 
            this.lblCopago.AutoSize = true;
            this.lblCopago.Location = new System.Drawing.Point(65, 506);
            this.lblCopago.Name = "lblCopago";
            this.lblCopago.Size = new System.Drawing.Size(49, 15);
            this.lblCopago.TabIndex = 20;
            this.lblCopago.Text = "Copago";
            // 
            // txtCopago
            // 
            this.txtCopago.Location = new System.Drawing.Point(227, 497);
            this.txtCopago.Name = "txtCopago";
            this.txtCopago.Size = new System.Drawing.Size(342, 23);
            this.txtCopago.TabIndex = 21;
            this.ttpMensaje.SetToolTip(this.txtCopago, "Ingrese el COPAGO");
            this.txtCopago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCopago_KeyPress);
            // 
            // rdbIntersexual
            // 
            this.rdbIntersexual.AutoSize = true;
            this.rdbIntersexual.Location = new System.Drawing.Point(480, 334);
            this.rdbIntersexual.Name = "rdbIntersexual";
            this.rdbIntersexual.Size = new System.Drawing.Size(82, 19);
            this.rdbIntersexual.TabIndex = 15;
            this.rdbIntersexual.TabStop = true;
            this.rdbIntersexual.Text = "Intersexual";
            this.rdbIntersexual.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(227, 545);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(252, 43);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // FormularioIngresoPaciente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(762, 600);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rdbIntersexual);
            this.Controls.Add(this.txtCopago);
            this.Controls.Add(this.lblCopago);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.chkTitular);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Name = "FormularioIngresoPaciente";
            this.Text = "Ingreso Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPrimerNombre;
        private TextBox txtPrimerNombre;
        private Button btnGuardar;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private Label label3;
        private ComboBox cboTipoDocumento;
        private Label lblTipoDocumento;
        private TextBox txtNumeroDocumento;
        private Label lblNumeroDocumento;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private Label lblSexo;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private CheckBox chkTitular;
        private Label lblTitular;
        private Label lblCopago;
        private TextBox txtCopago;
        private RadioButton rdbIntersexual;
        private Button btnCancelar;
        private ToolTip ttpMensaje;
        private ErrorProvider erpError;
    }
}