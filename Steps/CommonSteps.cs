using System;
using OnlineRacingBet.Common;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace OnlineRacingBet.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        [Given(@"i have opened a Chrome browser")]
        public void GivenIHaveOpenedChromeBrowser()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\fukha\Desktop\chromedriver_win32");

        }
        [Given(@"i have opened a FireFox browser")]
        public void GivenIHaveOpenedFFBrowser()
        {
            PropertiesCollection.driver = new FirefoxDriver();

        }
        [Given(@"i am on williamHill betting website")]
        public void GivenIAmOnWilliamHillBettingWebsite()
        {
            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl("https://www.williamhill.com.au");
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                throw e;

            }


        }
    }
}
