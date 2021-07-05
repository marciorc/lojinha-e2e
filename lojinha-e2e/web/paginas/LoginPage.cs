using OpenQA.Selenium;

namespace lojinha_e2e.web.paginas
{
    public class LoginPage
    {
        private IWebDriver _browser;
        public LoginPage(IWebDriver driver)
        {
            _browser = driver;
        }

        public ListaDeProdutosPage InformarUsuarioESenha(string usuario, string senha)
        {
            _browser.FindElement(By.Id("usuario")).SendKeys(usuario);
            _browser.FindElement(By.Id("senha")).SendKeys(senha);
            _browser.FindElement(By.CssSelector("button")).Click();
            return new ListaDeProdutosPage(_browser);
        }
    }
}
