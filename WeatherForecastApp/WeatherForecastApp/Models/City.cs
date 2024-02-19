using System.ComponentModel.DataAnnotations;
namespace WeatherForecastApp.Models
{
	public class City
	{
		[Display(Name = "Miasto: ")]
		public string Name { get; set; }

		[Display(Name = "Temperatura: ")]
		public float Temperature { get; set; }

		[Display(Name = "Wilgotność: ")]
		public int Humidity { get; set; }

		[Display(Name = "Ciśnienie: ")]
		public int Pressure { get; set; }

		[Display(Name = "Prędkość wiatru: ")]
		public float Wind { get; set; }

		[Display(Name = "Warunki pogodowe: ")]
		public string Weather { get; set; }
	}
}
