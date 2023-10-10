using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace POO.DAO
{
    internal class ArquivoDAO
    {
        private static string caminhoM = "./ArquivoM.txt";
        private static string caminhoCa = "./ArquivoCa.txt";
        private static string caminhoCi = "./ArquivoCi.txt";
        public void AdicionarMilitar(Militar navio)
        {
            CriaArquivo(1); //Cria o arquivo se nao existir

            StreamReader leitura;
            StreamWriter escreve;
            

            leitura = File.OpenText(caminhoM);
            List<Militar> lista;

            try
            {
                try
                {
                    lista = JsonSerializer.Deserialize<List<Militar>>(leitura.ReadToEnd());

                    lista.Add(navio);

                    leitura.Close();

                    string serial = JsonSerializer.Serialize(lista);
                    ApagaTudoInterno(1);
                    escreve = File.AppendText(caminhoM);
                    escreve.WriteLine(serial);
                    escreve.Close();
                }
                catch (JsonException je)
                {
                    string serial = JsonSerializer.Serialize(navio);
                    leitura.Close();
                    
                    ApagaTudoInterno(1);
                    File.WriteAllText(caminhoM, serial);
                   // escreve = File.AppendText(caminhoM);
                   // escreve.WriteLine(serial);
                  //  escreve.Close();
                }
                
            }
            catch (ArgumentNullException e)
            {
                leitura.Close();
                string serial = JsonSerializer.Serialize(navio);
                escreve = File.AppendText(caminhoM);
                escreve.WriteLine(serial);
                escreve.Close();
            }
        }

       /* public void ListarTodos()
        {
            try
            {
                StreamReader leitura;
                string caminho = "./Arquivo.txt";
                leitura = File.OpenText(caminho);

                List<Militar> lista = new List<Militar>();
                lista.Add(leitura.ReadToEnd());

                //Cria um novo vetor com os elementos do json
                List<string> ret = JsonSerializer.Deserialize<List<Militar>>(lista[0]);
                string mostra = "";

                foreach (string s in ret)
                {
                    mostra += s + " \n";
                }

                leitura.Close();
                Console.WriteLine(mostra);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Nao existem elementos");
            }
        }*/

        private void CriaArquivo(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    if (!File.Exists(caminhoM))
                    {
                        StreamWriter escreve;
                        escreve = File.CreateText(caminhoM);
                        escreve.Close();
                    }
                break;

                case 2:
                    if (!File.Exists(caminhoCa))
                    {
                        StreamWriter escreve;
                        escreve = File.CreateText(caminhoCa);
                        escreve.Close();
                    }
                    break;

                case 3:
                    if (!File.Exists(caminhoCi))
                    {
                        StreamWriter escreve;
                        escreve = File.CreateText(caminhoCi);
                        escreve.Close();
                    }
                    break;
                

            }
        }

        public static void ApagaTudoInterno(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    File.Delete(caminhoM);

                    StreamWriter escreve;
                    escreve = File.CreateText(caminhoM);
                    escreve.Close();
                    break;
                case 2:
                    File.Delete(caminhoCa);

                    
                    escreve = File.CreateText(caminhoCa);
                    escreve.Close();
                    break;
                case 3:
                    File.Delete(caminhoCi);

                    
                    escreve = File.CreateText(caminhoCi);
                    escreve.Close();
                    break;
            }
            


        }

    }
}

    

        
