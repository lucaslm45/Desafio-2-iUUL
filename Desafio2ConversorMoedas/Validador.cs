using Desafio2ConversorMoedas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2ConversorMoedas
{
    public class Validador
    {
        public string? DadoParaValidar { get; private set; }
        public Validador()
        {
            Dados = new EntradaDadosModel();
        }
        public EntradaDadosModel Dados { get; set; }
        public bool IsValidOrigem(string valor = "")
        {
            DadoParaValidar = valor != "" ? valor : Dados.Origem;
            try
            {
                DadoParaValidar.PossuiTresCaracteres();
            }
            catch (Exception ex)
            {
                return ex.EncerrarProcessoComErro();
            }
            Dados.Origem = DadoParaValidar;
            return true;
        }
        public bool IsValidDestino(string valor = "")
        {
            DadoParaValidar = valor != "" ? valor : Dados.Destino;
            try
            {
                DadoParaValidar.PossuiTresCaracteres();
                if (DadoParaValidar == Dados.Origem)
                    throw new Exception("Erro: A moeda de origem deve ser diferente da moeda de destino.");
            }
            catch (Exception ex)
            {
                return ex.EncerrarProcessoComErro();
            }
            return true;
        }
        public bool IsValidValor(string valor = "")
        {
            DadoParaValidar = valor != "" ? valor : Dados.Destino;

            try
            {
                DadoParaValidar.IsValorNumerico();
            }
            catch (Exception ex)
            {
                return ex.EncerrarProcessoComErro();
            }
            return true;
        }
        public bool IsValidDados(EntradaDadosModel dadosParaValidacao)
        {
            Dados.Origem = dadosParaValidacao.Origem;
            Dados.Destino = dadosParaValidacao.Destino;
            Dados.Valor = dadosParaValidacao.Valor;

            return IsValidOrigem() && IsValidDestino() && IsValidValor();
        }
    }
}
