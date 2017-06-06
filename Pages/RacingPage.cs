using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineRacingBet.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineRacingBet.Pages
{
    class RacingPage
    {
        public RacingPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='app']/div/div[2]/div/nav/div/div/div[2]/div[1]/div[1]/a[1]/span")]
        public IWebElement RacingLinkXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-reactid='106']")]
        public IWebElement NextToJumpLinkXpath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='app']/div/div[2]/div/nav/div/div/div[2]/div[1]/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div[2]/a[5]/div[2]/div/div[1]")]
        public IWebElement SelectRaceXpath { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='app']/div/div[4]/div/div/div[1]/div[1]/div/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[7]/div/button")]
        public IWebElement SelectBetXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Stake']")]
        public IWebElement StaketxtXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-redesign-ga='QuickBet/Click/AddToBetslip']")]
        public IWebElement AddtoBetSlipXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-reactid='928']")]
        public IWebElement BetSlipLinkXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='CurrencyBox_currencyBox_b0O CurrencyBox_withSymbol_3qx'][@placeholder='Stake']")]
        public IWebElement StakeValueXpath { get; set; }


        public void ClickRacingLink()
        {
            SeleniumWrapper.ClickElement(RacingLinkXpath);
            Thread.Sleep(3000);

        }
        public void ClickNextToJumpLink()
        {
            SeleniumWrapper.ClickElement(NextToJumpLinkXpath);
            Thread.Sleep(3000);

        }
        public void ClickRace()
        {
            SeleniumWrapper.ClickElement(SelectRaceXpath);
            Thread.Sleep(3000);

        }

        public void ClickBetAndEnterStake(string stake)
        {
            SeleniumWrapper.ClickElement(SelectBetXpath);
            Thread.Sleep(3000);
            SeleniumWrapper.FilltextBox(StaketxtXpath, stake);
            Thread.Sleep(5000);


        }
        public void ClickAddtoBetSlip()
        {
            SeleniumWrapper.ClickElement(AddtoBetSlipXpath);
            Thread.Sleep(5000);

        }
        public void ClickBetSlip()
        {
            SeleniumWrapper.ClickElement(BetSlipLinkXpath);
            Thread.Sleep(3000);

        }


        public void AssertBetAdded(string stake)
        {
            string text = SeleniumWrapper.GetText(StakeValueXpath);
            Thread.Sleep(3000);
            Assert.IsTrue(string.Equals(text, stake, StringComparison.InvariantCultureIgnoreCase), "Not Equal");
            Thread.Sleep(3000);

        }




    }
}
