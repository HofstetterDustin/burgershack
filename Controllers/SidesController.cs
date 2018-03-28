using System;
using System.Collections.Generic;
using burger_shack.Models;
using Microsoft.AspNetCore.Mvc;

namespace burger_shack
{
    [Route("api/[controller]")]
    public class SidesController : Controller
    {
        List<Side> Sides { get; set; }
        public SidesController()
        {
            Sides = new List<Side>() 
            {
                new Side("Frys","Yummy", 2.50, 800, "Idaho Potatoes Baby!"),
                new Side("Copenhagen","Spit-Ding", 1.00, 23, "Tobacky"),
                new Side("Tatter-Tots", "Ain't no f'in salad", 3.15, 600, "Little Spuds"),
                new Side("Sweet Baby Ray's Jerky", "Not For Dentures.", 6.85, 451, "Beef"),
                new Side("Sweet Balsamic Roasted Baby Carrots", "Hipster Food.", 4.36, 120, "Carrots, Duh!")
            };
        }
        
        [HttpGet]
        public IEnumerable<Side> GetSide()
        {
            return Sides;
        }

        [HttpGet("{id}")]
        public Sides GetSides(int id)
        {
            return id > -1 && id < Sides.Count - 1 ? Sides[id] : null;
        }

        [HttpPost]
        public IEnumerable<Sides> AddSide([FromBody]Sides sides)
        {
            if (ModelState.IsValid)
            {
                Sides.Add(side);
            }
            return Sides;
        }

    }
}