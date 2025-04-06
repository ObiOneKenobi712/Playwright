using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using POMProject1.Pages;

namespace POMProject1.TestCases
{
    public class LoginTests : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "https://www.saucedemo.com/");
        }

        [Test]
        public async Task SuccessLogin()
        {
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("standard_user", "secret_sauce");
            bool shoppingCardVisible = await loginPage.IsIcnShoppingCardVisible();
            Assert.True(shoppingCardVisible);
        }
        [Test]
        public async Task UnSuccessLogin()
        {
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("nonExistingUser", "secret_sauce");
            bool shoppingCardVisible = await loginPage.IsIcnShoppingCardVisible();
            Assert.False(shoppingCardVisible);
        }
        [Test]
        public async Task WithoutPasswordLogin()
        {
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("standard_user", "");
            bool shoppingCardVisible = await loginPage.IsIcnShoppingCardVisible();
            Assert.False(shoppingCardVisible);
        }
        [Test]
        public async Task WhitePasswordLogin()
        {
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("standard_user", " ");
            bool shoppingCardVisible = await loginPage.IsIcnShoppingCardVisible();
            Assert.False(shoppingCardVisible);
        }
    }
}