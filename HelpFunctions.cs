using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE; 

namespace Chatzy
{
    class HelpFunctions
    {
        public bool Wait() { return true;  }
        public void Navigate(string path, ChromeDriver driver)
        {
            driver.Navigate().GoToUrl(path);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 100));

        }
        public void Button(string path, ChromeDriver driver)
        {
            var button = driver.FindElementByXPath(path);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            button.Click();

        }

        public void ButtonByName(string path, ChromeDriver driver)
        {
            var button = driver.FindElementByName(path);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            button.Click();

        }

        public void InputInfo(string path, string information, ChromeDriver driver)
        {
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            var Input = driver.FindElementByXPath(path);
            Input.SendKeys(information);

        } 
    }
}
