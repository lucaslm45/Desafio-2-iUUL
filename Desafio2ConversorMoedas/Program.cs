using Desafio2ConversorMoedas;
using System.Text.Json;

namespace ConversorMoedas
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var controlador = new Controlador();

            controlador.Inicia();

            Console.WriteLine("FIM");
            //using var client = new HttpClient();

            //var result = await client.GetStringAsync("https://api.exchangerate.host/convert?from=USD&to=BRL&amount=100.0");

            //var conversao = JsonSerializer.Deserialize<JsonValorTaxaConvertido>(result);

            //Console.WriteLine($"{conversao?.GetTaxaConversao()}");
        }
    }
}