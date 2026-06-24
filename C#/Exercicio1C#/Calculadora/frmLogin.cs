namespace Calculadora
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (nome == "Luis" && senha == "1234") ;
            {
                this.Hide();
                new Calculadora().ShowDialog();
                this.Show();
            }
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
