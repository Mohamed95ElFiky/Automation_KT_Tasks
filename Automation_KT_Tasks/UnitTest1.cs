using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_KT_Tasks
{
    public class Tests
    {
        WebDriver driver;

        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://example.com");
            driver.Manage().Window.Maximize();
            // print URL
            Console.WriteLine("Page URL = " + driver.Url);
            // print Title
            string title = driver.Title;
            Console.WriteLine("Page Title = " + title);
            //IWebElement header = driver.FindElement(By.TagName("h1"));
            //Console.WriteLine("Header Text: " + header.Text);

            // Navigate to selenium.dev
            driver.Navigate().GoToUrl("https://www.selenium.dev");
            // Prevuios Page
            driver.Navigate().Back();
            // Forward Page
            driver.Navigate().Forward();
            //refresh
            driver.Navigate().Refresh();

            // print screen size
            Size windowSize = driver.Manage().Window.Size;
            Console.WriteLine("Window Height = " + windowSize.Height);
            Console.WriteLine("Window Width = " + windowSize.Width);

            // Position of window
            Point windowPosition = driver.Manage().Window.Position;
            Console.WriteLine("Window Position = X " + windowPosition.X);
            Console.WriteLine("Window Position = Y " + windowPosition.Y);
            System.Threading.Thread.Sleep(2000);

            // Edit Window Size
            windowSize.Height = 768;
            windowSize.Width = 1024;
            System.Threading.Thread.Sleep(2000);

            // Edit Window Position
            windowPosition.X = 200;
            windowPosition.Y = 150;
            driver.Manage().Window.Size = windowSize;
            System.Threading.Thread.Sleep(2000);
            // Position of window
            Console.WriteLine("Window Position = X " + windowPosition.X + " Y: " + windowPosition.Y);
            System.Threading.Thread.Sleep(2000);

            //window handle
            string wHandle = driver.CurrentWindowHandle;
            Console.WriteLine(wHandle);

            //src code 
            string pageSource = driver.PageSource;
            Console.WriteLine(pageSource);

            // Min then Max then Full screen
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();

            // Close current tab
            driver.Close();


            // Open example.com then close the app
            driver.Navigate().GoToUrl("https://example.com");
            driver.Quit();

            //Open Facebook and locate it's items
            driver.Navigate().GoToUrl("https://facebook.com");

            Assert.Pass();
        }
        [Test]
            public void Test2()
        {
            // Open a 'https://www.facebook.com/r.php?entry_point=login'   and locate fields by id, name, className, tagName, xpath, and cssSelector. Fill in test data.

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.udemy.com/join/passwordless-auth/?locale=en_US&next=https%3A%2F%2Fwww.udemy.com%2F&response_type=html&action=login&mode");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("Moahmed@gamil.com"); 
            
            driver.FindElement(By.XPath("//form[@data-purpose='code-generation-form']/button[@type='submit']")).Click();
            
        }
    }
}