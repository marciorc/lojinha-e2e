using Newtonsoft.Json.Linq;
using RestSharp;
using NUnit.Framework;
using lojinha_e2e.api.modulos;

namespace lojinha_e2e.api
{
    public class LoginComAdmin
    {
        [Test]
        public void RealizaLoginComUserAdmin()
        {
            // Arrange
            BaseRest baseRest = new BaseRest();
            var client = baseRest.baseApiRest();

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
