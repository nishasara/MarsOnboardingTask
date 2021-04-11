using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SkillExchange.Utilities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SkillExchange.Pages
{
    class HomePage
    {

        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Identify the profile tab in the Home Page
        IWebElement profile => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));

        //Identify the availability section and click on edit icon to add details
        IWebElement addAvailability => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));

        //Identify the availability dropdown
        IWebElement availabilityDrpdwn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

        //Identify the add hours section and 
        IWebElement addHours => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));

        //Identify the availability hours dropdown
        IWebElement availabilityHourDrpdwn => driver.FindElement(By.Name("availabiltyHour"));

        //Identify the earn target section
        IWebElement addEarnTarget => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));

        //Identify the earn target dropdown
        IWebElement availabiltyTargetDrpdwn => driver.FindElement(By.Name("availabiltyTarget"));

        //Identify the element to edit and add description
        IWebElement description => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));

        IWebElement addDescription => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

        //Identify the save button
        IWebElement save => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

        //Identify the language tab and click 
        IWebElement languageTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));

        //Identify the add new button for language
        IWebElement addNewLanguageButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));

        //Identify the add Language text box
        IWebElement addLanguage => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));

        //Identify the dropdown for language level
        IWebElement languageLevelDrpdwn => driver.FindElement(By.Name("level"));

        //Identify the add button for language
        IWebElement languageDetailsAddButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        //Identify the Skills tab and click 
        IWebElement skillsTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        //Identify the add new button for adding a new entry for Skills
        IWebElement addNewSkillButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));

        //Identify the add skill text box
        IWebElement addSkill => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));

        //Identify the dropdown for skill level
        IWebElement skillLevelDrpdwn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));

        //Identify the add button for all the skill details
        IWebElement skillDetailsAddButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        //Identify the skill details in the profile
        IWebElement skill => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        IWebElement Skilllevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

        //Identify the add new button for adding a new entry for education details
        IWebElement addNewEducationButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));

        //Identify the College/University text box
        IWebElement addCollege => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));

        //Identify the country dropdown
        IWebElement countryDrpdwn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        //Identify the dropdown for title
        IWebElement titleDrpdwn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));

        //Identify the degree text box
        IWebElement addDegree => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));

        //Identify the year text box
        IWebElement graduateYearDrpdwn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        //Identify the add button for adding the details of education
        IWebElement educationDetailsAddButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        //Identify the details for education in the profile
        IWebElement country => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));

        IWebElement university => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));

        IWebElement Title => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));

        IWebElement Degree => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));

        IWebElement graduationYear => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));

        //Identify the add new button to add the certification details
        IWebElement addNewCertificationButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        //Identify the certificate text box
        IWebElement addCertificate => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));

        //Identify the Certified From text box
        IWebElement certifiedFrom => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));

        //Identify the year drop down for certification
        IWebElement yearDrpdwn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));

        //Identify the add button for adding all the certification details
        IWebElement certificationDetailsAddButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        //Get the pop up text and display
        public void getPopText()
        {
            //Wait until the pop up appears
            Wait.ElementIsVisible(driver, "XPath", "//div[@class='ns-box-inner']");
            Thread.Sleep(250);
            //Get the text from the pop up
            String msg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            TestContext.WriteLine(msg);
            Thread.Sleep(250);
            //Close the pop up before adding next entry
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
            Thread.Sleep(250);
        }

        public void navigateToProfile()
        {
            //Click on the profile tab in the home page
            profile.Click();
        }

        public void addDetails()
        {
            //Click on Add Availability      
            addAvailability.Click();
            Thread.Sleep(500);

            SelectElement availabilitySelect = new SelectElement(availabilityDrpdwn);

            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            //Read the availability data fom the excel 
            var availabilityData = ExcelLibHelpers.ReadData(2, "Availability");

            //Select the required availability option from the dropdown
            availabilitySelect.SelectByText(availabilityData);

            getPopText();

            //Click on add hours
            addHours.Click();

            Thread.Sleep(500);

            SelectElement availabilityHourSelect = new SelectElement(availabilityHourDrpdwn);

            //Read the hours data from the excel
            var hoursData = ExcelLibHelpers.ReadData(2, "Hours");

            //Select the required availability hour value from the dropdown
            availabilityHourSelect.SelectByText(hoursData);

            getPopText();

            //Click to add Earn Target details
            addEarnTarget.Click();

            Thread.Sleep(500);

            SelectElement availabiltyTargetSelect = new SelectElement(availabiltyTargetDrpdwn);

            //Read the data for the Earn Target from the excel
            var earnTargetData = ExcelLibHelpers.ReadData(2, "Earn Target");

            //Select the required target value from the dropdown
            availabiltyTargetSelect.SelectByText(earnTargetData);

            getPopText();

            //Validate if the details are added correctly
            string availability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).Text;
            string hours = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span")).Text;
            string earnTarget = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span")).Text;

            if ((availability == availabilityData) && (hours == hoursData) && (earnTarget == earnTargetData))
                Assert.Pass("Test Passed!! Availability, Hours and Earn Target details has been added to the profile successfully");
            else
                Assert.Fail("Test Failed, Availability, Hours and Earn Target details has not been added to the profile successfully");
        }

        public void AddDescription()
        {

            //Wait for the edit icon for the description to be available
            Wait.ElementIsVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span");

            //Click on the description
            description.Click();

            //Wait for the description box to be available so as to add description
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea");

            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            //Read description data from the excel
            var descriptionStatement = ExcelLibHelpers.ReadData(2, "Description");

            addDescription.Clear();

            Thread.Sleep(100);

            //Add description
            addDescription.SendKeys(descriptionStatement);

            //Click on save button
            save.Click();

            //Wait until the description appears on the profile
            Wait.ElementIsVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span");

            //Get the description value
            String descrptnBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;

            getPopText();

            //Validate if the description has been added correctly
            if (descrptnBox == descriptionStatement)
                Assert.Pass("Test Passed, description has been added successfully");
            else
                Assert.Fail("Test Failed, description has not been added successfully");

        }

        public void goToLanguageTab()
        {
            //Wait until the Language tab is visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]");

            //Click on language tab
            languageTab.Click();
        }

        public void addLanguages()
        {
            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            var languageData = new string[4];
            var levelData = new string[4];
            bool firstColumnCheck = false;
            bool secondColumnCheck = false;
            bool[] rowCheck = new bool[4];
            int entries = 4;
            for (int entryCount = 0; entryCount < entries; entryCount++)
            {

                //Wait until 'add language' text box is present
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");

                //Click on add new button
                addNewLanguageButton.Click();

                //Wait until 'add language' text box is present
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");

                //Read language data from the excel
                languageData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "Language");

                //add the language 
                addLanguage.SendKeys(languageData[entryCount]);

                SelectElement levelSelect = new SelectElement(languageLevelDrpdwn);

                //Read the language level data from the excel
                levelData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "LanguageLevel");

                //Select the required value from the dropdown
                levelSelect.SelectByText(levelData[entryCount]);

                //Click on the add button to add all the language details
                languageDetailsAddButton.Click();

                //Get the message displayed in the pop after the language details are updated
                getPopText();

            }

            //Wait for the language details to be updated
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]");

            IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));

            //Get the list of rows in the table for the last Page
            IList<IWebElement> languageRows = table.FindElements(By.TagName("tr"));
            IList<IWebElement> columnsFirstRow = languageRows[1].FindElements(By.TagName("td"));
            IWebElement Column;

            //Validate if all the entries for the language is added successfully and correctly by checking the table values
            for (int entry = 1; entry < languageRows.Count; entry++)
            {
                for (int col = 1; col < columnsFirstRow.Count; col++)
                {
                    Column = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + (entry) + "]/tr/td[" + col + "]"));

                    if (col == 1)
                    {
                        if (Column.Text == languageData[entry - 1])
                            firstColumnCheck = true;
                    }
                    else if (col == 2)
                    {
                        if (Column.Text == levelData[entry - 1])
                            secondColumnCheck = true;
                    }
                }
                //Validate each entry for Language updated in the page by checking the column values
                rowCheck[entry - 1] = firstColumnCheck && secondColumnCheck;

                //Check if both Language and Language Level values updated in the page matches with the data in excel
                if (rowCheck[entry - 1])
                    TestContext.WriteLine($" Entry {entry} for the Language is added correctly");
                else
                    TestContext.WriteLine($" Entry {entry} for the Language is not added correctly");

                //Set the check values to false before next iteration
                firstColumnCheck = false;
                secondColumnCheck = false;
            }

            //Validate if all the added entries in the table match with the value provided
            if (rowCheck[0] && rowCheck[1] && rowCheck[2] && rowCheck[3])
                Assert.Pass("Test Passed, Language details has been added correctly");
            else
                Assert.Fail("Test Failed, Language details has not been added correctly");

        }


        public void goToSkillsTab()
        {

            //Wait until the Skills tab is visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");

            //Click on skills tab
            skillsTab.Click();
        }

        public void addSkills()
        {
            var skillData = new string[4];
            var skillLevelData = new string[4];
            bool firstColumnCheck = false;
            bool secondColumnCheck = false;
            bool[] rowCheck = new bool[4];
            int entries = 4;

            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            for (int entryCount = 0; entryCount < entries; entryCount++)
            {
                //Wait until add new button is present
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");

                //Click on add new button for Skills
                addNewSkillButton.Click();

                //Read the skill from the excel
                skillData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "Skill");

                //Wait until add skill text box is visible
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input");

                //add the required skill 
                addSkill.SendKeys(skillData[entryCount]);

                SelectElement levelSelect = new SelectElement(skillLevelDrpdwn);

                //Read the skill Level from the excel
                skillLevelData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "SkillLevel");

                //Select the required level from the dropdown
                levelSelect.SelectByText(skillLevelData[entryCount]);

                //Click on the add button to add all the skill details
                skillDetailsAddButton.Click();

                //Get the message displayed in the pop after each skill details are updated
                getPopText();
            }

            //Wait until the skill details are added and are visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]");

            //Idenitfy the table that stores the data for the Skill
            IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));

            //Get the list of rows in the table for the last Page
            IList<IWebElement> skillRows = table.FindElements(By.TagName("tr"));
            //Get the list of columns
            IList<IWebElement> columnsFirstRow = skillRows[1].FindElements(By.TagName("td"));
            IWebElement Column;

            //Validate if all the entries for the language is added successfully and correctly by checking the table values
            for (int entry = 1; entry < skillRows.Count; entry++)
            {
                for (int col = 1; col < columnsFirstRow.Count; col++)
                {
                    //Access each column value in the table
                    Column = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + (entry) + "]/tr/td[" + col + "]"));

                    if (col == 1)
                    {
                        if (Column.Text == skillData[entry - 1])
                            firstColumnCheck = true;
                    }
                    else if (col == 2)
                    {
                        if (Column.Text == skillLevelData[entry - 1])
                            secondColumnCheck = true;
                    }
                }
                //Validate each entry for Language updated in the page by checking the column values
                rowCheck[entry - 1] = firstColumnCheck && secondColumnCheck;

                //Check if both Skills and Level values updated in the page matches with the data in excel
                if (rowCheck[entry - 1])
                    TestContext.WriteLine($" Entry {entry} for the skill is added correctly");
                else
                    TestContext.WriteLine($" Entry {entry} for the skill is not added correctly");
                //Set the check values to false before next iteration
                firstColumnCheck = false;
                secondColumnCheck = false;
            }

            //Validate if all the added entries in the table match with the value provided
            if (rowCheck[0] && rowCheck[1] && rowCheck[2] && rowCheck[3])
                Assert.Pass("Test Passed, Skill details has been added correctly");
            else
                Assert.Fail("Test Failed, Skill details has not been added correctly");

        }

        public void goToEducationTab()
        {

            //Wait until the Education tab is visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]");

            //Identify the Education tab and click 
            IWebElement EducationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            EducationTab.Click();
        }

        public void addEducation()
        {
            //Wait until the edit button for adding aducation details is visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div");

            //Click on the add new button for adding a new entry for the education details
            addNewEducationButton.Click();

            //Wait until the he College/University text box is present
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input");

            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            //Read the College name from the excel
            var collegeData = ExcelLibHelpers.ReadData(2, "College/University Name");

            //add the required college
            addCollege.SendKeys(collegeData);

            SelectElement countrySelect = new SelectElement(countryDrpdwn);

            //Read the country name from the excel
            var countryData = ExcelLibHelpers.ReadData(2, "Country of College/University");

            //Select the required country from the dropdown
            countrySelect.SelectByText(countryData);

            SelectElement titleSelect = new SelectElement(titleDrpdwn);

            //Read the title name from the excel
            var titleData = ExcelLibHelpers.ReadData(2, "Title");

            //Select the required title from the dropdown
            titleSelect.SelectByText(titleData);

            //Read the degree data from the excel
            var degreeData = ExcelLibHelpers.ReadData(2, "Degree");

            //Enter the required degree to the education 
            addDegree.SendKeys(degreeData);

            SelectElement year = new SelectElement(graduateYearDrpdwn);

            //Read the degree data from the excel
            var yearData = ExcelLibHelpers.ReadData(2, "Year of graduation");

            //Select the required title from the dropdown
            year.SelectByText(yearData);

            //Click on the add button to add all the education details
            educationDetailsAddButton.Click();

            //Get the message displayed on the pop up after education details are added
            getPopText();

            //wait until the details appear
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]");

            //Validate the details added in the Education tab
            if ((country.Text == countryData) && (university.Text == collegeData) && (Title.Text == titleData) && (Degree.Text == degreeData) && (graduationYear.Text == yearData))
                Assert.Pass("Test Passed, Education details has been added succesfully");
            else
                Assert.Fail("Test Failed, Education details has not been added succesfully");

        }

        //Navigate to the certification tab
        public void goToCertificationTab()
        {
            //Wait until the Certification tab is visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]");

            //Identify the Certification tab and click 
            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();
        }


        public void addCertifications()
        {
            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            var certificateData = new string[4];
            var certifiedFromData = new string[4];
            var certificationYearData = new string[4];
            bool firstColumnCheck = false;
            bool secondColumnCheck = false;
            bool thirdColumnCheck = false;
            bool[] rowCheck = new bool[4];
            int entries = 4;

            //Add all the certification details in the profile
            for (int entryCount = 0; entryCount < entries; entryCount++)
            {
                //Wait until add new button is present
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");

                //Click on the add new button to add the details
                addNewCertificationButton.Click();

                //Wait until the certificate text box is available
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input");

                //Read the  name from the excel
                certificateData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "Certificate/Award");

                //Add the required certificate details
                addCertificate.SendKeys(certificateData[entryCount]);

                //Read the Certified From Data from the excel
                certifiedFromData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "Certified From");

                //Add the data for the 'Çertified From' field
                certifiedFrom.SendKeys(certifiedFromData[entryCount]);

                SelectElement yearSelect = new SelectElement(yearDrpdwn);

                //Read the Certified From Data from the excel
                certificationYearData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 2, "Year of certification");

                //Select the required year from the dropdown
                yearSelect.SelectByText(certificationYearData[entryCount]);

                //Click on the add button to add the details
                certificationDetailsAddButton.Click();

                //Get the message displayed on the pop up after certification details are added
                getPopText();
            }

            //Wait until the certificate for text box is visible
            Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]");

            //Idenitfy the table that stores the data for the Certification
            IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));

            //Get the list of rows in the table
            IList<IWebElement> certRows = table.FindElements(By.TagName("tr"));
            //Get the list of columns
            IList<IWebElement> columnsFirstRow = certRows[1].FindElements(By.TagName("td"));
            IWebElement Column;

            //Validate if all the entries for the language is added successfully and correctly by checking the table values
            for (int entry = 1; entry < certRows.Count; entry++)
            {
                for (int col = 1; col < columnsFirstRow.Count; col++)
                {
                    //Access each column value in the table
                    Column = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + (entry) + "]/tr/td[" + col + "]"));

                    if (col == 1)
                    {
                        if (Column.Text == certificateData[entry - 1])
                            firstColumnCheck = true;
                    }
                    else if (col == 2)
                    {
                        if (Column.Text == certifiedFromData[entry - 1])
                            secondColumnCheck = true;
                    }
                    else if (col == 3)
                    {
                        if (Column.Text == certificationYearData[entry - 1])
                            thirdColumnCheck = true;
                    }
                }
                //Validate each entry for certificate updated in the page by checking the column values
                rowCheck[entry - 1] = firstColumnCheck && secondColumnCheck && thirdColumnCheck;

                //Check if certificate, From and Year values updated in the page match with the data in excel
                if (rowCheck[entry - 1])
                    TestContext.WriteLine($" Entry {entry} data for the certification is added correctly");
                else
                    TestContext.WriteLine($" Entry {entry} data for the certification is not added correctly");

                //Set the check values to false before next iteration
                firstColumnCheck = false;
                secondColumnCheck = false;
                thirdColumnCheck = false;
            }

            //Validate if all the added entries in the table match with the value provided
            if (rowCheck[0] && rowCheck[1] && rowCheck[2] && rowCheck[3])
                Assert.Pass("Test Passed, Certifications details has been added correctly");
            else
                Assert.Fail("Test Failed, Certifications details has not been added correctly");

        }

        public void checkDuplicateEntries()
        {
            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");

            var certificateData = new string[2];
            var certifiedFromData = new string[2];
            var certificationYearData = new string[2];
            int entries = 2;

            //Add all the certification details in the profile
            for (int entryCount = 0; entryCount < entries; entryCount++)
            {
                //Wait until add new button is present
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");

                //Click on the add new button to add the details
                addNewCertificationButton.Click();

                //Wait until the certificate text box is available
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input");

                //Read the data from the excel
                certificateData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 6, "Certificate/Award");

                //Add the required certificate details
                addCertificate.SendKeys(certificateData[entryCount]);

                //Read the Certified From Data from the excel
                certifiedFromData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 6, "Certified From");

                //Add the data for the 'Çertified From' field
                certifiedFrom.SendKeys(certifiedFromData[entryCount]);

                SelectElement yearSelect = new SelectElement(yearDrpdwn);

                //Read the Certified From Data from the excel
                certificationYearData[entryCount] = ExcelLibHelpers.ReadData(entryCount + 6, "Year of certification");

                //Select the required year from the dropdown
                yearSelect.SelectByText(certificationYearData[entryCount]);

                //Click on the add button to add the details
                certificationDetailsAddButton.Click();

                //Wait until the pop up appears
                Wait.ElementIsVisible(driver, "XPath", "//div[@class='ns-box-inner']");
                Thread.Sleep(1000);
                if (entryCount == 0)
                {
                    //Get the text from the pop up
                    String msg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                    TestContext.WriteLine(msg);
                    Thread.Sleep(1000);
                    //Close the pop up before adding next entry
                    driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
                    Thread.Sleep(1000);
                }
                else
                {
                    String validateMsg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                    if (validateMsg == "This information is already exist.")
                        Assert.Pass("Test Passed, Duplicate entry is not allowed and pop up message is displayed");
                    else
                        Assert.Fail("Test Failed!!!");
                }

            }
        }

        public void editLanguages()

        {
            //Pass the filename and sheetname of the excel sheet
            ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Onboarding_task\SkillExchange\SkillExchange\TestData\TestData.xls", "HomePage");
            //Read the degree data from the excel
            var UpdateLang = ExcelLibHelpers.ReadData(6, "Language");
            var UpdateLangLevel = ExcelLibHelpers.ReadData(6, "LanguageLevel");

            //Identify the language table
            IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));

            //Get the list of rows in the table
            IList<IWebElement> languageRows = table.FindElements(By.TagName("tr"));

            //If the are atleast 1 entry for language
            if (languageRows.Count > 1)
            {
                //Wait until edit button is present
                Wait.ElementPresent(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]");

                //Identify the Edit button of the last entry in the table
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]")).Click();

                //Wait for the edit mode to be visible
                Thread.Sleep(100);

                //Identify the add language box to be updated
                IWebElement editLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

                //Clear the data
                editLanguage.Clear();

                //Enter the updated data
                editLanguage.SendKeys(UpdateLang);

                //Identify the level dropdown box to update
                IWebElement editLanguageLevel = driver.FindElement(By.XPath("//select[@name='level']"));
                SelectElement Editlevel = new SelectElement(editLanguageLevel);
                Editlevel.SelectByText(UpdateLangLevel);

                Thread.Sleep(100);
                //Idenitfy the Update button
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]")).Click();
                
                //Get the message displayed in the pop up
                getPopText();

                //Get the First Column value from last entry in the table
                String updatedLang = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;

                //Get the Second Column value from last entry in the table
                String updatedLangLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;

                //Validate the updated language entry
                if ((updatedLang == UpdateLang) && (updatedLangLevel == UpdateLangLevel))
                  Assert.Pass("Test Passed, Language details are updated correctly");
                else
                  Assert.Fail("Test Failed, Language details are not updated correctly");
                
            }
            //Display error message and fail the test if there are no entries to be edited
            else
            {
                Assert.Fail("Edit cannot be performed, there are no language records to be edited");
            }

        }

        public void DeleteLanguages()

        {
            //Identify the language table
            IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));

            //Get the list of rows in the table
            IList<IWebElement> languageRows = table.FindElements(By.TagName("tr"));

            //Check if there are any entries for the language in the table
            if (languageRows.Count > 1)
            {
                String Lang = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                //Delete the last element in the table
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
                Thread.Sleep(100);
                //Get the string from the pop up
                String validateDelMsg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                //Validate the message displayed in the pop up
                if (validateDelMsg == $"{Lang} has been deleted from your languages")
                    Assert.Pass("Test Passed, Language has been deleted");
                else
                    Assert.Fail("Test Failed, Language has not been deleted");

            }
            //Display error message and fail the test if there are no entries to be deleted
            else
            {
                Assert.Fail("Delete cannot be performed, there are no language records to be deleted");
            }
        }
    }
}
