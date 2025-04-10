using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CloudQAAutomationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            try
            {
                var firstNameField = driver.FindElement(By.Id("fname"));
                firstNameField.SendKeys("Chirag");
                var maleRadio = driver.FindElement(By.Id("male"));
                maleRadio.Click();
                var cricketCheckbox = driver.FindElement(By.Id("Cricket"));
                cricketCheckbox.Click();
                Thread.Sleep(3000);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Test failed: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
