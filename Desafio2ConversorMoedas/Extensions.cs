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
        /// <summary>
        /// Verifica se um texto possui três caracteres e se não é um número
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool PossuiTresCaracteres(this string? palavra)
        {
            if (palavra?.Length != 3)
                throw new Exception("Erro: o formato de moeda informado não possui três caracteres.");
            if (double.TryParse(palavra, out double resultado))
                throw new Exception("Erro: o formato de moeda informado é um número.");

            return true;
        }
        /// <summary>
        /// Verifica se um texto é um número
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double IsValorNumerico(this string? valor)
        {
            return !double.TryParse(valor, out double valorConvertido)
                ? throw new Exception("Erro: o Valor informado não é um número.")
                : valorConvertido;
        }

        public static bool EncerrarProcessoComErro(this Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}
