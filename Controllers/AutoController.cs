using Microsoft.AspNetCore.Mvc; 
using FisherInsurance.Models;
using System;

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
        Quote quote = new Quote {            
            Id = 345,            
            Product = "Auto Insurance",
            ExpireDate = DateTime.Now.AddDays(45),           
             Price = 45.00M        
        };
        return View(quote);
    }

}