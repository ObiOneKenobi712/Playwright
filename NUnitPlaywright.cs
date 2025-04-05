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
            await Page.GotoAsync(url: "http://www.eaapp.somee.com");
            await Page.ClickAsync(selector: "#loginLink");
            await Page.FillAsync(selector: "#UserName", value: "admin");
            await Page.FillAsync(selector: "#Password", value: "password");
            await Page.ClickAsync(selector: "#loginIn");
            await Expect(Page.Locator(selector: "text='Log off'")).ToBeVisibleAsync();
        }
    }
}