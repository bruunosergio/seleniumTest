using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Teste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br");
            //Assert.Pass();
        }
    }
}