using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Assessment
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\SeleniumJars");

            //To open website we used driver.url
            driver.Manage().Window.Maximize();
            string url = "http://www.youcandealwithit.com/";
            driver.Url = url;
            Thread.Sleep(2000);
            
            //all assigned values to the variable
            String BorrowersPath = "//*[@id='siteNav']/li[1]/a";
            String foodpath = "/html/body/div[2]/div[2]/div/div[2]/div[1]/input";
            String clothingpath = "/html/body/div[2]/div[2]/div/div[2]/div[2]/input";
            String shelterpath = "/html/body/div[2]/div[2]/div/div[2]/div[3]/input";
            String monthlypaypath = "//*[@id='monthlyPay']";
            String monthlyotherspath = "//*[@id='monthlyOther']";
            String monthlyexpenses = "//*[@id='totalMonthlyExpenses']";
            String monthlyincome = "//*[@id='totalMonthlyIncome']";
            String foodvalue = "2000";
            String clothingvalue = "3000";
            String sheltervalue = "4000";
            String monthlyPayvalue = "5000";
            String foomonthlyOtherdvalue = "6000";
            String linktext1 = "Calculators & Resources";
            String linktext1check;
            String linktext2 = "Calculators";
            String linktext2check;
            String linktext3 = "Budget Calculator";
            String linktext3check;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement target = driver.FindElement(By.XPath(BorrowersPath));
            Actions action = new Actions(driver);
            Thread.Sleep(3000);
            action.MoveToElement(target).Build().Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.LinkText(linktext1)).Click();
            //This stores title.
            linktext1check = driver.Title;
            //Validation.
            if (linktext1check.Contains(linktext1))
            {
                Console.WriteLine("Link Text and Title are same for " + linktext1);
            }
            else
            {
                Console.WriteLine("Link Text and Title are not same for " + linktext1);
            }
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText(linktext2)).Click();
            linktext2check = driver.Title;
            if (linktext2check.Contains(linktext2))
            {
                Console.WriteLine("Link Text and Title are same for " + linktext2);
            }
            else
            {
                Console.WriteLine("Link Text and Title are not same for " + linktext2);
            }
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText(linktext3)).Click();
            linktext3check = driver.Title;
            if (linktext3check.Contains(linktext3))
            {
                Console.WriteLine("Link Text and Title are same for " + linktext3);
            }
            else
            {
                Console.WriteLine("Link Text and Title are not same for " + linktext3);
            }
            Thread.Sleep(3000);

            driver.FindElement(By.LinkText(linktext3)).Click();
            linktext3check = driver.Title;
            if (linktext3check.Contains(linktext3))
            {
                Console.WriteLine("Link Text and Title are same for " + linktext3);
            }
            else
            {
                Console.WriteLine("Link Text and Title are not same for " + linktext3);
            }
            Thread.Sleep(3000);

            //Here we enter the value in the respective boxes
            driver.FindElement(By.XPath(foodpath)).SendKeys(foodvalue);
            driver.FindElement(By.XPath(clothingpath)).SendKeys(clothingvalue);
            driver.FindElement(By.XPath(shelterpath)).SendKeys(sheltervalue);
            driver.FindElement(By.XPath(monthlypaypath)).SendKeys(monthlyPayvalue);
            driver.FindElement(By.XPath(monthlyotherspath)).SendKeys(foomonthlyOtherdvalue);
            Thread.Sleep(3000);

            //to print the over/under budget
            double monthexp = double.Parse(driver.FindElement(By.XPath(monthlyexpenses)).GetAttribute("value"));
            Console.WriteLine(monthexp);
            Thread.Sleep(3000);
            double monthpay = double.Parse(driver.FindElement(By.XPath(monthlyincome)).GetAttribute("value"));
            Console.WriteLine(monthpay);
            Thread.Sleep(3000);

            if (monthexp <= monthpay)
            {
                Console.WriteLine("You are Warren Buffet");
            }
            else
            {
                Console.WriteLine("You are an VM");
            }

            //This closes the browser.
            driver.Close();

        }
    }
}
