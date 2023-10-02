using POO.DAO;
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
            BancoDAO.InserirMilitar(1,"Navio muito foda","Fragata",23, new DateOnly(2030, 05, 05), "Fr34343sda");    
           /* while (true)
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
            }*/
        }
    }
}

