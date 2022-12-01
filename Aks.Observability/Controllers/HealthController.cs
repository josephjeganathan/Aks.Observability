using Microsoft.AspNetCore.Mvc;

namespace Aks.Observability.Controllers;

[Route("[controller]")]
[ApiController]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHealth() => Ok(new { IsHealthy = true });
}