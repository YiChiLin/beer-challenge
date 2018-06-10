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
            private string baseURL;
            private IWebDriver driver;

            [TestMethod]
            public void GetOrganicBeerTest()
            {
                driver.Navigate().GoToUrl(baseURL);
                WaitDataFromApi();
                driver.FindElement(By.Id("organicBtn")).Click();
                Assert.AreEqual("IsOrganic: Yes",
                    driver.FindElement(By.CssSelector("#app > div > div > div:nth-child(2) > div > p:nth-child(2)"))
                        .Text);
            }

            [TestMethod]
            public void SearchByBeerNameTest()
            {
                driver.Navigate().GoToUrl(baseURL);
                WaitDataFromApi();

                var searchingBeerName = "American";
                driver.FindElement(By.Id("searchInput")).SendKeys(searchingBeerName);
                driver.FindElement(By.Id("searchBtn")).Click();
                var targetText = driver.FindElement(By.CssSelector("#app > div > div > div:nth-child(2) > h5")).Text;
                var actualResult = targetText.Contains(searchingBeerName);
                Assert.AreEqual(true, actualResult);
            }

            [TestInitialize]
            public void SetupTest()
            {
                driver = new ChromeDriver();
                baseURL = "http://beerchallenge.localdev.net/";
            }

            private void WaitDataFromApi()
            {
                Thread.Sleep(700);
            }
        }
    }
}