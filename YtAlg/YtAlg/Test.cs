using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtAlg
{
    class Test
    {
        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
