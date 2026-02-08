using Microsoft.AspNetCore.Http.HttpResults;
using Muddaker.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace Muddaker.Web.Endpoints;

public class WeatherForecasts : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.RequireAuthorization();

        groupBuilder.MapGet(GetWeatherForecasts);
    }

    public async Task<Ok<IEnumerable<WeatherForecast>>> GetWeatherForecasts(ISender sender)
    {
        var forecasts = await sender.Send(new GetWeatherForecastsQuery());

        return TypedResults.Ok(forecasts);
    }

}
