using System;
using OpenQA.Selenium;

namespace OnlineRacingBet.Common
{
    public class SeleniumWrapper
    {


        public static void FilltextBox(IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        public static Boolean IsElementDisplayed(IWebElement element)

        {
            return (element.Displayed && element.Enabled);

        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();

        }
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");

        }


    }
}

