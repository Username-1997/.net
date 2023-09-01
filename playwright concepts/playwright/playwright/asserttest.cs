using Microsoft.Playwright;

using NUnit.Framework;

using System.Text.RegularExpressions;

namespace PlaywrightExample
{
	[TestFixture]
	public class PlaywrightTest
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
			await page.GotoAsync("https://www.youtube.com");

			var title = await page.TitleAsync();
			Assert.AreEqual("YouTube", title, "Page title is incorrect");
			
			


			await page.CloseAsync();
		}
	}
}

