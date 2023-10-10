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
        
        public static void InserirMilitar(string nome, string tipo, double valor, DateOnly data, string codigo)
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

        public static void InserirCarga(string nome, double comp, double lar, string codigo, double peso, double valor, DateOnly data)
        {
            string dataFor = data.Day + "/" + data.Month + "/" + data.Year;
            string comando = $"INSERT INTO CARGA (id, nome, comprimento, largura, codigo_navio, peso_maximo, valor, prazo, estaleiro_id) " +
                $"values (null, '{nome}', {comp}, {lar}, '{codigo}',{peso}, {valor}, STR_TO_DATE(\"{dataFor}\", \"%d/%m/%Y\"), 1)";

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

        public static void InserirCivil(string nome, int max, double valor, string porte, DateOnly data, string codigo)
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

            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=mydb;User=root;Password=root;"))
            {
                //"ID as id, NOME as Nome, TIPO as tipo, VALOR as valor, PRAZO as prazo, CODIGO_NAVIO as codigo, Estaleiro_ID as estaleiroId"

                var navio = connection.Query<EntidadeMilitar>($"SELECT ID, NOME, TIPO, VALOR, PRAZO, CODIGO_NAVIO, Estaleiro_ID FROM MILITAR");
                foreach (EntidadeMilitar e in navio)
                {
                    Console.WriteLine(e.ToString());
                }              
                
            }
            

            /*List<Militar> lista = new List<Militar>();
            const string connectionString = @"Server=localhost,3306;Database=mydb;User ID=root;Password=root;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True;MultiSubnetFailover=True";

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM MILITAR";
                    lista = con.Query<Militar>(query).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }

                foreach (var item in lista)
                {
                    Console.WriteLine($"{item.ToString()}");
                }

                /*
                const string connectionString = "Server=localhost,3306;Database=mydb;User ID=root;Password=root;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True;MultiSubnetFailover=True";
                await using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        var navios = connection.Query<Militar>("SELECT * FROM militar");

                        foreach (var navio in navios)
                        {
                            Console.WriteLine(navios.ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }*/

        }

        public static async void GetNavio()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=mydb;User=root;Password=root;"))
            {
                //"ID as id, NOME as Nome, TIPO as tipo, VALOR as valor, PRAZO as prazo, CODIGO_NAVIO as codigo, Estaleiro_ID as estaleiroId"

                var navio = connection.Query<EntidadeMilitar>($"SELECT ID, NOME, TIPO, VALOR, PRAZO, CODIGO_NAVIO, Estaleiro_ID FROM MILITAR");
                foreach (EntidadeMilitar e in navio)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }
        }
    }

