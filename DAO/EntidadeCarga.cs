using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DAO
{
    public class EntidadeCarga
    {
        private int ID;
        private string NOME;
        private string COMPRIMENTO;
        private string LARGURA;       
        private string CODIGO_NAVIO;
        private double PESO_MAXIMO;
        private double VALOR;
        private DateTime PRAZO;
        private int Estaleiro_ID;

        public string ToString()
        {
            return NOME + " | " + PESO_MAXIMO + " | " + CODIGO_NAVIO + " | " + VALOR + " | " + PRAZO;
        }
    }
}
