using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightLearning
{
    public class NUnitPlaywright : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "http://www.eaapp.somee.com");
        }

        [Test]
        public async Task Test1()
        {
            //Using Locators
            var linkLogin = Page.Locator(selector: "#loginLink");
            await linkLogin.ClickAsync();
            await Page.GotoAsync(url: "http://www.eaapp.somee.com");
            await Page.ClickAsync(selector: "#loginLink");
            await Page.FillAsync(selector: "#UserName", value: "admin");
            await Page.FillAsync(selector: "#Password", value: "password");
            //Using Locator with Page Locator Options
            var btnLogin = Page.Locator(selector: "input", new PageLocatorOptions { HasTextString = "Log in" });
            await btnLogin.ClickAsync();
            //await Page.ClickAsync(selector: "#loginIn");
            await Expect(Page.Locator(selector: "text='Log off'")).ToBeVisibleAsync();
        }
    }
}