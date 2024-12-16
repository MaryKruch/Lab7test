using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7test
{
    public class Class1
    {
        private IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }

        [Test]
        public void LoginButtonTest()
        {
            webDriver.Url = "https://tomesto.ru/";
            IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div[2]/div/a[1]"));
            loginButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("login"));
        }

        [Test]
        public void RegistrationButtonTest()
        {
            webDriver.Url = "https://tomesto.ru/";
            IWebElement registrationButton = webDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div[2]/div/a[2]"));
            registrationButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("register"));
        }

        [Test]
        public void SearchButtonTest()
        {
            webDriver.Url = "https://tomesto.ru/";
            IWebElement searchBox = webDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div[1]/form/input"));
            searchBox.SendKeys("новости");
            IWebElement searchButton = webDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div[1]/form/button"));
            searchButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("search"));
        }

        [Test]
        public void CatalogButtonTest()
        {
            webDriver.Url = "https://tomesto.ru/";
            IWebElement catalogButton = webDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div[1]/nav/ul/li[1]/a"));
            catalogButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("catalog"));
        }

        [Test]
        public void CartButtonTest()
        {
            webDriver.Url = "https://tomesto.ru/";
            IWebElement cartButton = webDriver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div[1]/nav/ul/li[2]/a"));
            cartButton.Click();
            Assert.IsTrue(webDriver.Url.Contains("cart"));
        }
    }
}

