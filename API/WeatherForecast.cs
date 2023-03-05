namespace API;

public class WeatherForecast
{
	public DateOnly Date { get; set; }

	public int TemperatureC { get; set; }

	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

	public string[]? Cosas { get; set; }

	public string ListarCosas => Cosas switch
	{
		null => "No hay cosas",
		[var ONE] => string.Format("Una cosa: {}", ONE),
		[var ONE, _] => string.Format("Primera cosa: {}", ONE),
		[var ONE, .., var LAST] => string.Format("Primera cosa es {} y última es {}", ONE, LAST),
		var Cosas => string.Join(",", Cosas)
	};

	public string? Summary { get; set; }
}
