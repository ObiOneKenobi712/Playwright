using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightLearning.Pages;

namespace PlaywrightLearning
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            //Playwright 
            using var playwrigt = await Playwright.CreateAsync();
            //Browser
            await using var browser = await playwrigt.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            //Page
            var page = await browser.NewPageAsync();
            await page.GotoAsync(url: "http://www.eaapp.somee.com");
            await page.ClickAsync(selector: "#loginLink");
            await page.ScreenshotAsync(new PageScreenshotOptions
                //todo
            {
                Path = @"screenshotsPlaywrigth\EAAPP.jpg"
            });
            await page.FillAsync(selector: "#UserName", value: "admin");
            await page.FillAsync(selector: "#Password", value: "password");
            await page.ClickAsync(selector: "#loginIn");
            var isExist = await page.Locator(selector: "text='Log off'").IsVisibleAsync();
            Assert.IsTrue(isExist);
            Assert.IsTrue(isExist);
            Assert.IsTrue(isExist);
        }

        [Test]
        public async Task TestWithPOM()
        {
            //Playwright 
            using var playwrigt = await Playwright.CreateAsync();
            //Browser
            await using var browser = await playwrigt.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            //Page
            var page = await browser.NewPageAsync();
            await page.GotoAsync(url: "http://www.eaapp.somee.com");
           
            LoginPage loginPage = new LoginPage(page);
            await loginPage.ClickLogin();
            await loginPage.Login(userName: "admin", password: "password");
            var isExist = await page.Locator(selector: "text='Log off'").IsVisibleAsync();
            Assert.IsTrue(isExist);
        }

        //[Test]
        //public async Task WaitTest()
        //{
        //    //Playwright 
        //    using var playwrigt = await Playwright.CreateAsync();
        //    //Browser
        //    await using var browser = await playwrigt.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        //    {
        //        Headless = false
        //    });
        //    var context = await browser.NewContextAsync();
        //    var page = await browser.NewPageAsync();
        //    await page.GotoAsync(url: "https://demos.telerik.com/kendo-ui/window/index");
        //    await page.GetByRole(AriaRole.Button, new() { Name = "Close", Exact = true }).ClickAsync();
        //    await page.GetByRole(AriaRole.Button, new() { Name = "Close", Exact = true }).ClickAsync();
        //}
    }
}