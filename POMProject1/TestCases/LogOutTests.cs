using Microsoft.Playwright.NUnit;
using POMProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMProject1.TestCases
{

    public class LogOutTests : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "https://www.saucedemo.com/");
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("standard_user", "secret_sauce");
        }

        [Test]
        public async Task SuccessLogOut()
        {
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.LogOut();
            bool loginButtonVisible = await loginPage.IsIcnLoginVisible();
            Assert.True(loginButtonVisible);
        }
    }
}