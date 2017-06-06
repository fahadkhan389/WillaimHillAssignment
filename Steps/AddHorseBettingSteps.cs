using System;
using OnlineRacingBet.Common;
using TechTalk.SpecFlow;
using OnlineRacingBet.Pages;

namespace OnlineRacingBet.Steps
{
    [Binding]
    public class AddHorseBettingSteps
    {

        [Given(@"I clicked Racing section")]
        public void GivenIClickedRacingSection()
        {
            try
            {

                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.ClickRacingLink();
            }
            catch (Exception e)
            {
                throw e;


            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }
        }

        [Given(@"I selected Next to Jump Section")]
        public void GivenISelectedNextToJumpSection()
        {
            try
            {
                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.ClickNextToJumpLink();
            }
            catch (Exception e)
            {
                throw e;

            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }

        }

        [Given(@"i selected fifth race from the list")]
        public void GivenISelectedFirstRace()
        {
            try
            {
                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.ClickRace();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }

        }

        [Given(@"i selected first competitor for winning and enter stake ""(.*)""")]
        public void GivenISelectedFirstHorseForWinningAndEnterStake(string Stake)
        {
            try
            {
                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.ClickBetAndEnterStake(Stake);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }

        }
        [When(@"I clicked on Add to Bet Slip")]
        public void WhenIClickedOnAddToBetSlip()
        {
            try
            {
                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.ClickAddtoBetSlip();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }

        }

        [When(@"I clicked Bet Slip")]
        public void WhenIClickedBetSlip()
        {
            try
            {
                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.ClickBetSlip();
            }

            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }
        }


        [Then(@"Bet should be added in BetSlip section of stake ""(.*)""")]
        public void ThenBetShouldBeAddedInBetSlipSectionOfStake(string stake)
        {
            try
            {
                RacingPage MyRacingpage = new RacingPage();
                MyRacingpage.AssertBetAdded(stake);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();

            }
        }

    }
}
