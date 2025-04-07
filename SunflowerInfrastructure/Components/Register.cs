using OpenQA.Selenium;
using SunflowerInfrastructure.Inputs;
using SunflowerInfrastructure.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerInfrastructure.Components
{
    public class Register : ElementUser
    {
        private string GENDER_MAIL_CSS = "#gender-male";
        private string GENDER_FEMAIL_CSS = "#gender-female";
        private string FIRST_NAME_CSS = "#FirstName";
        private string LAST_NAME_CSS = "#LastName";
        private string EMAIL_CSS = "#Email";
        private string PASSWORD_CSS = "#Password";
        private string CONFIRM_PASSWORD_CSS = "#ConfirmPassword";
        private string REGISTER_BUTTON_CSS = ".register-next-step-button";
        private string REGISTRATION_RESULT_PAGE_CSS = ".registration-result-page";

        public Register(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private IWebElement GenderMale => Driver.FindElement(By.CssSelector(GENDER_MAIL_CSS));
        private IWebElement GenderFemale => Driver.FindElement(By.CssSelector(GENDER_FEMAIL_CSS));
        private IWebElement FirstName => Driver.FindElement(By.CssSelector(FIRST_NAME_CSS));
        private IWebElement LastName => Driver.FindElement(By.CssSelector(LAST_NAME_CSS));
        private IWebElement Email => Driver.FindElement(By.CssSelector(EMAIL_CSS));
        private IWebElement Password => Driver.FindElement(By.CssSelector(PASSWORD_CSS));
        private IWebElement ConfirmPassword => Driver.FindElement(By.CssSelector(CONFIRM_PASSWORD_CSS));
        private IWebElement RegisterButton => Driver.FindElement(By.CssSelector(REGISTER_BUTTON_CSS));

        public void SetFirstName(string firstName) => new SingleLineInput(Driver, FirstName).SetInput(firstName);
        public void SetLastName(string lastName) => new SingleLineInput(Driver, LastName).SetInput(lastName);
        public void SetEmail(string email) => new SingleLineInput(Driver, Email).SetInput(email);
        public void SetPassword(string password) => new SingleLineInput(Driver, Password).SetInput(password);
        public void SetConfirmPassword(string confirnPassword) => new SingleLineInput(Driver, ConfirmPassword).SetInput(confirnPassword);
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
        public RegistrationResultPage ClickOnRegister()
        {
            RegisterButton.Click();
            return new RegistrationResultPage(Driver);
        }

    }
}
