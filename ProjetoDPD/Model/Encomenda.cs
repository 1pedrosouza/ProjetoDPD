using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDPD.Model
{
    public class Encomenda
    {

        private static int codEncomenda;
        private static string nomeEncomenda1;
        private static string nomeEncomenda2;
        private static string nomeEncomenda3;
        private static string valorTotal;
        private static string nomeCliente;
        private static string cepCliente;
        private static string retorno;
        private static string qtd1;
        private static string qtd2;
        private static string qtd3;

        public static int CodEncomenda { get => codEncomenda; set => codEncomenda = value; }
        public static string NomeEncomenda1 { get => nomeEncomenda1; set => nomeEncomenda1 = value; }
        public static string NomeEncomenda2 { get => nomeEncomenda2; set => nomeEncomenda2 = value; }
        public static string NomeEncomenda3 { get => nomeEncomenda3; set => nomeEncomenda3 = value; }
        public static string ValorTotal { get => valorTotal; set => valorTotal = value; }
        public static string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public static string CepCliente { get => cepCliente; set => cepCliente = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
        public static string Qtd1 { get => qtd1; set => qtd1 = value; }
        public static string Qtd2 { get => qtd2; set => qtd2 = value; }
        public static string Qtd3 { get => qtd3; set => qtd3 = value; }
    }
}
