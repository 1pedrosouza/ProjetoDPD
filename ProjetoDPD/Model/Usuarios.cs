using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDPD.Model
{
    public class Usuarios
    {
        private static int codUsuario;
        private static string nomeUsuario;
        private static string emailUsuarios;
        private static string foneUsuarios;
        private static Array  fotoUsuarios;
        private static string senhaUsuarios;
        private static string retorno;

        public static int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public static string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public static string EmailUsuarios { get => emailUsuarios; set => emailUsuarios = value; }
        public static string FoneUsuarios { get => foneUsuarios; set => foneUsuarios = value; }
        public static Array FotoUsuarios { get => fotoUsuarios; set => fotoUsuarios = value; }
        public static string SenhaUsuarios { get => senhaUsuarios; set => senhaUsuarios = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
