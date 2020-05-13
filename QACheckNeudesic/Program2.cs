//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using excel = Microsoft.Office.Interop.Excel;

//namespace QACheckNeudesic
//{
//    class Program2
//    {
//        public string myshopUrl;
//        [Test]
//        public void TestMyShop()
//        {
//            MYSHOPFunctions myShopFunctions = new MYSHOPFunctions();

//            excel.Application xApplication = new excel.Application();
//            excel.Workbook xWorkBook = xApplication.Workbooks.Open(@"C:\Users\Administrator\Desktop\url.xlsx");
//            excel._Worksheet xWorkSheet = xWorkBook.Sheets[1];
//            excel.Range xRange = xWorkSheet.UsedRange;
//            myshopUrl = xRange.Cells[2][1].value;

//            myShopFunctions.LoadMYSHOPApplication(myshopUrl);
//        }

//    }
//}
