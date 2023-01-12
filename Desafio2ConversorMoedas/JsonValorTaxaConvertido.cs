using Desafio2ConversorMoedas.Models;

namespace ConversorMoedas
{
    public class JsonValorTaxaConvertido : JsonValorTaxaConvertidoModel
    {
        public float GetTaxaConversao()
        {
            return info.rate;
        }
    }


}