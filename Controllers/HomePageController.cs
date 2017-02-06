using Microsoft.AspNetCore.Mvc; 
[Route("home")]
public class HomePageController : Controller{

    
    public IActionResult Index()    
    {        
        return Ok("This is the index of the HomePageController");    
    }
    [RouteAttribute("index")]
    public IActionResult Quote()
    {
        return Ok("This is the index of HomePageQuoteController");
    }

}