using NUnit.Framework;
using OpenQA.Selenium;
using SkillExchange.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillExchange.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            

            //Wait for login page to be loaded and 'Sign In' to become visible
            Wait.ElementIsVisible(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a");

            //Identify the Sign In button and click
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signIn.Click();

            //Wait for email textbox to be present
            Wait.ElementPresent(driver, "Name", "email");

            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "LoginPage");

            //Identify the email textbox and click
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys(ExcelLibHelpers.ReadData(2, "email"));
            

            //Identify the password textbox and click
            IWebElement pswrd = driver.FindElement(By.Name("password"));
            pswrd.SendKeys(ExcelLibHelpers.ReadData(2, "password"));
            

            //Identify the Login button and click
            IWebElement login = driver.FindElement(By.XPath("//html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            login.Click();

            //Wait for Home page to be loaded by checking if 'Sign Out' is visible
            Wait.ElementIsVisible(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[2]/button");


        }

        public void ValidateHomePage(IWebDriver driver) {

            try
            {

                //Verify if the home page is displayed
                IWebElement User = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));


                if(User.Text == "Hi Sara"){
                    TestContext.WriteLine($"Logged in successfully and message {User.Text} is displayed on home page");
                }

            }catch(Exception e)
            {
                Console.WriteLine("Home page not displayed", e.Message);
            }
        }

    }
    
}
