// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

class mouseMove
{
    IWebDriver driver;
    void launch()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://www.facebook.com/");
        //driver.Navigate().GoToUrl("https://www.amazon.in/");
        Thread.Sleep(2000);
    }
    
    
    
    
    void MM()
    {
        Actions action = new Actions(driver);
        //IWebElement ele1 = driver.FindElement(By.XPath("//span[text()='Hello, sign in']"));
        //IWebElement ele2 = driver.FindElement(By.XPath("//span[text()='Your Orders']"));

        //action.MoveToElement(ele1).MoveToElement(ele2).Click().Build().Perform();

        //This is added line

        IWebElement Email =  driver.FindElement(By.Id("email"));
        Email.SendKeys("testuser");
        IWebElement pass = driver.FindElement(By.Id("pass"));
        IWebElement login = driver.FindElement(By.Name("login"));

        action.Click(Email).KeyDown(Keys.Control).SendKeys("a")
            .SendKeys("c")
       
         .KeyUp(Keys.Control)
         .Click(pass)
         .KeyDown(Keys.Control)
            .SendKeys("v")
            .KeyUp(Keys.Control)
            .Click(login)
            .Build()
            .Perform();



        






    }










    public static void Main(string[] args)
    {
        mouseMove obj = new mouseMove();
        obj.launch();
        obj.MM();
    }
}



