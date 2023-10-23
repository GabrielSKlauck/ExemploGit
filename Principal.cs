using POO.DAO;
using POO.Helpers;
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
            
            Estaleiro estaleiro = new Estaleiro(1);           

            while (true)
            {
                Console.WriteLine("Bem vindo ao sistema do estaleiro");
                Console.WriteLine("1 - Listar todos os navios");
                Console.WriteLine("2 - Inserir construçao de um novo navio");
                Console.WriteLine("3 - Cancelar construçao");
                Console.WriteLine("4 - Verificar navio em especifico");  
                Console.WriteLine("5 - Alterar navio");
                Console.WriteLine("0 - Sair");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        estaleiro.ListaTodos();
                        break;

                    case 2:
                        Console.Clear();                       
                       estaleiro.InsereNavio();
                        break;

                    case 3:
                        
                        estaleiro.CancelaNavio();
                        break;
                    case 4:
                        
                        estaleiro.GetNavio();
                        break;
                    case 5:
                        estaleiro.UpdateNavio();
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

