using OpenQA.Selenium;

namespace lojinha_e2e.web.paginas
{
    public class ListaDeProdutosPage
    {
        private IWebDriver _browser;
        public ListaDeProdutosPage(IWebDriver driver)
        {
            _browser = driver;
        }

        public string CapturaMensagemDeBoasVindas()
        {
            string welcome = _browser.FindElement(By.PartialLinkText("Boas vindas, ")).Text;
            return welcome;
        }
    }
}
