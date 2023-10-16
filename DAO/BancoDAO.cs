using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DAO
{
    static class BancoDAO
    {
        private const string conexao = "Server=localhost;Database=mydb;User=root;Password=root;";
        public static void InserirMilitar(string nome, string tipo, double valor, DateTime data, string codigo)
        {
            string dataFor = data.Day + "/" + data.Month + "/" + data.Year;
            string comando = $"INSERT INTO MILITAR (id, nome, tipo, codigo_navio, valor, prazo, estaleiro_id) " +
                $"values (null, '{nome}', '{tipo}','{codigo}', {valor}, STR_TO_DATE(\"{dataFor}\", \"%d/%m/%Y\"), 1)";

            try
            {

                string MyConnection = "datasource=localhost;port=3306;username=root;password=root;database=mydb";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(comando, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        

    }

        public static void InserirCarga(string nome, double comp, double lar, string codigo, double peso, double valor, DateTime data)
        {
            string dataFor = data.Day + "/" + data.Month + "/" + data.Year;
            string comando = $"INSERT INTO CARGA (id, nome, comprimento, largura, codigo_navio, peso_maximo, valor, prazo, estaleiro_id) " +
                $"values (null, '{nome}', {comp}, {lar}, '{codigo}',{peso}, {valor}, STR_TO_DATE(\"{dataFor}\", \"%d/%m/%Y\"), 1)";

            EntidadeCarga ca = new EntidadeCarga();
            ca.NOME = nome;
            ca.COMPRIMENTO = comp;
            ca.LARGURA = lar;
            ca.CODIGO_NAVIO = codigo;
            ca.PESO_MAXIMO = peso;
            ca.VALOR = valor;
            ca.PRAZO = data;

            using (MySqlConnection connection = new MySqlConnection(conexao))
            {
                
                int linhas = connection.Execute(comando, ca);
                Console.WriteLine($"Tipo inserido - {linhas} linhas afetadas");
            }
        }

        public static void InserirCivil(string nome, int max, double valor, string porte, DateTime data, string codigo)
        {
            string dataFor = data.Day + "/" + data.Month + "/" + data.Year;
            string comando = $"INSERT INTO CIVIL (id, nome, maximo_pessoas, valor, porte, prazo, codigo_navio, estaleiro_id) " +
                $"values (null, '{nome}', {max}, {valor}, '{porte}', STR_TO_DATE(\"{dataFor}\", \"%d/%m/%Y\"), '{codigo}', 1)";

            try
            {

                string MyConnection = "datasource=localhost;port=3306;username=root;password=root;database=mydb";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(comando, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();     

                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Remove(string codigo, int op)

    
        {
            string Query = "";
            switch (op)
            {
                case 1:
                    Query = $"delete from militar where codigo_navio like '{codigo}'";
                    break;
                case 2:
                    Query = $"delete from carga where codigo_navio like '{codigo}'";
                    break;
                case 3:
                    Query = $"delete from civil where codigo_navio like '{codigo}'";
                    break;
                default:
                    Console.WriteLine("Invalido");
                    return;
                    
            }
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=mydb";
                
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();               
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }

        public static async void ListaTodos()
        {
            Console.WriteLine("\n======== MILITARES ========");
            using (MySqlConnection connection = new MySqlConnection(conexao))
            {
                

                var navio = connection.Query<EntidadeMilitar>($"SELECT ID, NOME, TIPO, VALOR, PRAZO, CODIGO_NAVIO, Estaleiro_ID FROM MILITAR");
                foreach (EntidadeMilitar e in navio)
                {
                    Console.WriteLine(e.ToString());
                }              
                
            }
            Console.WriteLine("\n======== CARGA ========");
            using (MySqlConnection connection = new MySqlConnection(conexao))
            {


                var navio = connection.Query<EntidadeCarga>($"SELECT ID, NOME, COMPRIMENTO, LARGURA, CODIGO_NAVIO, PESO_MAXIMO, VALOR, PRAZO, Estaleiro_ID FROM CARGA");
                foreach (EntidadeCarga e in navio)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            Console.WriteLine("\n======== CIVIL ========");
            using (MySqlConnection connection = new MySqlConnection(conexao))
            {


                var navio = connection.Query<EntidadeCivil>($"SELECT ID, NOME, MAXIMO_PESSOAS, VALOR, PORTE, PRAZO, CODIGO_NAVIO, Estaleiro_ID FROM CIVIL");
                foreach (EntidadeCivil e in navio)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("\n");
            }




        }

        public static async void GetNavio(string codigo, int op)
        {
            switch (op)
            {
                case 1:
                    using (MySqlConnection connection = new MySqlConnection(conexao))
                    {                       
                        var navio = connection.Query<EntidadeMilitar>($"SELECT ID, NOME, TIPO, VALOR, PRAZO, CODIGO_NAVIO, Estaleiro_ID FROM MILITAR WHERE CODIGO_NAVIO LIKE \"{codigo}\"");
                        foreach (EntidadeMilitar e in navio)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                break;

                case 2:
                    using (MySqlConnection connection = new MySqlConnection(conexao))
                    {                       
                        var navio = connection.Query<EntidadeCarga>($"SELECT ID, NOME, COMPRIMENTO, LARGURA, CODIGO_NAVIO, PESO_MAXIMO, VALOR, PRAZO," +
                            $" Estaleiro_ID FROM CARGA WHERE CODIGO_NAVIO LIKE \"{codigo}\"");
                        foreach (EntidadeCarga e in navio)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                break;

                case 3:
                    using (MySqlConnection connection = new MySqlConnection(conexao))
                    {                       
                        var navio = connection.Query<EntidadeCivil>($"SELECT ID, NOME, MAXIMO_PESSOAS, VALOR, PORTE, PRAZO, CODIGO_NAVIO, Estaleiro_ID" +
                            $" FROM CIVIL WHERE CODIGO_NAVIO LIKE \"{codigo}\"");
                        foreach (EntidadeCivil e in navio)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;

            }
            
        }

        public static void UpdateNavio(string codigo)
        {
            string comando = "UPDATE TABLE MILITAR ";
        }
        }
    }

