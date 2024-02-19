using System.ComponentModel.DataAnnotations;

namespace WeatherForecastApp.Models
{
	public class SearchByCity
	{
		[Required(ErrorMessage = "Podaj prawidłową nazwę miasta!")]
		[Display(Name = "Nazwa Miasta")]
		[StringLength(30, MinimumLength = 2, ErrorMessage = "Ilość znaków powinna wynosić od 2 do 20!")]
		public string CityName { get; set; }
	}
}
