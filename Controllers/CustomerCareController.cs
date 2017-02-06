using Microsoft.AspNetCore.Mvc; 
[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()    
    {        
        return Ok("This is the index of the CustomerCareController");    
    }
    [RouteAttribute("claim")]
        public IActionResult Quote()    
    {        
        return Ok("This is the index of the CustomerCareQuoteController");    
    }
    [RouteAttribute("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This abides to the naming convention while maintaing the desired route.");
    }
    [RouteAttribute("claimstatus")]
    public IActionResult ClaimHistory()
    {
        return Ok("The naming convention is ClaimHistory but the route is myclaims");
    }

}