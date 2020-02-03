using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using SeleniumExtras.WaitHelpers;

namespace ISL
{
    [TestClass]
    public class UnitTest1
    {
            IWebDriver driver = new ChromeDriver();
       

       [TestMethod]
       
        private void clubstats()
        {
            //driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]")).Click();


            var clubstat = driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]"));
            var action1 = new OpenQA.Selenium.Interactions.Actions(driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
            action1.MoveToElement(clubstat);
            action1.Perform();
            clubstat = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                       .Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]")));
            clubstat.Click();
        }
        
       
        [TestMethod]
        public void Squadcheck()
        {
            driver.Navigate().GoToUrl("https://www.indiansuperleague.com/clubs");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

           
            //Cookies Gotit button
            GotITButton();
            Thread.Sleep(2000);

            //Team Profile tab
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div[1]/div/div/div[2]/div/div[4]/a")).Click();
            //Squad tab
            SquadTab();

            GenericSquadCheck _ATKsquad = new GenericSquadCheck(driver);
            _ATKsquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Teamselection
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[2]/a/div/img")).Click();
            Thread.Sleep(2000);

            //BengluruTeam
            SquadTab();
            GenericSquadCheck _BengaluruSquad = new GenericSquadCheck(driver);
            _BengaluruSquad.GetGenericSquadCheckData();

            TeamsLogo();
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[3]/a/div/img")).Click();
            Thread.Sleep(2000);

            //ChennayianTeam
            SquadTab();
            GenericSquadCheck _Chennaisquad = new GenericSquadCheck(driver);
            _Chennaisquad.GetGenericSquadCheckData();

            TeamsLogo();
            //FCGoa
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[4]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Goasquad = new GenericSquadCheck(driver);
            _Goasquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Hydrabad FC
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[5]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Hydrabadsquad = new GenericSquadCheck(driver);
            _Hydrabadsquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Jamshedpur FC
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[6]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Jamshedpursquad = new GenericSquadCheck(driver);
            _Jamshedpursquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Kerala FC
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[7]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Keralasquad = new GenericSquadCheck(driver);
            _Keralasquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Mumbai FC
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[8]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Mumbaisquad = new GenericSquadCheck(driver);
            _Mumbaisquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Northeast FC
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[9]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Northeastsquad = new GenericSquadCheck(driver);
            _Northeastsquad.GetGenericSquadCheckData();

            TeamsLogo();
            //Odisha FC
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[1]/div/div/div[1]/div/div/div[10]/a/div/img")).Click();
            Thread.Sleep(2000);
            SquadTab();

            GenericSquadCheck _Odhishasquad = new GenericSquadCheck(driver);
            _Odhishasquad.GetGenericSquadCheckData();

        }

