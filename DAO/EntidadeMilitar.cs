using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DAO
{
    public class EntidadeMilitar
    {
        private int ID;
        private string NOME;
        private string TIPO;
        private string CODIGO_NAVIO;
        private double VALOR;
        private DateTime PRAZO;
        private int Estaleiro_ID;


        public string ToString()
        {
            return NOME + " | " + TIPO + " | " + CODIGO_NAVIO + " | " + VALOR + " | " + PRAZO ;
        }

        public string RetornaCodigo()
        {
            return this.CODIGO_NAVIO;
        }
    }
}
