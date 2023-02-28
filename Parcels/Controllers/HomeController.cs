using Parcels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/form")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/updatedParcel")]
    public ActionResult UpdateParcel(int height, int width, int length, int weight )
    {
      Parcels myparcel = new Parcels(weight);
      myparcel





    }

  }
}