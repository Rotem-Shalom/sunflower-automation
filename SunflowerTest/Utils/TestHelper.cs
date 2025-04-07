using SunflowerInfrastructure;
using SunflowerInfrastructure.Components;
using SunflowerInfrastructure.Enums;
using SunflowerInfrastructure.Utils.Enums;

namespace SunflowerTest.Utils
{
    public static class TestHelper
    {
        public static WebshopHomePage RegisterToWebshop(WebshopHomePage page, string email)
        {
            Register register = page
                .GetHeaderLinks
                .ClickOnRegister()
                .GetRegister;
            register.SetGender(Gender.Male);
            register.SetFirstName(Consts.RANDOM_STRING);
            register.SetLastName(Consts.RANDOM_STRING);
            register.SetEmail(email);
            register.SetPassword(Consts.RANDOM_PASSWORD);
            register.SetConfirmPassword(Consts.RANDOM_PASSWORD);
            return register.ClickOnRegister().ClickOnContinueButton();
        }

        public static string AddRandomProductToCart(WebshopHomePage page)
        {
            Product product = page.GetHeaderMenu.ClickOnOption().GetProductGrid.GetFirstProduct();
            product.ClickOnAddToCart();
            return product.GetProductName;
        }
    }
}
