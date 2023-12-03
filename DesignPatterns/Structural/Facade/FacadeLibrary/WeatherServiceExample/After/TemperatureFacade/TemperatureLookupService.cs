using FacadeLibrary.WeatherServiceExample.Service;

namespace FacadeLibrary.WeatherServiceExample.After.TemperatureFacade;

public class TemperatureLookupService
{
    private readonly WeatherService weatherService;
    private readonly GeoLookupService geoLookupService;
    private readonly TemperatureConverter temperatureConverter;
    
    public TemperatureLookupService(
        WeatherService weatherService,
        GeoLookupService geoLookupService,
        TemperatureConverter englishMetricConverter)
    {
        this.weatherService = weatherService;
        this.geoLookupService = geoLookupService;
        temperatureConverter = englishMetricConverter;
    }
    
    public TemperatureLookupService()
        : this(new WeatherService(), new GeoLookupService(), new TemperatureConverter())
    {
    }
    
    public LocalTemperature GetTemperature(string zipCode)
    {
        var city = geoLookupService.FindCity(zipCode);
        var state = geoLookupService.FindState(zipCode);
        var coords = geoLookupService.FindCoordinates(zipCode);

        var fahrenheitDegrees = weatherService.GetTemperatureFahrenheit(coords.Latitude, coords.Longitude);
        var celsiusDegrees = temperatureConverter.ConvertFahrenheitToCelsius(fahrenheitDegrees);

        return new LocalTemperature
        {
            Fahrenheit = fahrenheitDegrees,
            Celsius = celsiusDegrees,
            City = city,
            State = state,
        };
    }
}