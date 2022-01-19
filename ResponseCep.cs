using Newtonsoft.Json;
namespace ApiViaCep
{
    public class ResponseCep
    {
      [JsonProperty("cep")]
        public string CEP { get; set; }

      [JsonProperty("logradouro")]
        public string LOGRADOURO { get; set; }

      [JsonProperty("complemento")]
        public string COMPLEMENTO { get; set; }
      
      [JsonProperty("bairro")]
        public string BAIRRO { get; set; }

      [JsonProperty("localidade")]
        public string LOCALIDADE { get; set; }
      
      [JsonProperty("uf")]
        public string UF { get; set; }
      
      [JsonProperty("unidade")]
        public string UNIDADE { get; set; }
    
      [JsonProperty("ibge")]
        public string IBGE { get; set; }
      
      [JsonProperty("gia")]
        public string GIA { get; set; }
       
      [JsonProperty("ddd")]
        public string DDD { get; set; }

     [JsonProperty("siafi")]
        public string SIAFI { get; set; }
                    
    }
}