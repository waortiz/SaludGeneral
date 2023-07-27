using System.Configuration;
using System.Windows.Forms;

namespace SaludGeneral
{
    public partial class FormularioIngresoPaciente : Form
    {
        private readonly int MAXIMO_COPAGO = 200000;

        public FormularioIngresoPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    var primerNombre = txtPrimerNombre.Text;
                    var segundoNombre = txtSegundoNombre.Text;
                    var primerApellido = txtPrimerApellido.Text;
                    var segundoApellido = txtSegundoApellido.Text;
                    var numeroDocumento = txtNumeroDocumento.Text;
                    var tipoDocumento = cboTipoDocumento.SelectedItem as string;
                    var fechaNacimiento = dtpFechaNacimiento.Value;
                    var sexo = rdbFemenino.Checked ? "Femenino" :
                               rdbMasculino.Checked ? "Masculino" :
                               rdbIntersexual.Checked ? "Intersexual" : "No Establecido";
                    var titular = chkTitular.Checked ? "Titular" : "No Titular";
                    decimal copago = 0;
                    decimal.TryParse(txtCopago.Text, out copago);

                    string mensaje = $"Primer Nombre: {primerNombre}\n" +
                                     $"Segundo Nombre: {segundoNombre}\n" +
                                     $"Primer Apellido: {primerApellido} \n" +
                                     $"Segundo Apellido: {segundoApellido} \n" +
                                     $"Número de Documento: {numeroDocumento} \n" +
                                     $"Tipo de Documento: {tipoDocumento}  \n" +
                                     $"Fecha de Nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}  \n" +
                                     $"Sexo: {sexo}  \n" +
                                     $"Titular: {titular}  \n" +
                                     $"Copago: {copago.ToString("C")}";

                    MessageBox.Show(mensaje,
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor revisar los datos ingresados",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error inesperado: " + ex.Message,
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            erpError.SetError(txtPrimerNombre, null);
            erpError.SetError(txtPrimerApellido, null);
            erpError.SetError(cboTipoDocumento, null);
            erpError.SetError(txtNumeroDocumento, null);
            erpError.SetError(dtpFechaNacimiento, null);
            erpError.SetError(rdbFemenino, null);
            erpError.SetError(txtCopago, null);
            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                erpError.SetError(txtPrimerNombre, "Ingrese el primer nombre");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                erpError.SetError(txtPrimerApellido, "Ingrese el primer apellido");
                return false;
            }
            if (cboTipoDocumento.SelectedItem == null)
            {
                erpError.SetError(cboTipoDocumento, "Seleccione el tipo de documento");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                erpError.SetError(txtNumeroDocumento, "Ingrese el número de documento");
                return false;
            }
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpError.SetError(dtpFechaNacimiento, "La fecha de nacimiento " +
                    "debe ser menor a la fecha actual");
                return false;
            }
            if (!rdbFemenino.Checked && !rdbIntersexual.Checked && !rdbMasculino.Checked)
            {
                erpError.SetError(rdbFemenino, "Seleccione el sexo");
                return false;
            }
            if (string.IsNullOrEmpty(txtCopago.Text))
            {
                erpError.SetError(txtCopago, "Ingrese el COPAGO");
                return false;
            }

            for (int i = 0; i < txtCopago.TextLength; i++)
            {
                if (txtCopago.Text[i] != '0' && txtCopago.Text[i] != '1' &&
                    txtCopago.Text[i] != '2' && txtCopago.Text[i] != '3' &&
                    txtCopago.Text[i] != '4' && txtCopago.Text[i] != '5' &&
                    txtCopago.Text[i] != '6' && txtCopago.Text[i] != '7' &&
                    txtCopago.Text[i] != '8' && txtCopago.Text[i] != '9')
                {
                    erpError.SetError(txtCopago, "El COPAGO debe tener solo números");
                    return false;
                }
            }

            if (int.Parse(txtCopago.Text) > MAXIMO_COPAGO)
            {
                erpError.SetError(txtCopago, $"El COPAGO no debe ser mayor a {MAXIMO_COPAGO}");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCopago_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = e.KeyChar;
            if (tecla != '0' && tecla != '1' &&
                tecla != '2' && tecla != '3' &&
                tecla != '4' && tecla != '5' &&
                tecla != '6' && tecla != '7' &&
                tecla != '8' && tecla != '9')
            {
                e.Handled = true;
            }
        }

        private void FormularioIngresoPaciente_Load(object sender, EventArgs e)
        {
            var tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Tarjeta de Identidad" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Cédula de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Permiso Especial" });

            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";
        }
    }
}
