using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Profit___ERP_Open_Source.Models.Cadastros
{
    internal class CadastroCliente
    {
        public string? CodigoCliente { get; set; }
        public string? RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? Cnpj { get; set; }

        public CadastroCliente() { }
        public CadastroCliente(string? codigoCliente, string? razaoSocial, string? nomeFantasia, string? cnpj)
        {
            CodigoCliente = codigoCliente;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
        }
    }
}
