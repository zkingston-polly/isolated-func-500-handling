using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DIErrorTest
{
  public class Function
  {
    private readonly ILogger<Function> _logger;

    public Function(ILogger<Function> logger)
    {
      _logger = logger;
    }

    [Function("test")]
    public Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
      throw new OperationCanceledException("Oops.");
    }
  }
}
