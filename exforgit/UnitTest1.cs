using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace exforgit
{
    [TestFixture]

//test
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        [TestCase("https://www.google.com", "Google")]
        [TestCase("https://www.bing.com", "Bing")]
        [TestCase("https://www.yahoo.com", "Yahoo")]
        public void Test1(string url, string expectedTitle)
        {
            driver.Navigate().GoToUrl(url);
            string actualTitle = driver.Title;
            Assert.IsTrue(actualTitle.Contains(expectedTitle),
                $"❌ Title check failed! Expected '{expectedTitle}', but got '{actualTitle}'");



            
        }
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }


        }
    }
}
