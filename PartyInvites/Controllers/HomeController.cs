using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public ViewResult Register()
    {
        return View();
    }
    [HttpPost]
    public ViewResult Register(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            GuestRepository.AddGuest(guestResponse);
            return View("Message", guestResponse);
        }
        else
        {
            return View();
        }

    }
    public ViewResult Lists()
    {
        return View(GuestRepository.Responses.Where(guest => guest.WillAttend == true));
    }
}
