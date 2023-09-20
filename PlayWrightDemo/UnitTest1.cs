using Microsoft.Playwright;

namespace PlayWrightDemo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //Setting Up PlayWright
        //Assert.Pass();
        using var playwright = await Playwright.CreateAsync();
        //Launch Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync(url: "https://www.saucedemo.com/");
        await page.WaitForTimeoutAsync(2000);

    }
}