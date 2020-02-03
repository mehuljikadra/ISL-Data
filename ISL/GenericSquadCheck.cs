using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace ISL
{


    class Squadsdetail
    {

        public string PlayerName { get; set; }

        public string JersyNo { get; set; }
    }
    class Urllist
    {
        public string URL { get; set; }
    }

    class GenericSquadCheck
    {
        public IWebDriver driver { get; private set; }
        public string BrowserDataFilePath { get; private set; }

        //private string SrcDataFilePath;


        public GenericSquadCheck(IWebDriver driver)
        {
            this.driver = driver;
            this.BrowserDataFilePath = BrowserDataFilePath;
            //this.SrcDataFilePath = SrcDataFilePath;
        }
        public void GetGenericSquadCheckData()
        {


            var Urllist = new List<Urllist>();

            var Squadsdetail = new List<Squadsdetail>();
            Thread.Sleep(2000);

            var allDivs = driver.FindElements(By.CssSelector(".si-team-info"));

            foreach (var div in allDivs)
            {


                var url = div.GetAttribute("href");


                Urllist.Add(new Urllist { URL = url });
                TestContext.Out.WriteLine($"URL: { url } ");

            }
            Urllist.Reverse();

            foreach (var p in Urllist.Skip(1))
            {
                var link = p.URL.ToString();
                driver.Navigate().GoToUrl(link);
                Thread.Sleep(3000);

               //var error = driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div/div[1]/span")).Text;
               
                  if(IsElementPresent(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div/div[1]/span")))
                {
                    Console.WriteLine(link);
                }

               
            }


        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
