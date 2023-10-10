using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Militar
    {
        private int id;
        private string nome;
        private string tipo;        
        private double valor;       
        private DateTime prazo;
        private string codigo;
        private int estaleiroId;

        public Militar()
        {
            this.Id = id;
            this.Nome = nome;
            this.Tipo = tipo;           
            this.Valor = valor;           
            this.Prazo = prazo;            
            this.Codigo = codigo;
            this.EstaleiroId = estaleiroId;
            
        }

        private int EstaleiroId
        {
            get
            {
                return estaleiroId;
            }
            set
            {
                estaleiroId = value;
            }
        }

        private int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        } 

        private string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                Random ale = new Random(10);
                
                value = tipo.Substring(0, 2) + ale.Next() + nome.Substring(0,2);
                codigo = value;
            }
        }

        private string Nome{
            get{
                return this.nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nome = value;
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
                return this.tipo;
            }
            set
            {
                if (value.Equals("Fragata") || value.Equals("Porta-aviões"))
                {                    
                    this.tipo = value;                    
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
                return this.valor;  
            }
            set
            {
                this.valor = value;
            }
        }    

        private DateTime Prazo
        {
            get
            {
                return this.prazo;
            }
            set
            {

                this.prazo = value;
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
            return this.codigo;
        }

        public DateTime RetornaPrazo()
        {
            return this.prazo;
        }

        public string ToString()
        {
            return nome + " | " + tipo + " | " + valor + " | " +  prazo + " | " + codigo;
        }
    }
}
