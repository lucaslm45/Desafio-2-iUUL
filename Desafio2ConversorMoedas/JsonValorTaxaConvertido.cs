using Desafio2ConversorMoedas.Models;

namespace ConversorMoedas
{
    public class JsonValorTaxaConvertido : JsonValorTaxaConvertidoModel
    {
        public double? GetTaxaConversao()
        {
            //return info is null ? 0 : info.rate;
            return info?.rate;
        }
    }
}
//        public Motd? motd { get; set; }
//        public bool success { get; set; }
//        public Query? query { get; set; }
//        public Info? info { get; set; }
//        public bool historical { get; set; }
//        public string? date { get; set; }
//        public double result { get; set; }

//        public double GetTaxaConversao()
//        {
//            return info is null ? 0 : info.rate;
//        }
//    }
//}
//    public class Motd
//    {
//        public string? msg { get; set; }
//        public string? url { get; set; }
//    }

//    public class Query
//    {
//        public string? from { get; set; }
//        public string? to { get; set; }
//        public int amount { get; set; }
//    }

//    public class Info
//    {
//        public Info()
//        {
//            rate = 0;
//        }
//        public double rate { get; set; }
//    }
    


//}