using ConversorMoedas;
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
        public InterfaceUsuario UI { get; private set; }
        public Validador Validador { get; private set; }
        public ConversorAPI API { get; private set; }
        public Controlador()
        {
            UI = new InterfaceUsuario();
            Validador = new Validador();
            API = new ConversorAPI();
        }

        public void Inicia()
        {
            do
            {
                try
                {
                    SolicitaFormatoMoedaOrigem();

                    if(UI.GetOrigem() == "")
                        break;

                    SolicitaFormatoMoedaDestino();
                    SolicitaValorConversao();

                    API.ConverteMoeda(UI.GetOrigem(), UI.GetDestino(), UI.GetValor());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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

                if (UI.GetOrigem() == "")
                    break;

                isValid = Validador.IsValidOrigem(UI.GetOrigem());
            } while (!isValid);/* || UI.GetOrigem() != "");*/
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
