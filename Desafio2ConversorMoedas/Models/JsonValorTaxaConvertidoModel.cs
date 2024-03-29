﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2ConversorMoedas.Models
{
    /// <summary>
    /// Define o modelo de estrutura do arquivo JSON retornado pela API utilizada
    /// </summary>
    public class JsonValorTaxaConvertidoModel
    {
        public Motd? motd { get; set; }
        public bool? success { get; set; }
        public Query? query { get; set; }
        public Info? info { get; set; }
        public bool? historical { get; set; }
        public string? date { get; set; }
        public double? result { get; set; }
    }
    public class Motd
    {
        public string? msg { get; set; }
        public string? url { get; set; }
    }

    public class Query
    {
        public string? from { get; set; }
        public string? to { get; set; }
        public double? amount { get; set; }
    }

    public class Info
    {
        public double? rate { get; set; }
    }
}