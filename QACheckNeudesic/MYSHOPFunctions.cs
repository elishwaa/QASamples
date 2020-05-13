using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACheckNeudesic
{
    public class MYSHOPFunctions 
    {

        IWebDriver driver = new ChromeDriver();


        public void LoadMYSHOPApplication(string url)
        {
           
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            //ImplicitWaitForElement(driver);

            ExplicitWaitForElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div[1]/a"), 5);

            IWebElement titleElement = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div[1]/a"));
           
            string actualApptitle = titleElement.Text;

            string requiredAppTitle = "MY SHOP";
            Assert.AreEqual(requiredAppTitle, actualApptitle);
            Console.WriteLine(actualApptitle);
        }

        public IWebElement ExplicitWaitForElement(By locator, int seconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists(locator));
        }

        public void ImplicitWaitForElement(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}
