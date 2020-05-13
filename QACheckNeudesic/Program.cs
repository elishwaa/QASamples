using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace QACheckNeudesic
{
    [TestFixture]
    public class Program
    {
        public string neudesicwebsiteURL;
        public string myshopUrl;
        public excel.Range xRange;

        [SetUp]
        public void setUp()
        {
            excel.Application xApplication = new excel.Application();
            excel.Workbook xWorkBook = xApplication.Workbooks.Open(@"C:\Users\Administrator\Desktop\url.xlsx");
            excel._Worksheet xWorkSheet = xWorkBook.Sheets[1];
            xRange = xWorkSheet.UsedRange;
        }

        [Test]
        public void TestCommonMethod()
        {
            CommonFunction commonFunction = new CommonFunction();
          
            neudesicwebsiteURL = xRange.Cells[1][1].value;

            commonFunction.LoadBrowser(neudesicwebsiteURL);
        }

        [Test]
        public void TestMyShop()
        {
            MYSHOPFunctions myShopFunctions = new MYSHOPFunctions();

            myshopUrl = xRange.Cells[2][1].value;

            myShopFunctions.LoadMYSHOPApplication(myshopUrl);
        }













        //[SetUp]
        //public void Initialize()
        //{
        //    driver.Manage().Window.Maximize();
        //    excel.Application xApplication = new excel.Application();
        //    excel.Workbook xWorkBook = xApplication.Workbooks.Open(@"C:\Users\Administrator\Desktop\url.xlsx");
        //    excel._Worksheet xWorkSheet = xWorkBook.Sheets[1];
        //    excel.Range xRange = xWorkSheet.UsedRange;
        //    string websiteURL = xRange.Cells[1][1].value;

        //    driver.Navigate().GoToUrl(websiteURL);

        //}

        //[Test]
        //public void Execute()
        //{
        //    IWebElement anchorTagElement = driver.FindElement(By.XPath("/html/body/div[1]/header/div/a/div"));

        //    //IWebElement divElement = anchorTagElement.FindElement(By.CssSelector("div[class='neu-header-cta fl-button']"));

        //    anchorTagElement.Click();

        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        //    IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/article/div/div/div[1]/div/div/div/div[3]/div/div[1]/div/h2/span"));

        //    Assert.IsNotNull(element.Text);


        //}

        //[TearDown]
        //public void CleanUp()
        //{
        //    driver.Close();
        //}
    }
}
