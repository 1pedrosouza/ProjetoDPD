using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDPD.Model
{
    public class Produto
    {
        public class Jogadores
        {
            private static int codProduto;
            private static string nomeProduto;
            private static string descricaoProduto;
            private static string valorProduto;
            private static Array fotoProduto;
            private static string retorno;

            public static int CodProduto { get => codProduto; set => codProduto = value; }
            public static string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
            public static string DescricaoProduto { get => descricaoProduto; set => descricaoProduto = value; }
            public static string ValorProduto { get => valorProduto; set => valorProduto = value; }
            public static string Retorno { get => retorno; set => retorno = value; }
            public static Array FotoProduto { get => fotoProduto; set => fotoProduto = value; }
        }
    }
}
