using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
//Gives access to the Model classes in the Controller
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        public IActionResult Index(int luck) 
        {
            Random random = new Random();

            //Creates a new spin object from the Model class Spin
            Spin spin = new Spin
            {
                //TODO: assign properties Luck and Numbers, appropriate values in the constructor
                Luck = luck,
                Numbers = new int[] {random.Next(1,9), random.Next(1,9), random.Next(1,9)}
            };

            //TODO: Use the if-else to assign spin's ImageShown property a CSS display value (either "block" or "none")
            if (spin.Numbers is not null && Array.Exists(spin.Numbers, n => n == luck)) {
                spin.ImageDisplay = "block";
            }
            else {
                spin.ImageDisplay = "none";
            }
            
            return View( spin ); //Passes the spin object to the View as a parameter
        }
    }
}