using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BeerChallengeTest
{
    [TestClass]
    public class EndToEndTest
    {
        [TestClass]
        public class BeerSearchEngine
        {
            private string _BaseUrl;
            private IWebDriver _Driver;

            [TestMethod]
            public void GetOrganicBeerTest()
            {
                _Driver.Navigate().GoToUrl(_BaseUrl);
                WaitDataFromApi();
                _Driver.FindElement(By.Id("organicBtn")).Click();
                Assert.AreEqual("IsOrganic: Yes",
                    _Driver.FindElement(By.CssSelector("#app > div > div > div:nth-child(2) > div > p:nth-child(2)"))
                        .Text);
            }

            [TestMethod]
            public void SearchByBeerNameTest()
            {
                _Driver.Navigate().GoToUrl(_BaseUrl);
                WaitDataFromApi();

                var searchingBeerName = "American";
                _Driver.FindElement(By.Id("searchInput")).SendKeys(searchingBeerName);
                _Driver.FindElement(By.Id("searchBtn")).Click();
                var targetText = _Driver.FindElement(By.CssSelector("#app > div > div > div:nth-child(2) > h5")).Text;
                var actualResult = targetText.Contains(searchingBeerName);
                Assert.AreEqual(true, actualResult);
            }

            [TestInitialize]
            public void SetupTest()
            {
                _Driver = new ChromeDriver();
                _BaseUrl = "http://beerchallenge.localdev.net/";
            }

            private void WaitDataFromApi()
            {
                Thread.Sleep(700);
            }
        }
    }
}