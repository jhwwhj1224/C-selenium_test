using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace selenium_test
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://stockx.com/air-jordan-1-retro-high-black-hyper-pink-2-gs");

            String title = driver.Title;

            Console.WriteLine(title);
        }
    }
}
