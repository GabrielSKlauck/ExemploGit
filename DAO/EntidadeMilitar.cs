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
        private double VALOR;
        private DateTime PRAZO;
        private int Estaleiro_ID;


        public string ToString()
        {
            return NOME + " | " + TIPO + " | " + VALOR + " | " + PRAZO ;
        }
    }
}
