using Microsoft.AspNetCore.Mvc; 
[Route("life")]
public class LifeController : Controller{

    
    public IActionResult Index()    
    {        
        return Ok("This is the index of the LifeController");    
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        return Ok("This is the index of LifeQuoteController");
    }

}