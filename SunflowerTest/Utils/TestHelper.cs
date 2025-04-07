using SunflowerInfrastructure;
using SunflowerInfrastructure.Components;
using SunflowerInfrastructure.Enums;
using SunflowerInfrastructure.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunflowerTest.Utils
{
    public static class TestHelper
    {
        public static WebshopPage RegisterToWebshop(WebshopPage page, string email)
        {
            Register register = page
                .GetHeaderLinks
                .ClickOnRegister()
                .GetRegister;
            register.SetGender(Gender.male);
            register.SetFirstName(Consts.RANDOM_STRING);
            register.SetLastName(Consts.RANDOM_STRING);
            register.SetEmail(email);
            register.SetPassword(Consts.RANDOM_PASSWORD);
            register.SetConfirmPassword(Consts.RANDOM_PASSWORD);
            return register.ClickOnRegister().ClickOnContinueButton();
        }

        public static string AddRandomProductToCart(WebshopPage page)
        {
            Product product = page.GetHeaderMenu.ClickOnOption(HeaderMenuOptions.DigitalDownloads).GetProductGrid.GetFirstProduct();
            product.ClickOnAddToCart();
            return product.GetProductName;
        }
    }
}
