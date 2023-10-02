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
        static private string servidor = "localhost";
        static private string bancoDados = "mydb";
        static private string usuario = "root";
        static private string senha = "root";

        static public string strConn = $"server={servidor};User Id = {usuario}; database={bancoDados}; password={senha}";

        public static void Conectar()
        {
            try
            {
                using (var cn = new MySqlConnection(strConn))
                {
                    cn.Open();
                    Console.WriteLine("Sucesso");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InserirMilitar(int id, string nome, string tipo, double valor, DateOnly data, string codigo)
        {
            string comando = $"INSERT INTO MILITAR (id, nome, tipo, codigo_navio, valor, prazo, estaleiro_id) " +
                $"values ({id}, '{nome}', '{tipo}','{codigo}', {valor}, {data}, 1)";

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
    }
}
