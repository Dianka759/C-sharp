using Microsoft.AspNetCore.Mvc;
namespace FirstWeb.Controllers;

public class HomeController : Controller
{
    // ROUTING!!
    [HttpGet]
    [Route("/")]
    public ViewResult Index()
    {
        // ViewBag allows us to pass data from our controller to our view
        // think of a viewbag as a dictionary, it has keys and values
        ViewBag.Name = "Saki-chan";
        ViewBag.Number = 7;
        return View("Index");
    }

    // localhost:5XX/user/more
    [HttpGet("user/more")]
    public ViewResult AUser()
    {
        ViewBag.Name = "kiwi-chan";
        return View("User");
    }

    [HttpGet("user/{id}")]
    public string OneUser(int id)
    {
        return $"This is user {id}";
    }
}