using Microsoft.AspNetCore.Mvc; 
public class HomeController : Controller
{
    [RouteAttribute("")]
     public IActionResult Index()    
    {         
        return View();   
    }
    [RouteAttribute("index")]
    public IActionResult Quote()
    {
        return Ok("This is the index of HomePageQuoteController");
    }

}