using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Estaleiro
    {
        private static List<Militar> listaMilitares = new List<Militar>();
        private static List<Carga> listaCarga = new List<Carga>();
        private static List<Civil> listaCivil = new List<Civil>();

        public string ListaTodos()
        {
            string mostra = "#### NAVIOS MILITARES ####\n";
            for (int i = 0; i < listaMilitares.Count; i++)
            {
                mostra += listaMilitares[i].ToString() + "\n";
            }
            mostra += "\n#### NAVIOS CARGUEIROS ####\n";
            for (int i = 0; i < listaCarga.Count; i++)
            {
                mostra += listaCarga[i].ToString() + "\n";
            }
            mostra += "\n#### NAVIOS CIVIS ####\n";
            for (int i = 0; i < listaCivil.Count; i++)
            {
                mostra += listaCivil[i].ToString() + "\n";
            }


            return mostra;
        }

        public void InsereNavio()
        {
            Console.WriteLine("Qual o tipo do navio? \n1 - Militar \n2 - Carga \n3 - Civil");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    listaMilitares.Add(TipoMilitar());
                    break;
                case 2:
                    listaCarga.Add(TipoCarga());
                    break;
                case 3:
                    listaCivil.Add(TipoCivil());
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;

                    
            }
            
        }

        public void CancelaNavio()
        {
            Console.WriteLine("Qual o tipo do navio? \n1 - Militar \n2 - Carga \n3 - Civil");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:

                    Console.WriteLine("Qual o codigo do navio?");
                    RemoveMilitar(Console.ReadLine());
                    break;
                case 2:

                    Console.WriteLine("Qual o codigo do navio?");
                    RemoveCarga(Console.ReadLine());
                    break;
                case 3:

                    Console.WriteLine("Qual o codigo do navio?");
                    RemoveCivil(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }

        public DateOnly PrazoNavio()
        {
            Console.WriteLine("Digite o codigo do navio");
            string codigo = Console.ReadLine();

            
            for (int i = 0; i < listaMilitares.Count; i++)
            {
                if (listaMilitares[i].Equals(codigo))
                {
                    return listaMilitares[i].RetornaPrazo();
                    break;
                }
                
            }
            for (int i = 0; i < listaCarga.Count; i++)
            {
                if (listaCarga[i].Equals(codigo))
                {
                    return listaCarga[i].RetornaPrazo();
                    break;
                }

            }
            for (int i = 0; i < listaCivil.Count; i++)
            {
                if (listaCivil[i].Equals(codigo))
                {
                    return listaCivil[i].RetornaPrazo();
                    break;
                }

            }

            DateOnly sai = new DateOnly(0,0,0);
            return sai;
        }

        private static void RemoveMilitar(string codigo)
        {
            
            for (int i = 0; i < listaMilitares.Count; i++)
            {
                if (listaMilitares[i].RetornaCodigo().Equals(codigo))
                {
                    listaMilitares.RemoveAt(i);
                    break;
                }
            }
        }

        private static void RemoveCarga(string codigo) {
            for (int i = 0; i < listaCarga.Count; i++)
            {
                if (listaCarga[i].RetornaCodigo().Equals(codigo))
                {
                    listaCarga.RemoveAt(i);
                    break;
                }
            }
        }

        private static void RemoveCivil(string codigo)
        {
            for (int i = 0; i < listaCivil.Count; i++)
            {
                if (listaCivil[i].RetornaCodigo().Equals(codigo))
                {
                    listaCivil.RemoveAt(i);
                    break;
                }
            }
        }

        private static Militar TipoMilitar()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Tipo: ");
            string tipo = Console.ReadLine();

            Console.WriteLine("Comprador: ");
            string comp = Console.ReadLine();

            Console.WriteLine("Valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Minimo de pessoas: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prazo (PADRAO AMERICANO): ");
            Console.WriteLine("DIA: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MES: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ANO: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            DateOnly data = new DateOnly(ano, mes, dia);

            Militar obj = new Militar(nome, tipo, comp, valor, min,data);

            return obj;
        }

        private static Carga TipoCarga()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Carga maxima: ");
            double cargaMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Comprimento: ");
            double comp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso do navio");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Minimo de pessoas para operaçao do navio");
            int qtd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prazo (PADRAO AMERICANO): ");
            Console.WriteLine("DIA: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MES: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ANO: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            DateOnly data = new DateOnly(ano, mes, dia);

            Carga obj = new Carga(nome,cargaMax, comp, largura, peso, qtd, data);

            return obj;
        }

        private static Civil TipoCivil()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Maximo de pessoas");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Porte: ");
            string porte = Console.ReadLine();

            Console.WriteLine("Prazo (PADRAO AMERICANO): ");
            Console.WriteLine("DIA: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MES: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ANO: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            DateOnly data = new DateOnly(ano, mes, dia);

            Civil civil = new Civil(nome, max, valor, data, porte);

            return civil;
        }
    }    
}
    

