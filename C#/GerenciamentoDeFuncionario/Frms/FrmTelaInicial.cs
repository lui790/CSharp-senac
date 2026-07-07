using GerenciamentoDeFuncionario.Frms;

namespace GerenciamentoDeFuncionario
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnSouAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLoginAdministrador().ShowDialog();
            this.Show();
        }
    }
}
