using Microsoft.AspNetCore.Mvc; 
using FisherInsurance.Models;

[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()    
    {        
        return Ok("This is the index of the CustomerController");    
    }
    [RouteAttribute("claims")]
    public IActionResult Quote()
    {
        return Ok("This is the index of CustomerClaimsController");
    }

}