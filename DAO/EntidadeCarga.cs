using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DAO
{
    public class EntidadeCarga
    {
       
        public int ID { get; set; }
        public string NOME { get; set; }
        public double COMPRIMENTO { get; set; }
        public double LARGURA { get; set; }
        public string CODIGO_NAVIO { get; set; }
        public double PESO_MAXIMO { get; set; }
        public double VALOR { get; set; }
        public DateTime PRAZO { get; set; }
        public int Estaleiro_ID { get; set; }
       

        public string ToString()
        {
            return NOME + " | " + PESO_MAXIMO + " | " + CODIGO_NAVIO + " | " + VALOR + " | " + PRAZO;
        }
    }
}
