using lojinha_e2e.unit.helper;
using NUnit.Framework;

namespace lojinha_e2e.unit.test
{
    public class HelperTest
    {
        [Test]
        public void SomaValorInteiroTest()
        {
            Helper helper = new Helper();
            int resultado = helper.SomaValor(2, 3);
            Assert.AreEqual(5, resultado);
        }

        [Test]
        public void SomaValorZeradoTest()
        {
            Helper helper = new Helper();
            int resultado = helper.SomaValor(0, 3);
            Assert.AreEqual(3, resultado);
        }

        [Test]
        public void SomaValorNegativoTest()
        {
            Helper helper = new Helper();
            int resultado = helper.SomaValor(2, -3);
            Assert.AreEqual(-1, resultado);
        }
    }
}
