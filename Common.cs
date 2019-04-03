using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
     class Common
    {
        IWebDriver _d;
        public Common(IWebDriver d)
        {
            _d = d;
            PageFactory.InitElements(_d, this);
        }


        //  public static IWebDriver d { get; set; }
//login 
        [FindsBy(How = How.XPath, Using = "//a[@class='item']")] public IWebElement signin;
        [FindsBy(How = How.XPath, Using = "//input[@name='email']")] public IWebElement UN;
        [FindsBy(How = How.XPath, Using = "//input[@name='password']")] public IWebElement pwd;
       [FindsBy(How =How.XPath,Using = "//button[@class='fluid ui teal button']")] public IWebElement login;
        [FindsBy(How = How.XPath, Using = "//button[@class='ui green basic button']")] public IWebElement signout;
        

//profile
        [FindsBy(How = How.XPath, Using = "//a[text()='Profile']")] public IWebElement profile;

        [FindsBy(How = How.XPath, Using = "//div[@class='title']/i")] public IWebElement nameedit;
        [FindsBy(How = How.XPath, Using = "//input[@name='firstName']")] public IWebElement firstname;
        [FindsBy(How = How.XPath, Using = "//input[@name='lastName']")] public IWebElement Lastname;
        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")] public IWebElement nameSave;
        [FindsBy(How = How.XPath, Using = "//strong[text()='Hours']//preceding::i[2]")] public IWebElement Avilabilityedit;
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")] public IWebElement type;
        [FindsBy(How = How.XPath, Using = "//strong[text()='Hours']//following::i[1]")] public IWebElement Hoursedit;
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")] public IWebElement hours ;
        [FindsBy(How = How.XPath, Using = "//strong[text()='Earn Target']//following::i[1]")] public IWebElement earntargetedit;
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")] public IWebElement target;

//description

        [FindsBy(How = How.XPath, Using = "//i[@class='outline write icon']")] public IWebElement edit;
        [FindsBy(How = How.XPath, Using = "//textarea[@name='value']")] public IWebElement des;

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")] public IWebElement save;
//adding languages
        [FindsBy(How = How.XPath, Using = "//div[text()='Add New']")] public IWebElement langadd;
        [FindsBy(How=How.XPath,Using = "//input[@placeholder='Add Language']")] public IWebElement addlang;
        [FindsBy(How = How.XPath, Using = "//select[@class='ui dropdown']")] public IWebElement langlevel;
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")] public IWebElement add;


//adding skills
        [FindsBy(How = How.XPath, Using = "//a[text()='Skills']")] public IWebElement skills;
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")] public IWebElement skillsadd;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")] public IWebElement addskills;
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']")] public IWebElement skilllevel;

//adding education

        [FindsBy(How = How.XPath, Using = "//a[text()='Education']")] public IWebElement edu;
        [FindsBy(How = How.XPath, Using = "//th[text()='Graduation Year']//following::div[1]")] public IWebElement newedu;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")] public IWebElement collegename;
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")] public IWebElement countrychoose;
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")] public IWebElement coursetitle;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")] public IWebElement degree;
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")] public IWebElement yearofgrad;
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide field']/input[1]")] public IWebElement addeddbtn;


