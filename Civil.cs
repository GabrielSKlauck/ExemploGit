using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Civil
    {
       // private int id;
        private string nome;
        private int maxPessoas;
        private double valor;
        private DateTime prazo;
        private string porte;
        private string codigo;

        public Civil(/*int id, */string nome, int maxPessoas, double valor, DateTime prazo, string porte)
        {
           // this.Id = id;
            this.Nome = nome;
            this.MaxPessoas = maxPessoas;
            this.Valor = valor;
            this.Prazo = prazo;
            this.Porte = porte;
            this.Codigo = codigo;
        }

      /*  private int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }*/

        private string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                Random ale = new Random(10);

                value = porte.Substring(0, 2) + nome.Substring(0, 2) + ale.Next();
                codigo = value;
            }
        }

        public string Nome
        {
            get{
                return nome;
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

        public int MaxPessoas
        {
            get
            {
                return maxPessoas;
            }
            set
            {
                maxPessoas = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
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

                this.prazo = value.AddDays(0).AddMonths(0).AddYears(0);
            }
        }

        public string Porte
        {
            get
            {
                return porte;
            }
            set
            {
                porte = value;
            }
        }

        public string RetornaCodigo()
        {
            return this.codigo;
        }

        public DateTime RetornaPrazo()
        {
            return this.prazo;
        }

        public void Flutua()
        {
            Console.WriteLine("Ainda nao implementado");
        }

        public void EstaPronto()
        {
            Console.WriteLine("Ainda nao implementado");
        }

        public string ToString()
        {
            return nome + " " + maxPessoas + " " + valor + " " + codigo;
        }

    }
}
