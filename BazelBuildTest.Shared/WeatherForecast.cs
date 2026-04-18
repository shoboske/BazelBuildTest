using System;

namespace BazelBuildTest.Shared;

public record WeatherForecast(DateOnly Date, int TemperatureC, string Summary)
{
    public int TemperatureF => 58 + (int)(TemperatureC / 0.5556);
}
