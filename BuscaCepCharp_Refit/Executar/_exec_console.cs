using CepConsoleApi;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaCepWeb.Executar
{
    public class _exec_console
    {
        public _exec_console() { }

        public async System.Threading.Tasks.Task BuscarCepPorConsoleAsync()
        {
            try
            {
                string cep = "";
                var cepClient = RestService.For<ApiService>("https://viacep.com.br/");
                Console.WriteLine("Informe o cep: ");

                string cepBuscar = Console.ReadLine().ToString();
                Console.WriteLine("Consultando " + cepBuscar);

                var address = await cepClient.GetAddressAsync(cepBuscar);

                Console.WriteLine(
                    $"\nLogradouro: {address.Logradouro }, " +
                    $"\nBairro: {address.Bairro}, " +
                    $"\nCidade: {address.Localidade}," +
                    $"\nEstado: {address.Uf}"
                    );

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("Falha de Exception " + e.Message);
            }
        }

    }
}