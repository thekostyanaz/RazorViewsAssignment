using Microsoft.AspNetCore.Mvc;
using RazorViewsAssignment.Models;

namespace RazorViewsAssignment.Controllers
{
	public class WeatherController : Controller
	{
		[Route("/")]
		public IActionResult Weather()
		{
			var weatherData = new List<CityWeather>
			{
				new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00:00 AM"),  TemperatureFahrenheit = 33 },
				new CityWeather() { CityUniqueCode = "NYC", CityName = "New York City", DateAndTime = Convert.ToDateTime("2030-01-01 3:00:00 AM"),  TemperatureFahrenheit = 60 },
				new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00:00 AM"),  TemperatureFahrenheit = 82 }
			};
			return View(weatherData);
		}

		[Route("/weather/{cityCode}")]
		public IActionResult City(string cityCode) 
		{
			var weatherData = new List<CityWeather>
			{
				new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00 AM"),  TemperatureFahrenheit = 33 },
				new CityWeather() { CityUniqueCode = "NYC", CityName = "New York City", DateAndTime = Convert.ToDateTime("2030-01-01 3:00 AM"),  TemperatureFahrenheit = 60 },
				new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00 AM"),  TemperatureFahrenheit = 82 }
			};

			var city = weatherData.FirstOrDefault(w => w.CityUniqueCode == cityCode);
			if (city != default) 
			{
				return View(city);
			}
			return View("Error", cityCode);
		}
	}
}
