using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDPD.Controller
{
    class conexaoBD
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pedro.hsalves2\source\repos\ProjetoDPD\ProjetoDPD\DBProjeto.mdf;Integrated Security=True";
        }
    }
}
