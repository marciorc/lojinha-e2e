using Newtonsoft.Json.Linq;
using RestSharp;
using NUnit.Framework;

namespace lojinha_e2e
{
    public class LoginComAdmin
    {
        [Test]
        public void RealizaLoginComUserAdmin()
        {
            // Arrange
            var client = new RestClient("http://165.227.93.41/lojinha");

            var request = new RestRequest("/v2/login", Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            request.AddParameter("usuarioLogin", "admin");
            request.AddParameter("usuarioSenha", "admin");

            // Act
            IRestResponse restResponse = client.Execute(request);
            int statusCode = (int)restResponse.StatusCode;
            JObject jsonResponse = JObject.Parse(restResponse.Content);
            // salvo o token na variavel para retornar
            string token = (string)jsonResponse["data"]["token"];

            // Assert
            Assert.AreEqual(200, statusCode);
            //return token;
        }
    }
}
