using Microsoft.AspNetCore.Mvc; 
using FisherInsurance.Models;
using System;

[Route("life")]
public class LifeController : Controller
{    
    [RouteAttribute("")]
    public IActionResult Index()    
    {        
        //return Ok("This is the index of the HomePageController");    
        return View();
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        Quote quote = new Quote {            
            Id = 345,            
            Product = "Life Insurance",
            ExpireDate = DateTime.Now.AddDays(45),           
             Price = 45.00M        
        };
        return View(quote);
    }

}