//adding certification


        [FindsBy(How = How.XPath, Using = "//a[text()='Certifications']")] public IWebElement certificatebtn;
        [FindsBy(How = How.XPath, Using = "//th[text()='Year']//following::div[1]")] public IWebElement addnewcerticatebtn;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")] public IWebElement certificatename;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")] public IWebElement certificationfrom;
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")] public IWebElement ceryr;
 
 //click on share skills button       
        [FindsBy(How = How.XPath, Using = "//a[text()='Share Skill']")] public IWebElement shareskillsbtn;

   //next page


        [FindsBy(How = How.XPath, Using = "//input[@name='title']")] public IWebElement skillstitle;
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")] public IWebElement skillsdescription;
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")] public IWebElement Skillscategory;
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")] public IWebElement subcat;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add new tag']")] public IWebElement tags;
        [FindsBy(How = How.XPath, Using = "//label[text()='One-off service']//preceding::input[1]")] public IWebElement servicetype;
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType' and @value='1']")] public IWebElement locationType;
        [FindsBy(How = How.XPath, Using = "//input[@name='startDate']")] public IWebElement startdate;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")] public IWebElement enddate;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[4]")] public IWebElement avilabiltycheckbox;

        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[5]")] public IWebElement avilabiltystarttime;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[6]")] public IWebElement avilabiltyendtime;

        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[7]")] public IWebElement avilabiltycheckboxtue;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[8]")] public IWebElement avilabiltystarttimeontue;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[9]")] public IWebElement avilabiltyendtimeontue;

        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[10]")] public IWebElement avilabiltycheckboxonwed;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[11]")] public IWebElement avilabiltystarttimeonwed;
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[12]")] public IWebElement avilabiltyendtimeonwed;



        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='false']")] public IWebElement skillstrade;
        [FindsBy(How =How.XPath,Using = "//input[@placeholder='Amount']")] public IWebElement credit;
      
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='true']")] public IWebElement active;
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")] public IWebElement savebtn;

        //checking

        [FindsBy(How = How.XPath, Using = "//span[@class='item ui dropdown link']")] public IWebElement pro;

        [FindsBy(How = How.XPath, Using = "//a[text()='Go to Profile']")] public IWebElement gotoprofile;


        //verification
        [FindsBy(How = How.XPath, Using = "//button[text()='1']")] public IWebElement verfication;


        [FindsBy(How = How.XPath, Using = "//a[text()='Profile']")] public IWebElement proifle1;

        [FindsBy(How = How.XPath, Using = "//div[text()='lavanya vemulapalli']")] public IWebElement profileverification;

        [FindsBy(How = How.XPath, Using = "//td[text()='English']")] public IWebElement verifyinglanuage;
        [FindsBy(How = How.XPath, Using = "//td[text()='automation']")] public IWebElement verifyingskils;
        [FindsBy(How = How.XPath, Using = "//td[text()='JNTU']")] public IWebElement verifyingedu;

        [FindsBy(How = How.XPath, Using = "//td[text()='ISTQB/ANZTB']")] public IWebElement verifyingcertication;










        //drop down method for langauage selecting
        public void language(string value)
        {
            new SelectElement(langlevel).SelectByText(value);
        }

//drop down method for skills selecting
        public void skill(string value)
        {
            new SelectElement(skilllevel).SelectByText(value);
        }
 //drop down method for country selecting
        public void county(string value)
        {
            new SelectElement(countrychoose).SelectByText(value);
        }
 //drop down method for course title selecting
        public void title(string value)
        {
            new SelectElement(coursetitle).SelectByText(value);
        }
 //drop down method for year of graduation selecting
        public void year(string value)
        {
            new SelectElement(yearofgrad).SelectByText(value);
        }
 //drop down method for certification year selecting
        public void ceryear(string value)
        {
            new SelectElement(ceryr).SelectByText(value);
        }
//dropdown method for availabityType selecting
        public void avilabiltyType(string value)
        {
            new SelectElement(type).SelectByText(value);
        }
//dropdown method for availabityhours selecting
        public void avilabiltyhours(string value)
        {
            new SelectElement(hours).SelectByText(value);
        }

//dropdown method for earn target selection selecting
        public void earntarget(string value)
        {
            new SelectElement(target).SelectByText(value);
        }
 //dropdown method for category selecting
        public void category(string value)
        {
            new SelectElement(Skillscategory).SelectByText(value);
        }

 //dropdown method for subcategory selecting

        public void subcategory(string value)
        {
            new SelectElement(subcat).SelectByText(value);
        }

        //public  void  seldate(IWebDriver d,IWebElement element,string dateval)
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)d;
        //    js.ExecuteScript("arguments[0].setAttribute('value','" + dateval + "');", element);

        //}




        


    }


}
