using Microsoft.Playwright;

using NUnit.Framework;

using System.Text.RegularExpressions;

namespace PlaywrightExample2
{
	[TestFixture]
	public class PlaywrightTest2
	{
		private IPlaywright _playwright;
		private IBrowser _browser;

		[SetUp]
		public async Task SetUpAsync()
		{
			_playwright = await Playwright.CreateAsync();
			_browser = await _playwright.Chromium.LaunchAsync();
		}

		[TearDown]
		public async Task TearDownAsync()
		{
			await _browser.CloseAsync();
			_playwright.Dispose(); // Correctly disposing the Playwright instance
		}

		[Test]
		public async Task OpenYouTubeAndAssertTitle()
		{
			var page = await _browser.NewPageAsync();
			var waitForRequestTask = page.WaitForRequestAsync("**/*logo*.png");
			await page.GotoAsync("https://wikipedia.org");
			var request = await waitForRequestTask;
			Console.WriteLine(request.Url);
		}
	}
}

