using OpenQA.Selenium;
using SunflowerInfrastructure.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure
{
    public class RegisterationPage : ElementUser
    {
        private string GENDER_MAIL_CSS = "#gender-male";
        private string GENDER_FEMAIL_CSS = "#gender-female";
        private string FIRST_NAME_CSS = "#FirstName";
        private string LAST_NAME_CSS = "#LastName";
        private string EMAIL_CSS = "#Email";
        private string PASSWORD_CSS = "#Password";
        private string CONFIRM_PASSWORD_CSS = "#ConfirmPassword";
        private string REGISTER_BUTTON_CSS = ".register-next-step-button";
        private string REGISTERATION_RESULT_PAGE_CSS = ".registration-result-page";

        public RegisterationPage(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private IWebElement GenderMale => MainElenent.FindElement(By.CssSelector(GENDER_MAIL_CSS));
        private IWebElement GenderFemale => MainElenent.FindElement(By.CssSelector(GENDER_FEMAIL_CSS));
        private IWebElement FirstName => MainElenent.FindElement(By.CssSelector(FIRST_NAME_CSS));
        private IWebElement LastName => MainElenent.FindElement(By.CssSelector(LAST_NAME_CSS));
        private IWebElement Email => MainElenent.FindElement(By.CssSelector(EMAIL_CSS));
        private IWebElement Password => MainElenent.FindElement(By.CssSelector(PASSWORD_CSS));
        private IWebElement ConfirmPassword => MainElenent.FindElement(By.CssSelector(CONFIRM_PASSWORD_CSS));
        private IWebElement RegisterButton => MainElenent.FindElement(By.CssSelector(REGISTER_BUTTON_CSS));
        private IWebElement RegisterationResultPage => Driver.FindElement(By.CssSelector(REGISTERATION_RESULT_PAGE_CSS));

        public void SetGender(Gender gender)
        {
            if (gender == Gender.male)
            {
                new RadioInput(Driver, GenderMale)
                .SetInput();
            }
            else
            {
                new RadioInput(Driver, GenderFemale)
                .SetInput();
            }
        }

        public void SetFirstName(string firstName) 
        { 
            new SingleLineInput(Driver, FirstName)
                .SetInput(firstName);
        }

        public void SetLastName(string lastName)
        {
            new SingleLineInput(Driver, LastName)
                .SetInput(lastName);
        }

        public void SetEmail(string email)
        {
            new SingleLineInput(Driver, Email)
                .SetInput(email);
        }

        public void SetPassword(string password)
        {
            new SingleLineInput(Driver, Password)
                .SetInput(password);
        }

        public void SetConfirmPassword(string confirnPassword)
        {
            new SingleLineInput(Driver, ConfirmPassword)
                .SetInput(confirnPassword);
        }

        public RegisterationResultPage ClickOnRegister()
        {
            RegisterButton.Click();
            return new RegisterationResultPage(Driver, RegisterationResultPage);
        }
    }
}
