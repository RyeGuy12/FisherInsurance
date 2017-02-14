using Microsoft.AspNetCore.Mvc; 
[Route("life")]
public class LifeController : Controller
{    
    [RouteAttribute("")]
    public IActionResult Index()    
    {        
        //return Ok("This is the index of the HomePageController");    
        return View();
    }
    [RouteAttribute("index")]
    public IActionResult Quote()
    {
        return Ok("This is the index of HomePageQuoteController");
    }

}