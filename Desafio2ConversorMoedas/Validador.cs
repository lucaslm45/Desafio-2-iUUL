using Desafio2ConversorMoedas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio2ConversorMoedas
{
    /// <summary>
    /// Define o Validador da conversão de moedas
    /// </summary>
    public class Validador
    {
        public Validador()
        {
            Dados = new EntradaDadosModel();
        }
        private EntradaDadosModel Dados { get; set; }
        /// <summary>
        /// Faz as validações para o formato de origem informado
        /// </summary>
        /// <param name="valor">Texto para ser verificado</param>
        /// <returns></returns>
        public bool IsValidOrigem(string valor)
        {
            try
            {
                valor.PossuiTresCaracteres();
                Dados.Origem = valor;
            }
            catch (Exception ex)
            {
                return ex.EncerrarProcessoComErro();
            }
            return true;
        }
        /// <summary>
        /// Faz as validações para o formato de destino
        /// </summary>
        /// <param name="valor">Texto para ser verificado</param>
        /// <returns></returns>
        public bool IsValidDestino(string valor)
        {
            try
            {
                valor.PossuiTresCaracteres();
                if (valor == Dados.Origem)
                    throw new Exception("Erro: A moeda de origem deve ser diferente da moeda de destino.");

                Dados.Destino = valor;
            }
            catch (Exception ex)
            {
                return ex.EncerrarProcessoComErro();
            }
            return true;
        }
        /// <summary>
        /// Faz as validações para o valor monetário que será convertido
        /// </summary>
        /// <param name="valor">Texto para ser verificado</param>
        /// <returns></returns>
        public bool IsValidValor(string valor)
        {
            try
            {
                var valorNumero = valor.IsValorNumerico();
                if (valorNumero < 0)
                    throw new Exception("Erro: o Valor informado não é maior que zero.");

                Dados.Valor = valorNumero.ToString(CultureInfo.GetCultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                return ex.EncerrarProcessoComErro();
            }
            return true;
        }
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
    }
}
