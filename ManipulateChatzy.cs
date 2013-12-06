using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;
using System.Web;
using OpenQA.Selenium;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace Chatzy
{
    class ManipulateChatzy
    {

        public void Manipulate()
        {
            ChromeDriver driver = new ChromeDriver();
            HelpFunctions H = new HelpFunctions();

             H.Navigate("http://us14.chatzy.com/37785015405504", driver);
            H.Navigate("http://us14.chatzy.com", driver);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 100));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement element = null;
               //= wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("X967")));
          
            H.Button("//*[@id='X313']", driver);//Login/SignUp
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='X603']")));

            H.InputInfo("//*[@id='X603']", "amber.m.james@gmail.com", driver);//add email
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

            H.Button("//*[@id='X6001']", driver); // choose the "I am regitered user" 
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

            H.InputInfo("//*[@id='X604']", "Amber001", driver); //Enter in the password
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

            H.Button("//*[@id='X593']", driver); //click the ok button 


            element = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("X967")));
            H.Navigate("http://us14.chatzy.com/37785015405504", driver);

            H.Button("//*[@id='X593']", driver); //click the enter room button 
            H.Button("//*[@id='X1049']", driver);

         


            var chat = driver.FindElementById("X184");
           // System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> chat = driver.FindElementsByClassName("a");
           // chat.ToString();
            
            List<string> Temp = new List<string>();
            Temp.Add(chat.Text);
            System.IO.File.AppendAllLines(@"OUTPUT3.txt", Temp);
            string[] t = System.IO.File.ReadAllLines(@"OUTPUT3.txt");
            t.ToList();

         //   string s = chat.Text;
        //    string[] words = Regex.Split(s, "\r\n"); 
            driver.Close();
         
        }
    }
}
