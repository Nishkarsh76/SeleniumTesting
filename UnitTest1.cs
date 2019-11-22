using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\SeleniumJars");
            driver.Manage().Window.Maximize();
            string url = "https://www.google.com/";
            driver.Url = url;
            Thread.Sleep(2000);
            String searchtxt = "DXC Technologies";
            String txtbox = "q";
            String sbuttn = "gNO89b";
            String searchresults = "resultStats";
            driver.FindElement(By.Name(txtbox)).SendKeys(searchtxt);
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName(sbuttn)).Click();
            Thread.Sleep(2000);
            Console.WriteLine(driver.Title.ToString());
            Console.WriteLine(driver.FindElement(By.Id(searchresults)).Text);
            String Page_Title = driver.Title.ToString();
            if (Page_Title.Contains(searchtxt))
            {
                Console.WriteLine("Test Case Passed");
            }
            else
            {
                Console.WriteLine("Test Case Failed");
            }
            driver.Close();
        }
    }
}
