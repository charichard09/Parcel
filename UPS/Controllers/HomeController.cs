using UPS.Models;
using Microsoft.AspNetCore.Mvc;

namespace UPS.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}