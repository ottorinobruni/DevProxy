namespace DevProxy.WebApp.Services
{
    public interface IWeatherService
    {
        Task<List<WeatherForecast>> GetWeatherForecasts();
    }
}
