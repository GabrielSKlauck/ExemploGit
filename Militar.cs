using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Militar
    {
        private int ID;
        private string NOME;
        private string TIPO;        
        private double VALOR;       
        private DateTime PRAZO;
        private string CODIGO;
        private int ESTALEIROID;

        public Militar(string NOME, string TIPO, string COIGO, double VALOR, DateTime PRAZO)
        {
            
            this.Nome = NOME;
            this.Tipo = TIPO;
            this.Valor = VALOR;
            this.Prazo = PRAZO;
            this.Codigo = CODIGO;
        }                

        private int EstaleiroId
        {
            get
            {
                return ESTALEIROID;
            }
            set
            {
                ESTALEIROID = value;
            }
        }

        private int Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        } 

        private string Codigo
        {
            get
            {
                return CODIGO;
            }
            set
            {
                Random ale = new Random(5);
                
                value = TIPO.Substring(0, 2) + ale.Next() + NOME.Substring(0,2);
                CODIGO = value;
            }
        }

        private string Nome{
            get{
                return this.NOME;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.NOME = value;
                }
                else
                {
                    throw new Exception("Nome invalido");
                }
                
            }
        }

        private string Tipo
        {
            get { 
                return this.TIPO;
            }
            set
            {
                if (value.Equals("Fragata") || value.Equals("Porta-aviões"))
                {                    
                    this.TIPO = value;                    
                }
                else
                {
                    throw new Exception("Tipo de embracaçao invalida");
                }
                
            }
        }       

        private double Valor
        {
            get
            {
                return this.VALOR;  
            }
            set
            {
                this.VALOR = value;
            }
        }    

        private DateTime Prazo
        {
            get
            {
                return this.PRAZO;
            }
            set
            {

                DateTime dataFor = DateTime.Parse(value.Day + "/" + value.Month + "/" + value.Year);
                PRAZO = dataFor;
            }
        }       

        public void Motorizacao()
        {
            Console.WriteLine("Ainda nao implementado");
        }

        public void TestarCanhoes()
        {
            Console.WriteLine("Ainda nao implementado");
        }

        public void Infos()
        {
            Console.WriteLine("Informaçoes confidenciais");
        }
        
        public string RetornaCodigo()
        {
            return this.CODIGO;
        }

        public DateTime RetornaPrazo()
        {
            return this.PRAZO;
        }

        public string ToString()
        {
            return NOME + " | " + TIPO + " | " + VALOR + " | " +  PRAZO + " | " + CODIGO;
        }
    }
}
