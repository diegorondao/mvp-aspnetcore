using Microsoft.AspNetCore.Mvc;

namespace school_estrutura.src.Infrastructure.Controllers;
public class Ping : Controller
{
    public IActionResult Index()
    {
        return this.Ok(DateTime.Now);
    }
}