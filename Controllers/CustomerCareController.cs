using Microsoft.AspNetCore.Mvc; 
[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()    
    {        
        return Ok("This is the index of the CustomerCareController");    
    }
[RouteAttribute("claims")]
        public IActionResult Quote()    
    {        
        return Ok("This is the index of the CustomerCareQuoteController");    
    }

}