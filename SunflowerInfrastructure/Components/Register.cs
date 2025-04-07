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
        private const string GENDER_MALE_CSS = "#gender-male";
        private const string GENDER_FEMALE_CSS = "#gender-female";
        private const string FIRST_NAME_CSS = "#FirstName";
        private const string LAST_NAME_CSS = "#LastName";
        private const string EMAIL_CSS = "#Email";
        private const string PASSWORD_CSS = "#Password";
        private const string CONFIRM_PASSWORD_CSS = "#ConfirmPassword";
        private const string REGISTER_BUTTON_CSS = ".register-next-step-button";
        private const string REGISTRATION_RESULT_PAGE_CSS = ".registration-result-page";

        public Register(IWebDriver driver, IWebElement mainElement) : base(driver, mainElement) { }

        private IWebElement GenderMale => Driver.FindElement(By.CssSelector(GENDER_MALE_CSS));
        private IWebElement GenderFemale => Driver.FindElement(By.CssSelector(GENDER_FEMALE_CSS));
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
            new RadioInput(Driver, gender == Gender.Male ? GenderMale : GenderFemale).SetInput();           
        }
        public RegistrationResultPage ClickOnRegister()
        {
            RegisterButton.Click();
            return new RegistrationResultPage(Driver);
        }
    }
}
