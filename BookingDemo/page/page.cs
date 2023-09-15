using OpenQA.Selenium;

namespace SpecFlowTutorial.Pages
{
    public class Page
    {
        public IWebDriver WebDriver { get; }
        public Page(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

      // public IWebElement clkCross => WebDriver.FindElement(By.XPath("/html/body/div[17]/div/div/div/div[1]/div[1]/div/button"));
        public IWebElement WhereAre => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/div/div/form/div/span/input"));
        public IWebElement SltWhereAre => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/div/div/form/div[2]/ul/li[2]/div/div"));

        public IWebElement CheckIn => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/div/fieldset/button[1]/span/span[2]/span[2]"));

        public IWebElement CheckInDate => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/div[2]/div/div/div/div[2]/div/div[1]/div[2]/button[26]"));

        public IWebElement CheckOut => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/div[1]/fieldset/button[2]/span/span/span[2]"));

        public IWebElement CheckOutDate => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/div[2]/div/div/div/div[2]/div/div[1]/div[2]/button[28]"));

        public IWebElement SearchClick => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/section/div[2]/div[4]/div/button"));

        public IWebDriver webDriver { get; }
/*
        public void ClkCross()
        {
            clkCross.Click();
        }*/

        public void WhereAreYouGoing(String text)
        {
            WhereAre.Click();
            WhereAre.SendKeys(text);
        }
        public void SltwhereAre()
        {
            SltWhereAre.Click();
        }

        public void ClkCheckIn()
        {
            CheckIn.Click();
        }
        public void EtrCheckIndate()
        {
            CheckInDate.Click();
        }

        public void ClkCheckOut()
        {
            CheckOut.Click();
        }

        public void EtrCheckOutDate()
        {
            CheckOutDate.Click();
        }
        public void ClkSearch()
        {
            SearchClick.Click();
        }
    }
}