using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2ConversorMoedas.Models
{
    /// <summary>
    /// Define o modelo de campos utilizados pelo programa
    /// </summary>
    public class EntradaDadosModel
    {
        private string? origem;

        public string? Origem
        {
            get { return origem; }
            set { origem = value?.ToUpper(); }
        }

        private string? destino;

        public string? Destino
        {
            get { return destino; }
            set { destino = value?.ToUpper(); }
        }

        public string? Valor { get; set; }
    }
}
