using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI2Demo.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }
    }
}