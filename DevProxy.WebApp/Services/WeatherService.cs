namespace DevProxy.WebApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<WeatherForecast>> GetWeatherForecasts()
        {
            var response = await _httpClient.GetAsync("https://63c1fbdc-2ba0-4d91-bb2a-7c130c1d5836.mock.pstmn.io/weatherforecast");
            response.EnsureSuccessStatusCode();
            var forecasts = await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecast>>();
            return forecasts?.ToList()!;
        }
    }
}
