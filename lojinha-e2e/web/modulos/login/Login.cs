using lojinha_e2e.web.paginas;
using lojinha_e2e.web.setup;
using NUnit.Framework;

namespace lojinha_e2e.web.modulos.login
{
    public class Login
    {
        Setup driver = new Setup();

        [Test]
        public void RealizaLoginComUserAdmin()
        {
            string welcome = new LoginPage(driver.StartBrowser())
                .InformarUsuarioESenha("admin", "admin")
                .CapturaMensagemDeBoasVindas();
            Assert.AreEqual("Boas vindas, admin!", welcome);
            driver.Dispose();
        }
    }
}
