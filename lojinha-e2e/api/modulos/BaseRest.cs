using RestSharp;

namespace lojinha_e2e.api.modulos
{
    public class BaseRest
    {
        public RestClient baseApiRest()
        {
            return new RestClient("http://165.227.93.41/lojinha");
        }
    }
}
