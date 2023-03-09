using _Profit___ERP_Open_Source.Views.Cadastros;

namespace _Profit___ERP_Open_Source
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void apontamentoDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e) // BOTAO MENU STRIP CADASTRO PRODUTO
        {
            Form_CadastroProduto form_CadastroProduto = new Form_CadastroProduto();
            form_CadastroProduto.Show();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e) // BOTAO TELA INICIAL CADASTRO PRODUTO
        {
            Form_CadastroProduto form_CadastroProduto = new Form_CadastroProduto();
            form_CadastroProduto.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e) // BOTAO MENU STRIP CADASTRO CLIENTE
        {
            Form_CadastroCliente form_CadastroCliente = new Form_CadastroCliente();
            form_CadastroCliente.Show();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e) // BOTAO TELA INICIAL CADASTRO CLIENTE
        {
            Form_CadastroCliente form_CadastroCliente = new Form_CadastroCliente();
            form_CadastroCliente.Show();
        }
    }
}