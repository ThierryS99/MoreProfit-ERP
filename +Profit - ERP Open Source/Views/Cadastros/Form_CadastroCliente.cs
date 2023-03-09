using _Profit___ERP_Open_Source.Models.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Profit___ERP_Open_Source.Views.Cadastros
{
    public partial class Form_CadastroCliente : Form
    {
        CadastroCliente cadastroCliente = new CadastroCliente();

        public Form_CadastroCliente()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click(object sender, EventArgs e) // BOTÃO CANCELAR
        {
            textBox_CodigoCliente.Clear();
            textBox_RazaoSocial.Clear();
            textBox_NomeFantasia.Clear();
            textBox_Cnpj.Clear();
        }

        private void button_Processar_Click(object sender, EventArgs e) // BOTÃO PROCESSAR
        {
            try
            {
                cadastroCliente.CodigoCliente = textBox_CodigoCliente.Text;
                cadastroCliente.RazaoSocial = textBox_RazaoSocial.Text;
                cadastroCliente.NomeFantasia = textBox_NomeFantasia.Text;
                cadastroCliente.Cnpj = textBox_Cnpj.Text;

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch { }
            
        }
    }
}
