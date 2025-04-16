using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test
{
    public class TestsPO : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "https://www.selenium.dev/selenium/web/web-form.html");
        }

        [Test]
        public async Task ClickCheckbox()
        {
            POMPage pomPage = new POMPage(page: Page);
            await pomPage.CheckRadioButton();
        }

        [Test]
        public async Task ClickDefaultbox()
        {
            POMPage pomPage = new POMPage(page: Page);
            await pomPage.DefaultRadioButton();
        }
        //[Test]
        //public async Task ClickSubmitbox()
        //{
        //    POMPage pomPage = new POMPage(page: Page);
        //    await pomPage.CklickSubmitButton();

        //}

        [Test]
        public async Task ClickSubmiDropdownList()
        {
            POMPage pomPage = new POMPage(page: Page);
            await pomPage.SelectDropdownList(DropdownList.Three);
            await Expect(Page.Locator("body > main > div > form > div > div:nth-child(2) > label:nth-child(1) > select")).ToContainTextAsync("Three");

        }

        //bool shoppingCardVisible = await loginPage.IsIcnShoppingCardVisible();
        //Assert.False(shoppingCardVisible);
    }
}

