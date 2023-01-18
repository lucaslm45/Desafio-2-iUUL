using Desafio2ConversorMoedas.Models;

namespace Desafio2ConversorMoedas.Interface
{
    public class InterfaceUsuario
    {
        public InterfaceUsuario()
        {
            Dados = new EntradaDadosModel();
        }

        public EntradaDadosModel Dados { get; private set; }

        public string GetOrigem()
        {
            return Dados.Origem;
        }
        public string GetDestino()
        {
            return Dados.Destino;
        }
        public string GetValor()
        {
            return Dados.Valor;
        }
        public void SolicitaInformações()
        {
            SolicitaFormatoMoedaOrigem();
            SolicitaFormatoMoedaDestino();
            SolicitaValorConversao();
        }
        public void SolicitaFormatoMoedaOrigem()
        {
            Console.Write("Moeda Origem: ");
            Dados.Origem = Console.ReadLine();
        }
        public void SolicitaFormatoMoedaDestino()
        {
            Console.Write("Moeda Destino: ");
            Dados.Destino = Console.ReadLine();
        }
        public void SolicitaValorConversao()
        {
            Console.Write("Valor no formato en-US: ");
            Dados.Valor = Console.ReadLine();
        }
    }
}
