using Desafio2ConversorMoedas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2ConversorMoedas
{
    public class Controlador
    {
        bool isValid = false;
        public Controlador()
        {
            UI = new InterfaceUsuario();
            Validador = new Validador();
        }

        public InterfaceUsuario UI { get; set; }
        public Validador Validador { get; set; }
        public void Inicia()
        {
            try
            {
                SolicitaInformações();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SolicitaInformações()
        {
            do
            {
                SolicitaFormatoMoedaOrigem();
                SolicitaFormatoMoedaDestino();
                SolicitaValorConversao();

                throw new NotImplementedException();
                //Api respondeu?
                //Busca na API
                //Retorno é valido?
                //  Mostra na tela
                //Senão
                //  Erro:
                //Senao
                //  Erro: Api fora de alcance

            } while (UI.GetOrigem() != "");
        }
        private void SolicitaFormatoMoedaOrigem()
        {
            do
            {
                UI.SolicitaFormatoMoedaOrigem();

                isValid = Validador.IsValidOrigem(UI.GetOrigem());
            } while (!isValid);
        }
        private void SolicitaFormatoMoedaDestino()
        {
            do
            {
                UI.SolicitaFormatoMoedaDestino();
                isValid = Validador.IsValidDestino(UI.GetDestino());
            } while (!isValid);
        }
        private void SolicitaValorConversao()
        {
            do
            {
                UI.SolicitaValorConversao();
                isValid = Validador.IsValidValor(UI.GetValor());
            } while (!isValid);
        }
    }
}
