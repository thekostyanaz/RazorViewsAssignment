using Microsoft.AspNetCore.Mvc;
using RazorViewsAssignment.Models;

namespace RazorViewsAssignment.ViewComponents
{
	public class CityViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(CityWeather weatherInCity) 
		{
			return View(weatherInCity);
		}
	}
}
