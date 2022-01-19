using ApiViaCep;
using Refit;

namespace testing
{
    public interface ICepApiService
    {
         [Get("/ws/{cep}/json")]
         Task<ResponseCep> GetAddressAsync(string cep);
    }
}