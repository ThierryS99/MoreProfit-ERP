using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Profit___ERP_Open_Source.Models.Cadastros
{
    internal class CadastroProduto
    {
        public string? CodigoProduto { get; set; }
        public string? Descricao { get; set; }
        public string? DescricaoComplementar { get; set; }

        public CadastroProduto() { }
        public CadastroProduto(string codigoProduto, string descricao, string descricaoComplementar)
        {
            CodigoProduto = codigoProduto;
            Descricao = descricao;
            DescricaoComplementar = descricaoComplementar;
        }
    }
}
