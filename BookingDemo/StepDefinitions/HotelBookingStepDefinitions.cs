using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowTutorial.Pages;
using System;
using TechTalk.SpecFlow;

namespace BookingDemo.StepDefinitions
{
    [Binding]
    public class HotelBookingStepDefinitions
    {

        Page Page;
        [Given(@"the user is on the hotel booking website")]
        public void Giventheuserisonthehotelbookingwebsite()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://trivago.in/");
            Page = new Page(webDriver);
        }
        [When(@"the user enter the where are you going")] 
        public void Whentheuserenterthewhereareyougoing()
        {
            Thread.Sleep(2000);
            Page.WhereAreYouGoing("Goa");
            Thread.Sleep(2000);
            Page.SltwhereAre();
           // throw new PendingStepException();
        }
        [When(@"the user selects a check-in date")]
        public void Whentheuserselectsacheck_indate()
        {
            Thread.Sleep(2000);
            //Page.ClkCheckIn();
            Thread.Sleep(4000);
            Page.EtrCheckIndate();
            //throw new PendingStepException();
        }
        [When(@"the user selects a check-out date")]
        public void Whenthuserselectsacheck_outdate()
        {
            Thread.Sleep(2000);
           // Page.ClkCheckOut();
            Thread.Sleep(2000);
            Page.EtrCheckOutDate();
           // throw new PendingStepException();
        }
        [When(@"the user clicks on the search button")]
        public void Whentheuserclicksonthesearchbutton()
        {
            Thread.Sleep(2000);
            Page.ClkSearch();
            Thread.Sleep(2000);
           // throw new PendingStepException();
        }
        [AfterScenario]
        public void AfterScenario()
        {
          //  Page.WebDriver.Quit();
        }
    }
 } 
