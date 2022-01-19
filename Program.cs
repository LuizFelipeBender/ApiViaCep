using testing;
using Refit;
namespace ExemploApiCEP
{
    class MainClass {
        static async Task Main (string[] args)
        {
          try {
              var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");
              Console.WriteLine("Informe seu cep:");


              string cepInformado = Console.ReadLine().ToString();
              Console.WriteLine("Consultando infomações do cep: " + cepInformado);

              var address = await cepClient.GetAddressAsync(cepInformado);

              Console.WriteLine($"\n Logradouro:{address.LOGRADOURO},\n Bairro: {address.BAIRRO}, \nCidade:{address.LOCALIDADE}, \n UF:{address.UF}, \n IBGE:{address.IBGE},\n GIA:{address.GIA}, \n DDD:{address.DDD}, \n Siafi:{address.SIAFI}");  
                Console.ReadKey();
          }  catch (Exception e) 
          {
              Console.WriteLine("Erro na consulta do CEP informado"+ e.Message);
          }
        }
    }
}