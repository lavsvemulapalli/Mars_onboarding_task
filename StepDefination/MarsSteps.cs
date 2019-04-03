using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars.StepDefination
{
    [Binding]
    public class MarsSteps
    {
        IWebDriver d;

        [Given(@"I logged into skillswap successfully")]

        public void GivenILoggedIntoSkillswapSuccessfully()
        {
//intilizing the browser
            d = new ChromeDriver();
//opening url
            d.Navigate().GoToUrl("http://www.skillswap.pro/");
            Thread.Sleep(3000);
//giving implicit wait
            d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
//maxmizing the window
            d.Manage().Window.Maximize();
 //log into application
            Common a = new Common(d);
//click on sign in button
            a.signin.Click();
            Thread.Sleep(3000);
//entering username
            a.UN.SendKeys("vlavanya10@gmail.com");
            Thread.Sleep(3000);
//entering password
            a.pwd.SendKeys("lavanya");
            Thread.Sleep(3000);
//click on login button
            a.login.Click();
            Thread.Sleep(10000);
//verifiying login sucessfull or not
            Assert.IsTrue( a.signout.Displayed);
            

        }
        
        [Given(@"I enterd  my description and save it")]
        public void GivenIEnterdMyDescriptionAndSaveIt()
        {
            Common a = new Common(d);
//entering avilability details
          
            a.Avilabilityedit.Click();
            Thread.Sleep(2000);
            a.avilabiltyType("Full Time");
            Thread.Sleep(2000);
            a.Hoursedit.Click();
            Thread.Sleep(2000);
 //entering Hours details
            a.avilabiltyhours("More than 30hours a week");
            Thread.Sleep(2000);
            a.earntargetedit.Click();
            Thread.Sleep(2000);
        
 //entering target details
            a.earntarget("More than $1000 per month");
            Thread.Sleep(2000);
// entering description
            a.edit.Click();
            Thread.Sleep(2000);
            a.des.Clear();
            a.des.SendKeys("hi this is lavanya i have 2 years of experience as a test analyst ");
            a.save.Click();
            
        }
        
        [When(@"I entered all my profile details")]
        public void WhenIEnteredAllMyProfileDetails()
        {
 //entering languages 
            Common a = new Common(d);
            a.langadd.Click();
            a.addlang.SendKeys("English");
            a.language("Fluent");
            a.add.Click();
            Thread.Sleep(3000);
            a.langadd.Click();
            a.addlang.SendKeys("Hindhi");
            a.language("Fluent");
            a.add.Click();
            Thread.Sleep(3000);
            a.langadd.Click();
            a.addlang.SendKeys("Telugu");
            a.language("Native/Bilingual");
            a.add.Click();
            Thread.Sleep(3000);
//entering skills
            a.skills.Click();
            Thread.Sleep(3000);
            a.skillsadd.Click();
            a.addskills.SendKeys("manual Testing");
            a.skill("Intermediate");
            a.add.Click();
            Thread.Sleep(3000);
            a.skillsadd.Click();
            a.addskills.SendKeys("automation");
            a.skill("Intermediate");
            a.add.Click();
            Thread.Sleep(3000);
            a.skillsadd.Click();
            a.addskills.SendKeys("Selenium");
            a.skill("Intermediate");
            a.add.Click();
            Thread.Sleep(3000);
            a.skillsadd.Click();
            a.addskills.SendKeys("API Testing");
            a.skill("Intermediate");
            a.add.Click();
            Thread.Sleep(3000);
            a.skillsadd.Click();
            a.addskills.SendKeys("perfomance Testing");
            a.skill("Beginner");
            a.add.Click();
            Thread.Sleep(3000);

 // entering education details


            a.edu.Click();
            Thread.Sleep(3000);
            a.newedu.Click();
            a.collegename.SendKeys("JNTU");
            a.county("India");
            a.title("B.Tech");
            a.degree.SendKeys("under graduation");
            a.year("2010");
            a.addeddbtn.Click();
            Thread.Sleep(2000);
            a.newedu.Click();
            a.collegename.SendKeys("USQ/UUNZ");
            a.county("New Zealand");
            a.title("M.A");
            a.degree.SendKeys("Post graduation");
            a.year("2017");
            a.addeddbtn.Click();
            Thread.Sleep(2000);

//entering certification details

            a.certificatebtn.Click();
            Thread.Sleep(2000);
            a.addnewcerticatebtn.Click();
            a.certificatename.SendKeys("ISTQB Foundation Level");
            a.certificationfrom.SendKeys("ISTQB/ANZTB");
            a.ceryear("2018");
            Thread.Sleep(2000);
            a.add.Click();
 //entering name details
            a.nameedit.Click();
            Thread.Sleep(2000);

            a.firstname.Clear();
            a.firstname.SendKeys("lavanya");
            Thread.Sleep(2000);
            a.Lastname.Clear();
            a.Lastname.SendKeys("vemulapalli");
            Thread.Sleep(2000);
            a.nameSave.Click();
            Thread.Sleep(2000);

//clicking on shareskills button
            a.shareskillsbtn.Click();
//entering title
            a.skillstitle.Clear();
            Thread.Sleep(2000);

            a.skillstitle.SendKeys("Test Analyst");
            Thread.Sleep(2000);
//entering description
            a.skillsdescription.Clear();
            Thread.Sleep(2000);
            a.skillsdescription.SendKeys("As an ISTQB Certified Tester having experience in  both Manual Testing and automation testing");

            Thread.Sleep(2000);
//selecting category
            a.category("Programming & Tech");
            Thread.Sleep(2000);
//selecting subcategory

            a.subcategory("QA");
//adding tags
            a.tags.SendKeys("manual Testing");
            Thread.Sleep(2000);
            a.tags.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            a.tags.SendKeys("automation Testing");
            Thread.Sleep(2000);
            a.tags.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            a.tags.SendKeys("API Testing ");
            Thread.Sleep(2000);
            a.tags.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            a.tags.SendKeys("Perfomance Testing ");
            Thread.Sleep(2000);
            a.tags.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
// entering service type
            a.servicetype.Click();
            Thread.Sleep(2000);
//entering location type
            a.locationType.Click();

  //entering avilable days          

            a.startdate.SendKeys("05-04-2019");
            Thread.Sleep(2000);
            
            a.enddate.SendKeys("10-11-2019");
            Thread.Sleep(2000);
            a.avilabiltycheckbox.Click();
            Thread.Sleep(2000);
            a.avilabiltystarttime.SendKeys("09:00");
            Thread.Sleep(2000);
            a.avilabiltyendtime.SendKeys("17:00");
            Thread.Sleep(2000);
            a.avilabiltycheckboxtue.Click();
            Thread.Sleep(2000);
            a.avilabiltystarttimeontue.SendKeys("09:00");
            a.avilabiltyendtimeontue.SendKeys("17:00");
            Thread.Sleep(2000);
            a.avilabiltycheckboxonwed.Click();
            a.avilabiltystarttimeonwed.SendKeys("09:00");
            a.avilabiltyendtimeonwed.SendKeys("17:00");
            Thread.Sleep(2000);
//choosing skillstrade

            a.skillstrade.Click();
            Thread.Sleep(2000);
//entering credit amount
            a.credit.SendKeys("9");
            Thread.Sleep(2000);
            
 //choosing active radio button
 
            a.active.Click();
            Thread.Sleep(2000);
//clicking save button
            a.savebtn.Click();
            Thread.Sleep(5000);






        }
        
        [Then(@"I check my profile details are added correctly or not")]
        public void ThenICheckMyProfileDetailsAreAddedCorrectlyOrNot()
        {
            Common a = new Common(d);
 //verification managelisting page  

            Assert.IsTrue(a.verfication.Displayed);

            Thread.Sleep(2000);
 //verification profile page
            a.proifle1.Click();
            Thread.Sleep(2000);
            

            Assert.IsTrue(a.profileverification.Displayed);
            Thread.Sleep(2000);
//verifying languages are  added or not
            Assert.IsTrue(a.verifyinglanuage.Displayed);
            Thread.Sleep(1000);
 //verifying skills are added or not
            a.skills.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(a.verifyingskils.Displayed);
            Thread.Sleep(1000);
//verifying education detais added or not

            a.edu.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(a.verifyingedu.Displayed);
            Thread.Sleep(1000);
 //verifying ceritification detais added or not

            a.certificatebtn.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(a.verifyingcertication.Displayed);

            Thread.Sleep(3000);

            //close the browser
            d.Quit();



        }
    }
}