        [TestMethod]
        public void Searchplayers()
        {
            driver.Navigate().GoToUrl("https://www.indiansuperleague.com/");

            driver.Manage().Window.Maximize();

            string ReadExcel;
            int rctn = 6;

            excel.Application x1app = new excel.Application();
            excel.Workbook x1workbook = x1app.Workbooks.Open(@"D:\Automation\ISL\Player search file\player_data1.xlsx");
            excel.Worksheet x1worksheet = x1workbook.Sheets[1];


            excel.Range x1range = x1worksheet.UsedRange;



            for (int i = 6; i <= rctn; i++)
            {

                for (int j = 2; j <= 78; j++)
                {

                    ReadExcel = x1range.Cells[i][j].Text.ToString();
                    driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div[3]/div/div[2]/div[1]/ul/li[5]/a")).Click();

                    var search = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/input"));
                    search.SendKeys(ReadExcel);
                    search.SendKeys(Keys.Enter);

                    var visible = driver.FindElement(By.XPath("//*[@id='cookiebtn']"));

                    if (visible.Displayed)
                    {
                        //Assert.AreEqual(true, visible.Displayed);
                        visible.Click();
                    }
                    var record = driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div/div/div[2]/div[2]/span")).Text;
                    if (record.StartsWith("0 records for"))
                    {
                        Console.WriteLine(ReadExcel, "player is deleted");
                    }

                    /* FunctionalLibrary.TryFindElement(driver, "//*[@id='cookiebtn']" );

                         var visible =  IsElementVisible(element);
                         if (visible)
                         {
                         element.Click();
                         }*/


                    else if (IsElementPresent(By.Id("player-list")))
                    {
                        

                            var viewprofile = driver.FindElement(By.Id("player-list"));
                            var action1 = new OpenQA.Selenium.Interactions.Actions(driver);
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
                            action1.MoveToElement(viewprofile);
                            action1.Perform();
                            viewprofile = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                                       .Until(driver => driver.FindElement(By.Id("player-list")));

                            var playername = driver.FindElement(By.CssSelector(".article-name")).Text;

                            if (ReadExcel.Equals(playername))
                            {
                                Console.WriteLine(playername, "player name is correct");
                            }
                            else
                            {
                                Console.WriteLine(playername, "player name is incorrect");
                            }
                            var webe = driver.FindElement(By.Id("player-list"));


                            var href = webe.FindElement(By.CssSelector("a")).GetAttribute("href");



                            if (href == null)
                            {
                                Console.WriteLine(playername, "Player not clikable");



                            }
                            else
                            {
                                Debug.WriteLine(playername, "player is clikable");
                                webe.Click();
                                Thread.Sleep(1000);
                                var playerdetail = driver.FindElement(By.CssSelector(".si-player-name")).Text;
                                if (playername.Equals(playerdetail))
                                {
                                    Console.WriteLine(playername, "Redirected on detail page");
                                }
                                var error = driver.FindElement(By.CssSelector(".txt-1")).Text;
                                if (error.Equals("Oops!Page Not Found."))
                                {
                                    String currenturl = driver.Url;
                                    Console.WriteLine(currenturl, "404 page");
                                }
                            }



                    }
                  
                    
                  else
                   {
                        String currenturl = driver.Url;
                        Console.WriteLine(currenturl,"player profile isn't available");
                       
                   }

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


        
        private void Teamtracker()
        {
            var tracker = driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[7]/div/div/div/div/section/component/div[1]/h2"));
            var action1 = new OpenQA.Selenium.Interactions.Actions(driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
            action1.MoveToElement(tracker);
            action1.Perform();
            tracker = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                       .Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[7]/div/div/div/div/section/component/div[1]/h2")));
        }
        private void SquadTab()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section[1]/div/div/div/div/section/component[2]/div/component/ul/li[2]/a")).Click();
        }
        private void TeamsLogo()
        {
            var Logo = driver.FindElement(By.CssSelector(".teams-logo"));
            var action1 = new OpenQA.Selenium.Interactions.Actions(driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
            action1.MoveToElement(Logo);
            action1.Perform();
            Logo = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                       .Until(driver => driver.FindElement(By.CssSelector(".teams-logo")));
        }
        private void Seasondropdown()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[2]/div/div[2]/div[1]")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[2]/div/div[2]/div[2]/ul/li[2]")).Click();
        }
        private void GotITButton()
        {
            //Cookies Gotit button
            driver.FindElement(By.CssSelector(".action-btn")).Click();
        }
      
            
        
        private void LoadMoreButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            var button = wait.Until(driver => driver.FindElement(By.CssSelector(".si-stats-more-btn")));

            while (button.GetCssValue("display") != "none")
            {
                var action = new OpenQA.Selenium.Interactions.Actions(driver);
                action.MoveToElement(button);
                action.Perform();
                button.Click();
                button = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                            .Until(driver => driver.FindElement(By.CssSelector(".si-stats-more-btn")));
            }
        }
        private void Statsdropdown()
        {
            var DropDown = driver.FindElement(By.CssSelector(".si-stats-dropdown-container"));
            var action1 = new OpenQA.Selenium.Interactions.Actions(driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
            action1.MoveToElement(DropDown);
            action1.Perform();
            DropDown = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                       .Until(driver => driver.FindElement(By.CssSelector(".si-stats-dropdown-container")));
            DropDown.Click();
        }
        private void Statsdropdownscroll()
        {
            var DropDown = driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[2]/ul/li[13]"));
            var action1 = new OpenQA.Selenium.Interactions.Actions(driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
            action1.MoveToElement(DropDown);
            action1.Perform();
            DropDown = new WebDriverWait(driver, new TimeSpan(0, 1, 0))
                       .Until(driver => driver.FindElement(By.XPath("/html/body/div[1]/section/myapp/section/div/div/div/div/section/component/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[2]/ul/li[13]")));
        }
       
        
       

    }
}
