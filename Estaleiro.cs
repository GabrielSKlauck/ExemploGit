using MySqlConnector;
using POO.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Estaleiro
    {
        private int id;
        
        public Estaleiro(int id)
        {
            this.Id = id;
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

        
        public string ListaTodos()
        {
            String mostra = "";
            try
            {
                string MyConnection2 = "datasource=localhost;port=3307;username=root;password=root;database=mydb";
                
                string Query = "select * from militar,carga,civil;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                mostra = MyAdapter.ToString();
                
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Tipo: ");
                    string tipo = Console.ReadLine();                   

                    Console.WriteLine();
                    string codigo = Console.ReadLine(); 

                    Console.WriteLine("Valor: ");
                    double valor = Convert.ToDouble(Console.ReadLine());                   

                    Console.WriteLine("Prazo (PADRAO AMERICANO): ");
                    Console.WriteLine("DIA: ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("MES: ");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ANO: ");
                    int ano = Convert.ToInt32(Console.ReadLine());

                    DateOnly data = new DateOnly(ano, mes, dia);
                    BancoDAO.InserirMilitar(nome,tipo,valor, data, codigo);

                    break;
                case 2:
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Comprimento: ");
                    double comp = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Largura: ");
                    double lar = Convert.ToDouble(Console.ReadLine());                    

                    Console.WriteLine("Codigo: ");
                    codigo = Console.ReadLine();

                    Console.WriteLine("Peso: ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Valor: ");
                    valor = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Prazo (PADRAO AMERICANO): ");
                    Console.WriteLine("DIA: ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("MES: ");
                    mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ANO: ");
                    ano = Convert.ToInt32(Console.ReadLine());

                    data = new DateOnly(ano, mes, dia);
                    BancoDAO.InserirCarga(nome, comp, lar, codigo, peso, valor, data);
                    break;
                case 3:
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Maximo de pessoas");
                    int max = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Valor: ");
                    valor = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Porte");
                    string porte = Console.ReadLine();

                    Console.WriteLine("Codigo: ");
                    codigo = Console.ReadLine();

                    Console.WriteLine("Prazo (PADRAO AMERICANO): ");
                    Console.WriteLine("DIA: ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("MES: ");
                    mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ANO: ");
                    ano = Convert.ToInt32(Console.ReadLine());

                    data = new DateOnly(ano, mes, dia);
                    BancoDAO.InserirCivil(nome,max,valor,porte,data,codigo);
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

            Console.WriteLine("Qual o codigo do navio?");
            string codigo = Console.ReadLine();

            BancoDAO.Remove(codigo, op);
        }

       /* public DateOnly PrazoNavio()
        {
            return null;
        }       */          
    }    
}
    

