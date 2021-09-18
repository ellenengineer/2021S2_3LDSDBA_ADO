using System;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Net.Http.Formatting;
using Model;
using System.Text;

namespace TesteAPIBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get();
            Post();
            //InserirCliente();
            // AtualizarCliente();
            //ExcluirCliente();
            Console.ReadLine();
        }

        static void InserirCliente()
        {
            using (var client = new HttpClient())
            {
                ClientePF cli = new ClientePF();
                cli.Nome = "Ellen";
                cli.DtNascFund = new DateTime(1986, 01, 28);
                cli.Email = "ellen.santos@pentagonoedu.com.br";
                cli.Endereco = "São Bernardo do Campo";
                cli.CPF = "999.999.999-99";
                cli.Renda = 500000.00;
                cli.Sexo = "F";
                cli.TipoCliente = TipoCliente.PF;

                client.BaseAddress = new Uri("https://localhost:44348/fapen/clientepf");
                var response = client.PutAsJsonAsync("clientepf", cli).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ! " + response.ToString());
                }
                else
                    Console.Write("Erro ao inserir cliente: " + response.ToString());
            }
        }
        private static void Get()
        {/*//Criando uma requisição*/
            var request = (HttpWebRequest)WebRequest.Create("https://localhost:44348/fapen/clientepf/4");
            //var request = (HttpWebRequest)WebRequest.Create("https://localhost:44348/fapen/clientepf/QtdClientes");
            //var request = (HttpWebRequest)WebRequest.Create("https://localhost:44348/fapen/clientepf/");
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }

        private static void Post()
        {
            //var request = (HttpWebRequest)WebRequest.Create("https://localhost:44348/fapen/clientepf/Details");


            using (var client = new HttpClient())
            {

                ClientePF cli = new ClientePF();
                cli.ID = 4;
                cli.Nome = "Ellen santos";
                cli.DtNascFund = new DateTime(1986, 01, 28);
                cli.Email = "ellen.santos@pentagonoedu.com.br";
                cli.Endereco = "São Bernardo do Campo";
                cli.CPF = "999.999.999-25";
                cli.Renda = 600000.00;
                cli.Sexo = "F";

                client.BaseAddress = new Uri("https://localhost:44348/fapen/clientepf");
                var response = client.PostAsJsonAsync("clientepf", cli).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso dar post no cliente! " + response.ToString());
                }
                else
                    Console.Write("Erro ao dar post cliente: " + response.ToString());
            }

        }

        static void AtualizarCliente()
        {
            using (var client = new HttpClient())
            {

                ClientePF cli = new ClientePF();
                cli.ID = 1;
                cli.Nome = "Ellen santos";
                cli.DtNascFund = new DateTime(1986, 01, 28);
                cli.Email = "ellen.santos@pentagonoedu.com.br";
                cli.Endereco = "São Bernardo do Campo";
                cli.CPF = "999.999.999-25";
                cli.Renda = 600000.00;
                cli.Sexo = "F";

                client.BaseAddress = new Uri("https://localhost:44348/fapen/clientepf");
                var response = client.PutAsJsonAsync("clientepf", cli).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ao atualizar cliente! " + response.ToString());
                }
                else
                    Console.Write("Erro ao atualizar cliente: " + response.ToString());
            }
        }

        static void ExcluirCliente()
        {
            int idCliente = 1;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44348/fapen/clientepf");
                var response = client.DeleteAsync("clientepf/" + idCliente).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ao excluir cliente! " + response.ToString());
                }
                else
                    Console.Write("Erro ao excluir cliente: " + response.ToString());
            }
        }
    }
}
