using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carga
    {
        private string nome;
        private double maxCarga;
        private double comprimento;
        private double largura;
        private double peso;
        private int minPessoas;
        private DateOnly prazo;
        private string codigo;

        public Carga(string nome, double maxCarga, double comprimento, double largura, double peso, int minPessoas, DateOnly prazo)
        {
            this.Nome = nome;
            this.MaxCarga = maxCarga;
            this.Comprimento = comprimento;
            this.Largura = largura;
            this.Peso = peso;
            this.MinPessoas = minPessoas;
            this.Prazo = prazo;
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

                value = nome.Substring(0, 2) + ale.Next();
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
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

        public double MaxCarga
        {
            get
            {
                return maxCarga;
            }
            set
            {
                maxCarga = value;
            }
        }

        public double Comprimento
        {
            get
            {
                return comprimento;
            }
            set
            {
                comprimento = value;    
            }
        }

        public double Largura
        {
            get
            {
                return largura;
            }
            set
            {
                largura = value;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }

        public int MinPessoas
        {
            get
            {
                return minPessoas;
            }
            set
            {
                minPessoas = value;
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

        public string RetornaCodigo()
        {
            return this.codigo;
        }

        public DateOnly RetornaPrazo()
        {
            return this.prazo;
        }

        public void CalcArea()
        {
            Console.WriteLine("Ainda nao implementado");
        }

        public void Flutua(){
            Console.WriteLine("Ainda nao implementado");
        }

        public string ToString()
        {
            return nome + " " + maxCarga + " " + comprimento + " " + peso + " " + codigo;
        }


    }
}
