using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DAO
{
    static class BancoDAO
    {
        
        public static void InserirMilitar(string nome, string tipo, double valor, DateOnly data, string codigo)
        {
            string comando = $"INSERT INTO MILITAR (id, nome, tipo, codigo_navio, valor, prazo, estaleiro_id) " +
                $"values (null, '{nome}', '{tipo}','{codigo}', {valor}, {data}, 1)";

            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=mydb";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(comando, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                Console.WriteLine("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void InserirCarga(string nome, double comp, double lar, string codigo, double peso, double valor, DateOnly data)
        {
            string comando = $"INSERT INTO CARGA (id, nome, comprimento, largura, codigo_navio, peso_maximo, valor, prazo, estaleiro_id) " +
                $"values (null, '{nome}', {comp}, {lar}, '{codigo}',{peso}, {valor}, {data}, 1)";

            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=mydb";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(comando, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InserirCivil(string nome, int max, double valor, string porte, DateOnly data, string codigo)
        {
            string comando = $"INSERT INTO CIVIL (id, nome, maximo_pessoas, valor, porte, prazo, codigo_navio, estaleiro_id) " +
                $"values (null, '{nome}', {max}, {valor}, '{porte}', {data}, '{codigo}', 1)";

            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root;database=mydb";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(comando, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
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

        
    }
}
