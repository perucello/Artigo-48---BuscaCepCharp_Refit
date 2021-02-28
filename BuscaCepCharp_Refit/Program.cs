using BuscaCepWeb.Executar;
using System;

namespace BuscaCepWeb
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            /*
            //Testando Busca de CEP por argumento
            await BuscaCepConsoleAsync();
            */

            //Testando Busca de CEP por Objeto
            await BuscaCepObjectAsync();
        }

        private static async System.Threading.Tasks.Task BuscaCepConsoleAsync()
        {
            _exec_console console = new _exec_console();
            await console.BuscarCepPorConsoleAsync();
        }

        private static async System.Threading.Tasks.Task BuscaCepObjectAsync()
        {
            _exec_object obj = new _exec_object();
            await obj.BuscarCepPorOBjetoAsync();
        }

    }
}
