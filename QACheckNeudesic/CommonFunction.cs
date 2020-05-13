using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace QACheckNeudesic
{
    public class CommonFunction
    {
        IWebDriver driver = new ChromeDriver();

       
        
        public void LoadBrowser(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            //Assert.AreEqual("https://www.neudesic.com/", url);
        }





        //[Test]
        //public void Test()
        //{
        //    IWebElement titleElement = driver.FindElement(By.XPath(" / html / body / div[1] / header / div / div[1] / a / img"));
        //    string logotext = titleElement.Text;
        //    Assert.AreEqual("Neudesic Logo", logotext);

        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Close();
        //}

    }
}
