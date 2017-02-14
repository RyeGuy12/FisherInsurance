using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models; 
using System;

[Route("HomeInsurance")]
public class HomeController : Controller
{
    [RouteAttribute("")]
     public IActionResult Index()    
    {         
        return View();   
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        Quote quote = new Quote {            
            Id = 345,            
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),           
             Price = 45.00M        
        };
        return View(quote);
    }

}