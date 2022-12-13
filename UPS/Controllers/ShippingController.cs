using UPS.Models;
using Microsoft.AspNetCore.Mvc;

namespace UPS.Controllers
{
  public class ShippingController : Controller
  {
    [HttpGet("/shipping-cost")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/shipping")]
    public ActionResult ShippingForm()
    {
      return View();
    }

    [HttpPost("/shipping-cost")]
    public ActionResult Create(string width, string height, string length, string weight) 
    {
      int[] dimensions = { int.Parse(width), int.Parse(height), int.Parse(length) };
      Parcel package = new Parcel(dimensions, int.Parse(weight));
      return View("Index", package);
    }
  }
}