﻿using Microsoft.AspNetCore.Mvc;
using PartyInvites_v2.Models;

namespace PartyInvites_v2 
{
    public class HomeController : Controller
    {
        public IActionResult index() 
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() 
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}