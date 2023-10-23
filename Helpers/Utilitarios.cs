using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Helpers
{
    public class Utilitarios
    {
        public static string GerarCodigoNavio(string tipo, string nome)
        {
            Random ale = new Random();

            return tipo.Substring(0, 2) + ale.NextInt64(10000) + nome.Substring(0, 2);
            
        }
    }
}
