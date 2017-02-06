using Microsoft.AspNetCore.Mvc; 
[Route("auto")]
public class AutoController : Controller
{

    public IActionResult Index()    
    {        
        return Ok("This is the index of the AutoController");    
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        return Ok("This is the index of AutoQuoteController");
    }

}