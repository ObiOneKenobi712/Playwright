using Microsoft.Playwright.NUnit;
using POMProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMProject1.TestCases
{
    public class ShoppingCartTests :  PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "https://www.saucedemo.com/");
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("standard_user", "secret_sauce");
        }

        [Test]
        public async Task ItemAddedToShoppingCart()
        {
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(page:Page);
            await shoppingCartPage.IfItemAddedToShoppingCart();
        }




    }

}
