namespace SaludGeneral
{
    public partial class FormularioIngreso : Form
    {
        public FormularioIngreso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Este evento permite iniciar sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var form = new FormularioPrincipal();
            form.Show();
            Hide();
        }
    }
}