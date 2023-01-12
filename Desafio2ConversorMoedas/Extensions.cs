using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2ConversorMoedas
{
    public static class Extensions
    {
        public static bool PossuiTresCaracteres(this string? palavra)
        {
            if (palavra?.Length != 3)
                throw new Exception("Erro: o formato de moeda informado não possui três caracteres.");
            if (double.TryParse(palavra, out double resultado))
                throw new Exception("Erro: o formato de moeda informado é um número.");

            return true;
        }
        public static double ConverteParaValorNumericoValido(this string? valor)
        {
            if (!double.TryParse(valor, out double valorConvertido))
                throw new Exception("Erro: o Valor informado não é um número.");

            return valorConvertido > 0 ? valorConvertido : throw new Exception("Erro: o Valor informado não é maior que zero.");
        }
        public static bool IsValorNumerico(this string? valor)
        {
            return !double.TryParse(valor, out double valorConvertido)
                ? throw new Exception("Erro: o Valor informado não é um número.")
                : valorConvertido > 0;
        }
        public static bool EncerrarProcessoComErro(this Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}
