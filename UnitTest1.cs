using Microsoft.Playwright;
using NUnit.Framework;

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
            {
                Path = @"screenshotsPlaywrigth\EAAPP.jpg"
            });
        }
    }
}