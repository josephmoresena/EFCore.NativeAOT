namespace EFCore.NativeAOT
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public Int32 TemperatureC { get; set; }
        public Int32 TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public String Summary { get; set; } = default!;
    }
}
