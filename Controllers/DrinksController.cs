using System;
using System.Collections.Generic;
using burger_shack.Models;
using Microsoft.AspNetCore.Mvc;

namespace burger_shack
{
    [Route("api/[controller]")]
    public class DrinksController : Controller
    {
        List<Drink> Drinks { get; set; } 
        public DrinksController()
        { 
            Drinks = new List<Drink>() 
            {
                new Drink("Whiskey Sour", "A gentlemans drink.", 5.68),
                new Drink("Bourdon on the Rocks", "Ready to Rock.", 5.50),
                new Drink("Uinta Baba", "Roasty and complex", 4.00),
                new Drink("Avery Raja", "A desire to be decadent.", 3.80),
                new Drink("Founders All Day IPA", "`Merica's drink", 3.50)
            };
        }

        [HttpGet]
        public IEnumerable<Drink> Get()
        {
            return Drinks;
        }

        [HttpGet("{id}")]
        public Drink Get(int id)
        {
            return id > -1 && id < Drinks.Count - 1 ? Drinks[id] : null;
        }

        [HttpPost]
        public IEnumerable<Drink>AddDrink([FromBody] Drink drink)
        {
            if (ModelState.IsValid)
            {
                Drinks.Add(drink);
            }
            return Drinks;
        }
    }
}