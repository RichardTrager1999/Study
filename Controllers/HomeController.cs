using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Services;

namespace App.Controllers;

public class HomeController : Controller
{
    private readonly AddDataService adddataservice;

    public HomeController(AddDataService _adddataservive)
    {
        adddataservice = _adddataservive;
    }

    [HttpPost]
    public ActionResult AddDates([FromBody] TransferDataModel transferdata)
    {
        adddataservice.Add(transferdata);
        return Ok();
    }
    
}

