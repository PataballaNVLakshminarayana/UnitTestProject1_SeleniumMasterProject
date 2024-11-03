using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1_SeleniumMasterProject
{
    [TestClass]
    public class SeleniumMasterProject
    {
        //[TestMethod]
        //public void Vedio_3()
        //{
        //    IWebDriver driver =new FirefoxDriver();
        //    driver.Url = "https://www.youtube.com/";
        //    Thread.Sleep(2000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_4()
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://www.nuget.org/";
        //    Console.WriteLine("the page title is :" + driver.Title);
        //    Thread.Sleep(2000);

        //    ////IWebDriver driver1 = new FirefoxDriver();
        //    driver.Url = "https://www.google.com/intl/en-US/gmail/about/";
        //    Console.WriteLine("the page source is :" + driver.PageSource);
        //    Thread.Sleep(2000);

        //    //IWebDriver driver2 = new FirefoxDriver();
        //    driver.Url = "https://www.youtube.com/";
        //    string geturl = driver.Url;
        //    Console.WriteLine("the page url is " +geturl);
        //    Thread.Sleep(2000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_5()
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://www.nuget.org/";
        //    driver.Manage().Window.FullScreen();
        //    Thread.Sleep(10000);
        //    driver.Manage().Window.Minimize();
        //    Thread.Sleep(10000);
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(10000);
        //    driver.Quit();

        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://www.youtube.com/";
        //    driver1.Manage().Window.Position = new Point(400, 200);//set the position
        //    Thread.Sleep(10000);
        //    Point points=driver1.Manage().Window.Position;//get the position
        //    Console.WriteLine("The position of the window is " + points);
        //    Thread.Sleep(10000);
        //    driver1.Quit();

        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://www.google.com/intl/en-US/gmail/about/";
        //    driver2.Manage().Window.Size = new Size(400, 200);//set the size for window
        //    Thread.Sleep(10000);
        //    Size sizeofwindow = driver2.Manage().Window.Size;//get the size for window
        //    Console.WriteLine("The size of the window is " + sizeofwindow);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_6()// Browser Navigation
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://www.google.com/intl/en-US/gmail/about/";
        //    driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ifkv=ARpgrqcBokPJZ4fJAiZjITsh7yN6CHLSsYfeZIfcgl-bZ0hjZ9i950_C1tORzhEGiqgx4tZfJquhaQ&rip=1&sacu=1&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S1210472756%3A1726679861671422&ddm=1");
        //    Thread.Sleep(10000);

        //    driver.Navigate().Back();
        //    Thread.Sleep(10000);

        //    driver.Navigate().Forward();
        //    Thread.Sleep(10000);

        //    driver.Navigate().Refresh();
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}

        //[TestMethod]
        //public void Vedio_7_ID()//Locators Id 
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfc4f9WZ1KrSW6-Vz3xGxyOfK5McjM8UEFtqA_8SJi1ezQiQa4rKvJ8aHftHl87ZDps56PQ8A&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-49304270%3A1726728552504484&ddm=0";
        //    driver.FindElement(By.Id("identifierId")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_7_Name()//Locators Name
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf1mfE2aPypI7m_N8kGWaEqTooeMRxwK-SWQeb_6ITmYXz3jb9pgUMxqKzY60vp7KhxmzzMFw&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S1796465978%3A1726741325674567&ddm=0";
        //    driver1.FindElement(By.Name("identifier")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_7_ClassName()//Locators ClassName
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqc7DGXfsR9u08-nHgQjpgKAPA3gvUhVXQ2AsO-5VTXxljYUVEvHCHQ5-Qv3UKllHLbmNpjrfQ&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1775323210%3A1726741940506390&ddm=0";
        //    string str=driver2.FindElement(By.ClassName("Xb9hP")).Text;
        //    Console.WriteLine("The Class name is : " + str);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        //[TestMethod]
        //public void Vedio_7_TagName()//Locators TagName
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqc7DGXfsR9u08-nHgQjpgKAPA3gvUhVXQ2AsO-5VTXxljYUVEvHCHQ5-Qv3UKllHLbmNpjrfQ&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1775323210%3A1726741940506390&ddm=0";
        //    var countoftagnames=driver3.FindElements(By.TagName("button"));
        //    Console.WriteLine("The count of total tags are :" + countoftagnames);
        //    foreach(var cls in countoftagnames)
        //    {
        //        Console.WriteLine(cls.Text);
        //    }

        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_7_LinkText()//Locators LinkText
        //{
        //    IWebDriver driver4 = new FirefoxDriver();
        //    driver4.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqc7DGXfsR9u08-nHgQjpgKAPA3gvUhVXQ2AsO-5VTXxljYUVEvHCHQ5-Qv3UKllHLbmNpjrfQ&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1775323210%3A1726741940506390&ddm=0";
        //    driver4.FindElement(By.LinkText("Learn more about using Guest mode")).Click();
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod]
        //public void Vedio_7_PartialLinkText()//Locators PartialLinkText
        //{
        //    IWebDriver driver5 = new FirefoxDriver();
        //    driver5.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqc7DGXfsR9u08-nHgQjpgKAPA3gvUhVXQ2AsO-5VTXxljYUVEvHCHQ5-Qv3UKllHLbmNpjrfQ&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1775323210%3A1726741940506390&ddm=0";
        //    driver5.FindElement(By.PartialLinkText("Learn more")).Click();
        //    Thread.Sleep(10000);
        //    driver5.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Star()// * CSS Selectors
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf8tL1TfPTww5nWEP0WekCrKTezYAZT9Pdk0fJ5I9aweFbQx6GkZcejkqbU-4ObqeEvgT9zZA&dsh=S1680736296%3A1726756352600870";
        //    int countof= driver.FindElements(By.CssSelector("*")).Count;
        //    Console.WriteLine("The total number of elements present above the CSS :" + countof);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Hash_ID()// # ID CSS Selectors
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf8tL1TfPTww5nWEP0WekCrKTezYAZT9Pdk0fJ5I9aweFbQx6GkZcejkqbU-4ObqeEvgT9zZA&dsh=S1680736296%3A1726756352600870";
        //    driver1.FindElement(By.CssSelector("#identifierId")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Class()// . Class name CSS Selectors
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf8tL1TfPTww5nWEP0WekCrKTezYAZT9Pdk0fJ5I9aweFbQx6GkZcejkqbU-4ObqeEvgT9zZA&dsh=S1680736296%3A1726756352600870";
        //    int totaldotselectors= driver2.FindElements(By.CssSelector(".dMNVAe")).Count;
        //    Console.WriteLine("The total DOT Css Selectors are : " + totaldotselectors);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_TagName()// Attribute (TagName) CSS Selectors
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf8tL1TfPTww5nWEP0WekCrKTezYAZT9Pdk0fJ5I9aweFbQx6GkZcejkqbU-4ObqeEvgT9zZA&dsh=S1680736296%3A1726756352600870";
        //    driver3.FindElement(By.CssSelector("input[name='identifier']")).SendKeys("lakshminarayana73.p@gmail.com");
        //    driver3.FindElement(By.CssSelector("Span[jsname = 'V67aGc']"));
        //    //Console.WriteLine("The total DOT Css Selectors are : " + totaldotselectors);
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Sub_String()// Sub_String CSS Selectors
        //{
        //    IWebDriver driver4 = new FirefoxDriver();
        //    driver4.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf8tL1TfPTww5nWEP0WekCrKTezYAZT9Pdk0fJ5I9aweFbQx6GkZcejkqbU-4ObqeEvgT9zZA&dsh=S1680736296%3A1726756352600870";
        //     int countofsubstring=driver4.FindElements(By.CssSelector("a[href^='https://support.google.com/']")).Count;
        //    Console.WriteLine("The total substrings in anchor tag in Css Selectors are : " + countofsubstring);
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Doller()//  CSS Selectors
        //{
        //    IWebDriver driver5 = new FirefoxDriver();
        //    driver5.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqf8tL1TfPTww5nWEP0WekCrKTezYAZT9Pdk0fJ5I9aweFbQx6GkZcejkqbU-4ObqeEvgT9zZA&dsh=S1680736296%3A1726756352600870";
        //    driver5.FindElement(By.CssSelector("input[id$='ierId']")).SendKeys("lakshminarayana73.p@gmail.com");
        //    //Console.WriteLine("The total substrings in anchor tag in Css Selectors are : " + countofsubstring);
        //    Thread.Sleep(10000);
        //    driver5.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Doller_ElementElement()// Element Element CSS Selector
        //{
        //    IWebDriver driver6 = new FirefoxDriver();
        //    driver6.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfXGuClhFp5gFj_EXpgDtHbJJmjQsbZsVwE0m8prazqmkITZVRbJZg2qG8vhvUSPQj4S4V7Vw&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S356271192%3A1727089229720306&ddm=0";
        //    string str6= driver6.FindElement(By.CssSelector("span div")).Text;
        //    Console.WriteLine("The Element Element CSS Selector is :" + str6);
        //    Thread.Sleep(10000);
        //    driver6.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Doller_ElementPluseElement()// Element+Element CSS Selector
        //{
        //    IWebDriver driver7 = new FirefoxDriver();
        //    driver7.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfXGuClhFp5gFj_EXpgDtHbJJmjQsbZsVwE0m8prazqmkITZVRbJZg2qG8vhvUSPQj4S4V7Vw&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S356271192%3A1727089229720306&ddm=0";
        //    string str7 = driver7.FindElement(By.CssSelector("div+span")).Text;
        //    int count7 = driver7.FindElements(By.CssSelector("div+span")).Count;
        //    Console.WriteLine("The Element pluse Element CSS Selector is :" + str7);
        //    Console.WriteLine("The totalnumber of Element pluse Element CSS Selector is :" + count7);
        //    Thread.Sleep(10000);
        //    driver7.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Doller_ElementAttribute()// ElementAttribute CSS Selector--need to discuss or check
        //{
        //    IWebDriver driver8 = new FirefoxDriver();
        //    driver8.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfXGuClhFp5gFj_EXpgDtHbJJmjQsbZsVwE0m8prazqmkITZVRbJZg2qG8vhvUSPQj4S4V7Vw&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S356271192%3A1727089229720306&ddm=0";
        //    string str8 = driver8.FindElement(By.CssSelector("input[type]")).Text;
        //    Console.WriteLine("The Element Attribute of CSS Selector is :" + str8);
        //    Thread.Sleep(10000);
        //    driver8.Quit();
        //}
        //[TestMethod]
        //public void Vedio_8_Doller_Checked()// Checked CSS Selector--need to discuss or check
        //{
        //    IWebDriver driver9 = new FirefoxDriver();
        //    driver9.Url = "https://zixmessagecenter.com/s/login?b=zmc";
        //    driver9.FindElement(By.Id("remembermecheckbox")).Click();
        //    bool checkedornot= driver9.FindElement(By.CssSelector("input[type=checkbox]:checked")).Selected;
        //    Console.WriteLine("The checked CSS Selector is :" + checkedornot);
        //    Thread.Sleep(10000);
        //    driver9.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_Absolute() // Absolute XPath
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqcCMNZzU4HzrBp4pBytwySDrzuRp5MmlqHHCHa8esE6f-Gamu1vjbreaziMWMB2yiF9lNQaig&dsh=S-1392495432%3A1727220409838493";
        //    string xpathtext = driver.FindElement(By.XPath("html/body/div[1]/div[1]/div[2]/c-wiz/div/div[1]/div/div/span")).Text;
        //    Console.WriteLine("The Absolute XPath is : " + xpathtext);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_Relative() // Relative XPath
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqcCMNZzU4HzrBp4pBytwySDrzuRp5MmlqHHCHa8esE6f-Gamu1vjbreaziMWMB2yiF9lNQaig&dsh=S-1392495432%3A1727220409838493";
        //    string relativexpathtext = driver1.FindElement(By.XPath(".//*")).Text;
        //    int totalelements = driver1.FindElements(By.XPath(".//*")).Count;
        //    Console.WriteLine("The total number of Elements in the DOM using Relative XPath is : " + totalelements);
        //    Console.WriteLine("The all the Elements in the DOM using Relative XPath is : " + relativexpathtext);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_TagName() // TagName XPath
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqcCMNZzU4HzrBp4pBytwySDrzuRp5MmlqHHCHa8esE6f-Gamu1vjbreaziMWMB2yiF9lNQaig&dsh=S-1392495432%3A1727220409838493";
        //    string tagnamexpath = driver2.FindElement(By.XPath(".//input")).Text;
        //    int totalelements = driver2.FindElements(By.XPath(".//input")).Count;
        //    Console.WriteLine("The total number of Elements in the DOM using TagName XPath is : " + totalelements);
        //    Console.WriteLine("The all the Elements in the DOM using TagName XPath is : " + tagnamexpath);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_Attribute() // Attribute XPath
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqcCMNZzU4HzrBp4pBytwySDrzuRp5MmlqHHCHa8esE6f-Gamu1vjbreaziMWMB2yiF9lNQaig&dsh=S-1392495432%3A1727220409838493";
        //    driver3.FindElement(By.XPath(".//input[@id='identifierId']")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_MultipulAttribute() // Multipul Attribute XPath
        //{
        //    IWebDriver driver4 = new FirefoxDriver();
        //    driver4.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqcCMNZzU4HzrBp4pBytwySDrzuRp5MmlqHHCHa8esE6f-Gamu1vjbreaziMWMB2yiF9lNQaig&dsh=S-1392495432%3A1727220409838493";
        //    driver4.FindElement(By.XPath(".//input[@id='identifierId'][@name='identifier']")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_And() //And XPath Locator
        //{
        //    IWebDriver driver5 = new FirefoxDriver();
        //    driver5.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfUqEkLPuBRyKFyRuLYUtF23v9iDjOEkbjjHdDGNERkPzfD4mif0G6RY_xzirM8sHTEEB8iqw&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1190641113%3A1727263670697245&ddm=0";
        //    driver5.FindElement(By.XPath(".//input[@id='identifierId' and @name='identifier']")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver5.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_Or() // Or XPath Locator
        //{
        //    IWebDriver driver6 = new FirefoxDriver();
        //    driver6.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfUqEkLPuBRyKFyRuLYUtF23v9iDjOEkbjjHdDGNERkPzfD4mif0G6RY_xzirM8sHTEEB8iqw&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1190641113%3A1727263670697245&ddm=0";
        //    driver6.FindElement(By.XPath(".//input[type='email' or @name='identifier']")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver6.Quit();
        //}
        //[TestMethod]
        //public void Vedio_9_XPathLocator_Index() // Index XPath Locator
        //{
        //    IWebDriver driver7 = new FirefoxDriver();
        //    driver7.Url = "https://zixmessagecenter.com/s/login?b=zmc";
        //    string indexxpath=driver7.FindElement(By.XPath("//form[1]/div[5]/div[3]/div[3]/label")).Text;
        //    Console.WriteLine("The index of XPath Locator in DOM is : " + indexxpath);
        //    Thread.Sleep(10000);
        //    driver7.Quit();
        //}
        //[TestMethod]
        //public void Vedio_10_Text() // Text XPath Locator functions
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqc5H-EdrkftP70VmwFNB-JGCXKLE4ki6Ju3lcRvMOsdslRx4JygEDW3lKbzxSHZiD_Jo8Rb&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S641422433%3A1727344431062768&ddm=0";
        //    string textxpathfunction=driver.FindElement(By.XPath(".//div[text()='Email or phone']")).Text;
        //    Console.WriteLine("The Text XPath function is : " + textxpathfunction);
        //    Thread.Sleep(10000);
        //    driver.Quit();

        //}
        //[TestMethod]
        //public void Vedio_10_Contains_usingtext() // Contains using text in XPath Locator functions 
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqdlxTKSb6ut7Bpk_BWd1O2GjmgH7RJ87VBwcuSAzfJxocgaZMwcABx81Bt35o9aAvbi6jJhHg&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-634241674%3A1727445733746008&ddm=1";
        //    driver2.FindElement(By.XPath(".//a[contains(text(),'Guest mode')]")).Click();
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}

        //[TestMethod]
        //public void Vedio_10_Contains_usingattributevalue() // Contains using Attribute value in XPath Locator functions 
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqdlxTKSb6ut7Bpk_BWd1O2GjmgH7RJ87VBwcuSAzfJxocgaZMwcABx81Bt35o9aAvbi6jJhHg&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-634241674%3A1727445733746008&ddm=1";
        //    driver3.FindElement(By.XPath(".//span[contains(@jsname,'Create account')]"));
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_10_StartsWith_usingtext() // Starts with using text XPath Locator functions --need to discuss or check
        //{
        //    IWebDriver driver4 = new FirefoxDriver();
        //    driver4.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqc5H-EdrkftP70VmwFNB-JGCXKLE4ki6Ju3lcRvMOsdslRx4JygEDW3lKbzxSHZiD_Jo8Rb&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S641422433%3A1727344431062768&ddm=0";
        //    driver4.FindElement(By.XPath(".//a[starts-with(text(),'Learn more')]")).Click();
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod]
        //public void Vedio_10_Normalize_Spaces() // Normalize XPath Functions
        //{
        //    IWebDriver driver5 = new FirefoxDriver();
        //    driver5.Url = "https://github.com/login";
        //    string normalizetext=driver5.FindElement(By.XPath(".//label[normalize-space(text()='Username or email addres')]")).Text;
        //    Console.WriteLine("The Normalize Space for the give text is : " + normalizetext);
        //    Thread.Sleep(10000);
        //    driver5.Quit();
        //}
        //[TestMethod]
        //public void Vedio_10_Last() // Last XPath Functions
        //{
        //    IWebDriver driver6 = new FirefoxDriver();
        //    driver6.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string lastxpathfun= driver6.FindElement(By.XPath(".//select[last(@id,'languageSelect']")).Text;
        //    Console.WriteLine("The Last value in the selected list is " + lastxpathfun);
        //    Thread.Sleep(10000);
        //    driver6.Quit();
        //}
        //[TestMethod]
        //public void Vedio_11_XPathAxis_ParentFilter() //XPath using Parent Filter
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqeR8EzttvIOBYpEVlv_2Z7g89BlTPcq7O2Os_Ka38NdtdqY9ksbyNPzbYVM-wednfK4Q_vEpQ&dsh=S554924116%3A1727815312489758";
        //    string partentfilter=driver.FindElement(By.XPath("//span/parent::h1")).Text;
        //    Console.WriteLine("The Parent Filter of XPath axis is : " + partentfilter);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_11_XPathAxis_ChildFilter() //XPath using child Filter
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&ddm=0&flowEntry=ServiceLogin&flowName=GlifWebSignIn&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqeR8EzttvIOBYpEVlv_2Z7g89BlTPcq7O2Os_Ka38NdtdqY9ksbyNPzbYVM-wednfK4Q_vEpQ&dsh=S554924116%3A1727815312489758";
        //    string childfilter=driver1.FindElement(By.XPath("//h1/child::span")).Text;
        //    Console.WriteLine("The Child filter of XPath Axis is : " + childfilter);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void vedio_11_XPathAxis_Following_Sibling() // XPath using following siblings
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string nextfollowingsibling = driver2.FindElement(By.XPath("//option[6]/following-sibling::option")).Text;
        //    int followingsibling = driver2.FindElements(By.XPath("//option[6]/following-sibling::option")).Count;
        //    Console.WriteLine("The Following Sibling of XPath Axis is : " + nextfollowingsibling);
        //    Console.WriteLine("The Following Sibling of XPath Axis is : " + followingsibling);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        //[TestMethod]
        //public void vedio_11_XPathAxis_Following() // XPath using following contents or elements
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string nextfollowingsibling = driver3.FindElement(By.XPath("//option[6]/following::*")).Text;
        //    int followingsibling = driver3.FindElements(By.XPath("//option[6]/following-sibling::*")).Count;
        //    Console.WriteLine("The Following elements or contents of XPath Axis is : " + nextfollowingsibling);
        //    Console.WriteLine("The number of Following elements or contents of XPath Axis is : " + followingsibling);
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_11_XPathAxis_Preceding_Sibling() //XPath using preceding sibling shows parent contents or elements above the xpath preceding sibling
        //{
        //    IWebDriver driver4 = new FirefoxDriver();
        //    driver4.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string precedingsiblings= driver4.FindElement(By.XPath("//option[5]/preceding-sibling::option")).Text;
        //    int precedingsiblingscount= driver4.FindElements(By.XPath("//option[5]/preceding-sibling::option")).Count;
        //    Console.WriteLine("The parent preceding sibling of selected element is : " + precedingsiblings);
        //    Console.WriteLine("The count of preceding siblings of parent the selected element is : " + precedingsiblingscount);
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod]
        //public void Vedio_11_XPathAxis_Preceding() //XPath using preceding shows count of contents or elements above the xpath preceding sibling
        //{
        //    IWebDriver driver5 = new FirefoxDriver();
        //    driver5.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string precedings = driver5.FindElement(By.XPath("//option[5]/preceding::*")).Text;
        //    int precedingscount = driver5.FindElements(By.XPath("//option[5]/preceding::*")).Count;
        //    Console.WriteLine("The above the preceding sibling of selected element is : " + precedings);
        //    Console.WriteLine("The count of preceding siblings of above the selected element is : " + precedingscount);
        //    Thread.Sleep(10000);
        //    driver5.Quit();
        //}
        //[TestMethod]
        //public void Vedio_11_XPathAxis_Ancestor() //XPath using ancestor shows all parent, grand parent, and grate grand parent elements of contents or elements of the xpath ancestor element
        //{
        //    IWebDriver driver6 = new FirefoxDriver();
        //    driver6.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string ancestortext= driver6.FindElement(By.XPath("//option[6]/ancestor::div")).Text;
        //    int ancestorcount=driver6.FindElements(By.XPath("//option[6]/ancestor::div")).Count;
        //    Console.WriteLine("The nodes of the ancestor of selected element is : " + ancestortext);
        //    Console.WriteLine("The nodes count of ancestor of above the selected element is : " + ancestorcount);
        //    Thread.Sleep(10000);
        //    driver6.Quit();
        //}
        //[TestMethod]
        //public void Vedio_11_XPathAxis_Descendant() //XPath using ancestor shows all child, grand child, and grate grand child elements of contents or elements of the xpath desendant element
        //{
        //    IWebDriver driver7 = new FirefoxDriver();
        //    driver7.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string desendanttext = driver7.FindElement(By.XPath("//div/descendant::option[6]")).Text;
        //    int descendantcount = driver7.FindElements(By.XPath("//div/descendant::option[6]")).Count;
        //    Console.WriteLine("The nodes of the desendant text of selected element is : " + desendanttext);
        //    Console.WriteLine("The nodes count of desendant parent tag of the selected element is : " + descendantcount);
        //    Thread.Sleep(10000);
        //    driver7.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Displayed() // this property used to verify whether the elements available in UI or not
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://mail.turbify.com/login";
        //    bool dispalyedproperty=driver.FindElement(By.ClassName("heroImage")).Displayed;
        //    Console.WriteLine("The Dispalyed property of the web element is available in UI? : " + dispalyedproperty);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Enabled() // this property verify whether the element is active in UI or not
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://mail.turbify.com/login";
        //    bool enabledproperty=driver1.FindElement(By.Id("login")).Enabled;
        //    Console.WriteLine("The enabled property of the web element is active in UI? : " + enabledproperty);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Location() // this property used to capture the locations of the selected element in UI
        //{
        //    //Point x;
        //    //Point y;
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://mail.turbify.com/login";
        //    Point x = driver2.FindElement(By.Id("login")).Location;
        //    //y = driver2.FindElement(By.Id("login")).Location;
        //    Console.WriteLine("The location property of the selected web element in UI is : " + x);
        //    //Console.WriteLine("The location property of the selected web element in UI is : " + locationproperty.y);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Selected() // this property used to verify whether the Radio button, Checkbox, or Dropdown are already selected or not
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://mail.turbify.com/login";
        //    bool selectedproperty=driver3.FindElement(By.Id("persistent")).Selected;
        //    Console.WriteLine("The selected property of the checkbox is selected or not ? : " + selectedproperty);
        //    //Console.WriteLine("The location property of the selected web element in UI is : " + locationproperty.y);
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Size() // this property used to find the widthe and hight of the selected web element
        //{
        //    IWebDriver driver4 = new FirefoxDriver();
        //    driver4.Url = "https://mail.turbify.com/login";
        //    Size sizeproperty= driver4.FindElement(By.Id("login")).Size;
        //    Console.WriteLine("The size of the selected web element is : " + sizeproperty);
        //    //Console.WriteLine("The location property of the selected web element in UI is : " + locationproperty.y);
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_TagName() // this property used to capture the tag name of the selected web element
        //{
        //    IWebDriver driver5 = new FirefoxDriver();
        //    driver5.Url = "https://mail.turbify.com/login";
        //    string tagnameproperty=driver5.FindElement(By.Id("login")).TagName;
        //    Console.WriteLine("The tag name of the selected web element is : " + tagnameproperty);
        //    //Console.WriteLine("The location property of the selected web element in UI is : " + locationproperty.y);
        //    Thread.Sleep(10000);
        //    driver5.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Text() // this property used to capture the text from the selected web element
        //{
        //    IWebDriver driver6 = new FirefoxDriver();
        //    driver6.Url = "https://mail.turbify.com/login";
        //    string textproperty=driver6.FindElement(By.XPath("//h2")).Text;
        //    string textproperty_1 = driver6.FindElement(By.XPath("//p")).Text;
        //    Console.WriteLine("The text of the selected web element is : " + textproperty);
        //    Console.WriteLine("The text of the selected web element is : " + textproperty_1);
        //    //Console.WriteLine("The location property of the selected web element in UI is : " + locationproperty.y);
        //    Thread.Sleep(10000);
        //    driver6.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Clear() // this property used to reset the existing value from the textbox or textarea box
        //{
        //    IWebDriver driver7 = new FirefoxDriver();
        //    driver7.Url = "https://mail.turbify.com/login";
        //    driver7.FindElement(By.Id("login")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver7.FindElement(By.Id("login")).Clear();
        //    Thread.Sleep(10000);
        //    driver7.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Click() // this property used to perform left click operation on the selected web element.
        //{
        //    IWebDriver driver8 = new FirefoxDriver();
        //    driver8.Url = "https://mail.turbify.com/login";
        //    driver8.FindElement(By.Id("link3")).Click();
        //    Thread.Sleep(10000);
        //    driver8.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_FindElement() // FindElement(By.Locator()) property used to locating element in IWebDriver is done by this method only.
        //{
        //    IWebDriver driver9 = new FirefoxDriver();
        //    driver9.Url = "https://mail.turbify.com/login";
        //    driver9.FindElement(By.Id("login")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver9.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_FindElements() // FindElements method takes locator(By Object) and return collection of type IWebDriver.
        //{
        //    IWebDriver driver10 = new FirefoxDriver();
        //    driver10.Url = "https://mail.turbify.com/login";
        //    int findelementsproperty=driver10.FindElements(By.TagName("input")).Count;
        //    Console.WriteLine("The total elements using FindElements property is : " + findelementsproperty);
        //    Thread.Sleep(10000);
        //    driver10.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_GetAttribute() // GetAttribute used to get the value of the passed attribute for selected web element.
        //{
        //    IWebDriver driver11 = new FirefoxDriver();
        //    driver11.Url = "https://mail.turbify.com/login";
        //     string getattributemethod=driver11.FindElement(By.TagName("img")).GetAttribute("src");
        //    Console.WriteLine("The Get Attribute method value for the selected element is : " + getattributemethod);
        //    Thread.Sleep(10000);
        //    driver11.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_GetCssValue() // GetCssValue used to get the value of the passed CSS property for selected web element.
        //{
        //    IWebDriver driver12 = new FirefoxDriver();
        //    driver12.Url = "https://mail.turbify.com/login";
        //    string getcssvaluemethod=driver12.FindElement(By.Id("signup")).GetCssValue("color");
        //    Console.WriteLine("The Get CSS Value method value for the selected element is : " + getcssvaluemethod);
        //    Thread.Sleep(10000);
        //    driver12.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_SendKeys() // SendKeys method is used to pass or type data into textbox or textarea box.
        //{
        //    IWebDriver driver13 = new FirefoxDriver();
        //    driver13.Url = "https://mail.turbify.com/login";
        //    driver13.FindElement(By.Id("login")).SendKeys("lakshminarayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver13.Quit();
        //}
        //[TestMethod]
        //public void Vedio_15_WebElements_Submit() // Submit method is used to submit the HTML form into server, it can be used only when the button type attribute is submit.
        //{
        //    IWebDriver driver14 = new FirefoxDriver();
        //    driver14.Url = "https://mail.turbify.com/login";
        //    driver14.FindElement(By.XPath(".//button[@id='link2']")).Submit();
        //    Thread.Sleep(10000);
        //    driver14.Quit();
        //}
        //[TestMethod]//Differences bitween Find Element and Find Elements 
        //public void Vedio_16_FindElementNoMatch() //   this method is used to locating the element in IWebDriver FindElement(By.Locator());
        //{
        //    IWebDriver driver = new FirefoxDriver();// no element match returns the NoSuchElementException error
        //    driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    IWebElement findelement= driver.FindElement(By.Id("logi")); //it throws an error NoSuchElementException
        //    Console.WriteLine("The exception throws an error : " + findelement);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_16_FindElementsNoMatch() //this method is used to locating the elements in IWebDriver FindElements(By.Locator());
        //{
        //    IWebDriver driver1 = new FirefoxDriver();// no element match returns the empty list of IWebElements error
        //    driver1.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    ReadOnlyCollection<IWebElement> findelements = driver1.FindElements(By.Id("logi"));
        //    Console.WriteLine("The exeception throes an error :" + findelements.Count);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_16_FindElementOneMatch() //   on one element match returs the found web element
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    IWebElement findelementonematch= driver2.FindElement(By.TagName("h1"));
        //    Console.WriteLine("The find element of one match returns the found elements in the page : " + findelementonematch.Text);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        //[TestMethod]
        //public void Vedio_16_FindElementsOneMatch() //   on one element match returs list of IWebElements which contains only one element
        //{
        //    IWebDriver driver3 = new FirefoxDriver();// 
        //    driver3.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    ReadOnlyCollection<IWebElement> findelementsonematch= driver3.FindElements(By.TagName("h1"));
        //    Console.WriteLine("The find elements of one match returns the found element in the page :" + findelementsonematch.Count);
        //    foreach(var items in findelementsonematch)
        //    {
        //        Console.WriteLine("The find elements of one match returns the found elements in the page: " + items.Text);
        //    }
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_16_FindElementMoreThanOneMatch() //   on more thamn one element match returs the first appearance in DOM
        //{
        //    IWebDriver driver3 = new FirefoxDriver();
        //    driver3.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    IWebElement FindElementMoreThanOneMatch=driver3.FindElement(By.TagName("option"));
        //    Console.WriteLine("The find element of on more than one match returns first appearance of the found elements in the page : " + FindElementMoreThanOneMatch.Text);
        //    Thread.Sleep(10000);
        //    driver3.Quit();
        //}
        //[TestMethod]
        //public void Vedio_16_FindElementsMoreThanOneMatch() //   on the more than one element match returs all matched elements as a list of IWebElements.
        //{
        //    IWebDriver driver4 = new FirefoxDriver();// 
        //    driver4.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    ReadOnlyCollection<IWebElement> FindElementsMoreThanOneMatch = driver4.FindElements(By.TagName("option"));
        //    Console.WriteLine("The list of found elements on more than one match returns in the page :" + FindElementsMoreThanOneMatch.Count);
        //    foreach (var morethanonematch in FindElementsMoreThanOneMatch)
        //    {
        //        Console.WriteLine("The find elements of one match returns the found elements in the page: " + morethanonematch.Text);
        //    }
        //    Thread.Sleep(10000);
        //    driver4.Quit();
        //}
        //[TestMethod] //how to count checked and unchecked checkboxes
        //public void Vedio_17_CountofCheckedandUncheckedCheckBoxes() // defaultly every web element has selected property, which tell us that whether it has been checked or not.
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    driver.FindElement(By.XPath("//input[@id='remembermecheckbox']")).Click();
        //    ReadOnlyCollection<IWebElement> iwebelementis = driver.FindElements(By.XPath("//input[@id='remembermecheckbox']"));
        //    int checkedcheckboxcount = 0;
        //    int uncheckedcheckboxcount = 0;
        //    foreach(var totalcount in iwebelementis)
        //    {
        //        if(totalcount.Selected==true)
        //        {
        //            checkedcheckboxcount++;
        //        }
        //        else
        //        {
        //            uncheckedcheckboxcount++;
        //        }
        //    }
        //    Console.WriteLine("The count of the CheckBox selection is :" + checkedcheckboxcount);
        //    Console.WriteLine("The count of the UnCheckBox selection is :" + uncheckedcheckboxcount);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod] //how to use newline and tab character in sendkeys
        //public void Vedio_18_TypeTextinNewLine() // to add text in new line we need to add '\n' to the text where you want to keep text in next line
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    driver.FindElement(By.Id("loginname")).SendKeys("lakshmi \n narayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod] //how to use newline and tab character in sendkeys
        //public void Vedio_18_UseTabCharactorinText() // to add text the tab in between text we need to add '\t' between the text
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    driver1.FindElement(By.Id("loginname")).SendKeys("lakshmi \t narayana73.p@gmail.com");
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod] //To find element with in element we need to use FindElement multiple times
        //public void Vedio_19_FindElementMultipleTimes_ISearchContext()// To find element with in element 
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    string findelementwithinelement = driver.FindElement(By.Id("inputarea")).FindElement(By.Id("languageSelect")).Text;
        //    Console.WriteLine("The element with in the element is : " + findelementwithinelement);
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod] // How to handle dropdown and multiselect dropdown in selenium web driver, In this vedio drop down and multiselect dropdown, SelectElement Class, properties in SelectElement Class, methods in SelectElement Class
        //public void Vedio_20_DropdownandMultiSelectDropdown()
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("languageSelect"));
        //    SelectElement selectelement = new SelectElement(elements);
        //    Console.WriteLine("The selected element count is : " + elements);
        //    IList<IWebElement> element = selectelement.Elements;
        //    Console.WriteLine("The count of the element is : " + element.Count);
        //    foreach (var items in element)
        //    {
        //        Console.WriteLine("The element are : " + items.Text);
        //    }
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void ExecuteAutomation_Video_8_DropDownAndMultiSelectOptions()
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Navigate().GoToUrl ("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqesWOlEesxkmxMWqviZKihhJy45DzLkprjxJ4B4mT79QEOb9AxoUX1sSfdFiKRzu-Z8x_LjWA&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S573964485%3A1728560690782946&ddm=1");
        //   IWebElement webele= driver1.FindElement(By.Id("dropdown-toggle-1"));
        //    SelectElement selectedele = new SelectElement(webele);
        //    IList<IWebElement> element = selectedele.SelectedOption("galego");
        //    Console.WriteLine(element);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_20_IsMultiple() // this tells us whether the SELECT element supported multiple selecting options at the same time or not
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    ReadOnlyCollection<IWebElement> element = driver1.FindElements(By.Id("languageSelect"));
        //    SelectElement selectedelement = new SelectElement(element);
        //    bool ismultiple = selectedelement.IsMultiple;
        //    Console.WriteLine("The value of element whether the selected or not is : " + ismultiple);
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        //[TestMethod]
        //public void Vedio_20_SelectByText() // We can select any option in the dropdown list or multiselect dropdown list using SelectByText method
        //{
        //    IWebDriver driver2 = new FirefoxDriver();
        //    driver2.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    IWebElement selectbytextelement= driver2.FindElement(By.Id("languageSelect"));
        //    SelectElement selectedelement = new SelectElement(selectbytextelement);
        //    selectedelement.SelectByText("English");
        //    Console.WriteLine("The value of element whether the selected or not is : " + selectedelement);
        //    Thread.Sleep(10000);
        //    driver2.Quit();
        //}
        // Vedio_20th should need to refarr again
        // Handling HTML Dropdown and Bootstrap Dropdown using IWebDriver
        //[TestMethod]
        //public void Vedio_21_HTMLDropDown()
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
        //    driver.FindElement(By.Id("languageSelect")).Click();
        //    Thread.Sleep(10000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void Vedio_21_BootStrapDropDown()
        //{
        //    IWebDriver driver1 = new FirefoxDriver();
        //    driver1.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=ARpgrqfWnCRdEq-vrLTPcKdfTvnUy6rGBxyRRPJNOE3-t_f4Lz9Tg-SBku6K4UfdYMvJ41CEktpR&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S1866155468%3A1728415234101368&ddm=1";
        //    driver1.FindElement(By.ClassName("VfPpkd-aPP78e")).Click();
        //    Thread.Sleep(10000);
        //    driver1.Quit();
        //}
        [TestMethod]
        public void Vedio_21_SelectValueInBootStrapDropDown()
        {
            IWebDriver driver2 = new FirefoxDriver();
            driver2.Url = "https://www.amazon.in/";
            //driver2.FindElement(By.Id("searchDropdownBox")).Click();
            string sr = driver2.FindElement(By.XPath(".//option[text()='Amazon Pharmacy']")).Text;
            Console.WriteLine("The give value is : " + sr);
            //string SelectElement = new SelectElement();
            //SelectElement.SelectByText("English(United Kingdom)");
            Thread.Sleep(10000);
            driver2.Quit();
        }
        // Vedio_21st should need to refarr again
        //Vedio_22nd about action classes
        [TestMethod]
        public void Vedio_23_MouseMoveToElement() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.Id("submitbutton")))
            .Build()
            .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_23_MouseMoveToElementContext() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.Id("submitbutton")), 20, 20)
                .ContextClick()
            .Build()
            .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_23_MouseMoveToElementTopLeft() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.Id("submitbutton")))
             .MoveToLocation(20, 20)
                .ContextClick()
            .Build()
            .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_24_MouseClickMethods() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.Name("login"))).Click()
                // .ContextClick()
                .Build()
                .Perform();

            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_24_MouseClickMethodsWithPerametor() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            act.Click(driver.FindElement(By.Name("login")))
                //act.MoveToElement(driver.FindElement(By.Name("login"))).Click()
                // .ContextClick()
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_25_MouseDoubleClickMethods() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.Name("login")))
                .DoubleClick()
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_25_MouseDoubleClickMethodsWithParametor() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://zixmessagecenter.com/s/welcome.jsp?b=zmc";
            Actions act = new Actions(driver);
            //act.MoveToElement(driver.FindElement(By.Id("submitbutton")))
            act.DoubleClick(driver.FindElement(By.Name("login")))
            .Build()
            .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_26_MouseClickandHold() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.worldometers.info/languages/how-many-letters-alphabet/#:~:text=The%20English%20Alphabet%20consists%20of,%2C%20X%2C%20Y%2C%20Z";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("//td[text()='1']")))
                .ClickAndHold()
                .MoveToElement(driver.FindElement(By.XPath("//td[text()='D']")))
                .Release()
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_26_MouseClickandHoldWithParametor() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.worldometers.info/languages/how-many-letters-alphabet/#:~:text=The%20English%20Alphabet%20consists%20of,%2C%20X%2C%20Y%2C%20Z";
            Actions act = new Actions(driver);
            //act.MoveToElement(driver.FindElement(By.XPath("//td[text()='1']")))
            act.ClickAndHold(driver.FindElement(By.XPath("//td[text()='1']")))
            .MoveToElement(driver.FindElement(By.XPath("//td[text()='F']")))
            .Release()
            .Build()
            .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_26_MouseClickandHoldAndReleaseWithParametor() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.worldometers.info/languages/how-many-letters-alphabet/#:~:text=The%20English%20Alphabet%20consists%20of,%2C%20X%2C%20Y%2C%20Z";
            Actions act = new Actions(driver);
            act.ClickAndHold(driver.FindElement(By.XPath("//td[text()='1']")))
                .Release(driver.FindElement(By.XPath("//td[text()='F']")))
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_27_ContextClickOrRightClick() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.worldometers.info/languages/how-many-letters-alphabet/#:~:text=The%20English%20Alphabet%20consists%20of,%2C%20X%2C%20Y%2C%20Z";
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("//td[text()='1']")))
                .ContextClick()
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_27_ContextClickOrRightClickWithPerametor() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.worldometers.info/languages/how-many-letters-alphabet/#:~:text=The%20English%20Alphabet%20consists%20of,%2C%20X%2C%20Y%2C%20Z";
            Actions act = new Actions(driver);
            //act.MoveToElement(driver.FindElement(By.XPath("//td[text()='1']")))
            act.ContextClick(driver.FindElement(By.XPath("//td[text()='1']")))
            .Build()
            .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]
        public void Vedio_28_MoveToOffSetCoordinates() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Faccounts.google.com%2F&followup=https%3A%2F%2Faccounts.google.com%2F&ifkv=AcMMx-c_66rfe1GcUhTTuQjc6U8keHfbT1fWAKO6VMwShfmeARc4LIwyp3-3QEcLZjcnOXD1MYnj&passive=1209600&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-2143751814%3A1730294950048691&ddm=1";
            Actions act = new Actions(driver);
            act.MoveByOffset(200, 200)
                .ContextClick()
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]  // NEED TO REVIEW THE CORRECT URL TO COMPLETE THE TEST SCRIPT
        public void Vedio_29_MouseDragAndDrop() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.globalsqa.com/demo-site/draganddrop/#Photo%20Manager";
            Actions act = new Actions(driver);
            act.DragAndDrop(driver.FindElement(By.XPath("//img[@src='images/high_tatras4_min.jpg']")), driver.FindElement(By.XPath("//div[@id='trash']")))
                 .Build()
                 .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]  // NEED TO REVIEW THE CORRECT URL TO COMPLETE THE TEST SCRIPT
        public void Vedio_30_MouseDragAndDropOffSet() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.globalsqa.com/demo-site/draganddrop/#Photo%20Manager";
            Actions act = new Actions(driver);
            act.DragAndDropToOffset(driver.FindElement(By.XPath("//img[@src='images/high_tatras4_min.jpg']")), 200, 210)
                 .Build()
                 .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]  // NEED TO REVIEW THE CORRECT URL TO COMPLETE THE TEST SCRIPT
        public void Vedio_30_ActionKeysUpandKeysDownMethods() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.globalsqa.com/demo-site/draganddrop/#Photo%20Manager";
            Actions act = new Actions(driver);
            //act.KeyDown(Keys.Control).Click(driver.FindElement(By.XPath("//img[@src='images/high_tatras_min.jpg']")))
            //    .Click(driver.FindElement(By.XPath("//img[@src='images/high_tatras4_min.jpg']")))
            //    .Click(driver.FindElement(By.XPath("//img[@src='images/high_tatras2_min.jpg']")))
            act.KeyDown(driver.FindElement(By.XPath("//img[@src='images/high_tatras_min.jpg']")),Keys.Control)
                .KeyDown(driver.FindElement(By.XPath("//img[@src='images/high_tatras4_min.jpg']")),Keys.Control)
                .KeyUp(driver.FindElement(By.XPath("//img[@src='images/high_tatras2_min.jpg']")),Keys.Control)
                .Release()
                .Build()
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
        [TestMethod]  // NEED TO REVIEW THE CORRECT URL TO COMPLETE THE TEST SCRIPT
        public void Vedio_32_ActionSendKeysMethods() //MoveToElement method in action class
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.globalsqa.com/demo-site/draganddrop/#Photo%20Manager";
            Actions act = new Actions(driver);
            act.SendKeys(Keys.End)
                .Perform();
            Thread.Sleep(10000);
            act.SendKeys(Keys.Home)
                .Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
