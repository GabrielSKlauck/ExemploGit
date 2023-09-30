using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Principal
    {
        public static void Main(string[] args)
        {
            Militar a1 = new Militar("BRAZILIAN BOAT", "Fragata", "Brasil", 250000000, 55, new DateOnly(2040, 09, 14));
            Carga c1 = new Carga("Navio carga 1", 50000, 150, 30, 15000, 20, new DateOnly(2040, 09, 14));
            Civil ci1 = new Civil("Lancha", 5, 120000, new DateOnly(2040, 09, 14), "Medio");
            Estaleiro estaleiro = new Estaleiro();
            while (true)
            {
                Console.WriteLine("Bem vindo ao sistema do estaleiro");
                Console.WriteLine("1 - Listar todos os navios");
                Console.WriteLine("2 - Inserir construçao de um novo navio");
                Console.WriteLine("3 - Cancelar construçao");
                Console.WriteLine("4 - Verificar prazo");                
                Console.WriteLine("0 - Sair");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        
                        Console.WriteLine(estaleiro.ListaTodos());
                        break;

                    case 2:
                        Console.Clear();
                        estaleiro.InsereNavio();
                        break;

                    case 3:
                        
                        estaleiro.CancelaNavio();
                        break;
                    case 4:
                        
                        estaleiro.PrazoNavio();
                        break;                    
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opcao invalida");
                        return;

                }
            }
        }
    }
}

