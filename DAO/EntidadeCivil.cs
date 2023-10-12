using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DAO
{
    public class EntidadeCivil
    {
        public int ID; 

        public string NOME;

        public int MAXIMO_PESSOAS;

        public double VALOR;

        public string PORTE;

        public DateTime PRAZO;

        public string CODIGO_NAVIO;

        public int Estaleiro_ID;

        public string ToString()
        {
            return ID + " | " + NOME + " | " + PORTE + " | " + CODIGO_NAVIO;
        }
    }
}
