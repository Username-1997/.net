using Microsoft.Playwright;

using NUnit.Framework;

using System.Reflection;
using System.Text.RegularExpressions;

[assembly:Parallelizable(ParallelScope.All)]
namespace playwright
{
	public class test
	{
		[SetUp]
		public void SetUp()
		{
		}
		[Test]
		public async Task Test1()
		{
			using var playwright = await Playwright.CreateAsync();
			await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
			{
				Headless = false
			}
					); ;

			var context = await browser.NewContextAsync();

			var page = await context.NewPageAsync();

			page.Console += (_, e) =>
			{
				Console.WriteLine($"Console {e.Type}: {e.Text}");
			};

			//var page = await browser.NewPageAsync();
			await page.GotoAsync(url: "https://www.youtube.com");
			//await page.FillAsync(selector:"#Search", value:"admin");
			await page.GetByPlaceholder("Search").FillAsync("thrissur");
			//await page.GetByPlaceholder("Password").FillAsync("Password");
			await page.HoverAsync(selector: "#search-icon-legacy > yt-icon > yt-icon-shape > icon-shape > div");
			await page.ClickAsync(selector: "#search-icon-legacy > yt-icon > yt-icon-shape > icon-shape > div");

			//await page.FillAsync(selector: "#", value: "admin");
			//await page.FillAsync(selector: "#email", value: "username");
			//await page.FillAsync(selector: "#pass", value: "Password");
			//await page.GetByTestId("royal_login_button").ClickAsync();
			//await page.HoverAsync(selector: "#u_0_5_\\+b");
			//await page.Locator("//*[@id=\"u_0_5_+b\"]").ClickAsync();

			//var selector = $"button[aria-label='Search']";
			//var button = await page.QuerySelectorAsync(selector);
			//await button.HoverAsync();
			//await button.ClickAsync();

			//await page.GetByTestId("search-icon-legacy").ClickAsync();

			await Task.Delay(5000);
			//await page.Locator("//*[@id=\"video-title\"]").ClickAsync();

			//await page.WaitForSelectorAsync("ytd-video-renderer");


			//var videoTitle = "⭕️ THRISSUR 15 FOOD SPOTS IN 1 MIN ⭕️ | Delicious Kerala #shorts"; // Replace with the actual video title
			//var videoSelector = $"ytd-video-renderer a#video-title[title='{videoTitle}']";

			//await page.ClickAsync(videoSelector);

			await Task.Delay(5000);
			await page.ScreenshotAsync(new PageScreenshotOptions
			{
				Path = "D:\\Learning\\playwright concepts\\screenshot.png"
			});

		}




		public class test2
		{
			[SetUp]
			public void SetUp()
			{
			}
			[Test]

			public async Task Test2()
			{
				using var playwright = await Playwright.CreateAsync();
				await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
				{
					Headless = false
				}
						); ;
				var page = await browser.NewPageAsync();
				await page.GotoAsync(url: "https://www.youtube.com");
				//await page.FillAsync(selector:"#Search", value:"admin");
				await page.GetByPlaceholder("Search").FillAsync("thrissur");
				//await page.GetByPlaceholder("Password").FillAsync("Password");
				await page.HoverAsync(selector: "#search-icon-legacy > yt-icon > yt-icon-shape > icon-shape > div");
				await page.ClickAsync(selector: "#search-icon-legacy > yt-icon > yt-icon-shape > icon-shape > div");

				

				await Task.Delay(5000);
				

				await Task.Delay(5000);
				await page.ScreenshotAsync(new PageScreenshotOptions
				{
					Path = "D:\\Learning\\playwright concepts\\screenshot.png"
				});

			}

		}

	}
}
