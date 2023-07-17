using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1;

namespace primeiroProjetoTeste
{
    class Class1 : Tests
    {
        [Test]
        public void BuscaCep()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("57301110");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
        }
    }
}
