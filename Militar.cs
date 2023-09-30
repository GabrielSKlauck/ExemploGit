using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Militar
    {
        private string nome;
        private string tipo;
        private int qtdCanhoes;
        private string comprador;
        private double valor;
        private int minPessoas;
        private DateOnly prazo;
        private string codigo;       
        private List<int> listaNum = new List<int>();

        public Militar(string nome, string tipo, string comprador, double valor, int minPessoas, DateOnly prazo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Comprador = comprador;
            this.Valor = valor;
            this.MinPessoas = minPessoas;
            this.Prazo = prazo;
            this.QtdCanhoes = qtdCanhoes;
            this.Codigo = codigo;
            
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

        private int QtdCanhoes
        {
            get {
                return this.qtdCanhoes;            
            }
            set
            {
                if (this.tipo.Equals("Fragata"))
                {
                    this.qtdCanhoes = 6;
                }else if (this.tipo.Equals("Porta-aviões"))
                {
                    this.qtdCanhoes = 0;
                }               
            }
        }

        private string Comprador
        {
            get
            {
                return this.comprador;
            }
            set
            {
                this.comprador = value;
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

        private int MinPessoas
        {
            get
            {
                return this.minPessoas;
            }
            set
            {
                this.minPessoas = value;
            }
        }

        private DateOnly Prazo
        {
            get
            {
                return this.prazo;
            }
            set
            {

                this.prazo = value.AddDays(0).AddMonths(0).AddYears(0);
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

        public DateOnly RetornaPrazo()
        {
            return this.prazo;
        }

        public string ToString()
        {
            return nome + " " + tipo + " " + valor + " " + comprador + " " + prazo + " " + codigo;
        }
    }
}
