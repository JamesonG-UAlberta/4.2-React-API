using System;

namespace ReactAPI_4Point2
{
    // In-class API practice:
    // Add a "Precipitation" string property to the WeatherForecast class.
    // Add a random generation of 5 precipitation descriptions to the API method (similar to the summaries).

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
