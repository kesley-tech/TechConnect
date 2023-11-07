using RestSharp;
using System;
using System.Threading.Tasks;

namespace TechConnect
{
    public class ConsultaCEP
    {
        public static Endereco GetCEPInformation(int cep)
        {
            var client = new RestClient("https://viacep.com.br");
            var request = new RestRequest($"/ws/{cep}/json/", Method.Get);

            var response =  client.Execute(request);

            if (response.IsSuccessful)
            {
                Endereco endereco = Newtonsoft.Json.JsonConvert.DeserializeObject<Endereco>(response.Content);

                return endereco;
            }
            else
            {
                Console.WriteLine($"Falha na solicitação. Status Code: {response.StatusCode}");
            }

            return null;
        }
    }
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
    }
}
