using Domain;

namespace Flowww.WebApi.Features.Number;

public static class GetEndpoint
{
    public static WebApplication MapGetNumberEndpoint(this WebApplication app)
    {
        app.MapGet("api/numbers/{number:int}/prime", GetIsPrimeNumber);
        return app;
    }

    public class GetPrimeNumberResponseDTO
    {
        public bool IsPrime { get; set; }
    }

    private static GetPrimeNumberResponseDTO GetIsPrimeNumber(int number)
    {
        bool result = NumberProperties.IsPrime(number);

        return new GetPrimeNumberResponseDTO
        {
            IsPrime = result,
        };
    }
}
