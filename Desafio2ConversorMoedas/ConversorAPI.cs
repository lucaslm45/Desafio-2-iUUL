using Desafio2ConversorMoedas.Models;
using System.Security.Cryptography;
using System.Text.Json;

namespace ConversorMoedas
{
    public class ConversorAPI
    {
        public string UriAPI { get; private set; }
        public HttpClient Cliente { get; private set; }
        public JsonValorTaxaConvertido? ValorConvertido { get; private set; }
        public EntradaDadosModel Dados { get; private set; }

        public ConversorAPI() 
        {
            UriAPI = "https://api.exchangerate.host/convert?from=";
            Cliente = new HttpClient();
            Dados = new EntradaDadosModel();
        }
        public void ConverteMoeda(string origem, string destino, string valor)
        {
            var uriConsulta = UriAPI + origem + "&to=" + destino + "&amount=" + valor;

            Console.WriteLine("\nBuscando informações na API...");

            var response = Cliente.GetAsync(uriConsulta).Result;

            if (response.IsSuccessStatusCode)
            {
                Dados.Origem = origem;
                Dados.Destino = destino;
                Dados.Valor = valor;

                var conteudoTask = response.Content.ReadAsStringAsync();
                conteudoTask.Wait();

                ValorConvertido = JsonSerializer.Deserialize<JsonValorTaxaConvertido>(conteudoTask.Result);

                if (ValorConvertido is null || ValorConvertido.result == null || ValorConvertido.GetTaxaConversao() == null)
                    throw new Exception("Erro: O formato da moeda de origem ou destino não é válido");

                Console.WriteLine("Consulta na API concluída.");

                MostraResultadoConversao();
            }
            else
                throw new Exception($"Erro: {response.StatusCode} + \" - \" + {response.ReasonPhrase}");
        }
        private void MostraResultadoConversao()
        {
            var valorOriginal = string.Format("{0:0.00}", Dados.Valor);
            var valorConvertido = string.Format("{0:0.00}", ValorConvertido?.result);
            var valorTaxa = string.Format("{0:0.000000}", ValorConvertido?.GetTaxaConversao());
            Console.WriteLine($"\n{Dados.Origem} {valorOriginal} => {Dados.Destino} {valorConvertido}");
            Console.WriteLine($"Taxa: {valorTaxa}\n");
        }
    }
}
