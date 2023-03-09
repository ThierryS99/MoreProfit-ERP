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
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Dapper;

namespace _Profit___ERP_Open_Source.Views.Cadastros
{
    public partial class Form_CadastroProduto : Form
    {
        CadastroProduto cadastroProduto = new CadastroProduto();
        private const string CONNECTION_STRING = @"Server=localhost,1433; Database=ErpServer; User ID=sa; Password=1q2w3e4r@#$; TrustServerCertificate=True";

        public Form_CadastroProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void button_Cancelar_Click(object sender, EventArgs e) // BOTÃO CANCELAR
        {
            textBox_CodProduto.Clear();
            textBox_Descricao.Clear();
            textBox_DescricaoComplementar.Clear();
        }

        private void button_Processar_Click(object sender, EventArgs e) // BOTÃO PROCESSAR
        {
            try
            {
                textBox_CodProduto.Text = cadastroProduto.CodigoProduto;
                textBox_Descricao.Text = cadastroProduto.Descricao;
                textBox_DescricaoComplementar.Text = cadastroProduto.DescricaoComplementar;

                using (var connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Insert<CadastroProduto>(cadastroProduto);
                    {
                        Console.Clear();
                        Console.WriteLine("Cadastro realizado com sucesso!");
                    }
                }

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch { }
        }
    }
}
