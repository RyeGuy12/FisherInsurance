using Microsoft.AspNetCore.Mvc; 

[RouteAttribute("auto")]
public class AutoController : Controller
{
    [RouteAttribute("")]
    public IActionResult Index()    
    {           
        return View();
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        return Ok("This is the index of AutoQuoteController");
    }

}