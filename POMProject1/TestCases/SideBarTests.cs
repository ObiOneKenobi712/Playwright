using Microsoft.Playwright.NUnit;
using POMProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMProject1.TestCases
{
    public class SideBarTests : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "https://www.saucedemo.com/");
            LoginPage loginPage = new LoginPage(page: Page);
            await loginPage.Login("standard_user", "secret_sauce");
        }

        [Test]
        public async Task BtnAllItemsWorks()
        {
            SideBar sideBar = new SideBar(page: Page);
            await sideBar.ChceckBtnAllItems();
        }
        [Test]
        public async Task BtnResetAppStateWorks()
        {
            SideBar sideBar = new SideBar(page: Page);
            await sideBar.ChceckBtnResetAppState();

        }
        [Test]
        public async Task BtnAboutWorks()
        {
            SideBar sideBar = new SideBar(page: Page);
            await sideBar.ChceckBtnAbout();
            await sideBar.IsCurrentUrlDifferentBtnAbout();
        }
    }
}
