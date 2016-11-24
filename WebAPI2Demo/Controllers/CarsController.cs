using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2Demo.Models;

namespace WebAPI2Demo.Controllers
{
    /*
     * This controller has two methods for returning Car information.
     * GetAllCars() returns all cars
     * GetCar() returns a car by id 
     */
    public class CarsController : ApiController
    {
        Car[] cars = new Car[]
        {
            new Car {Id=1, Brand="Audi", Model="A4", Price=24000, ImageUrl="http://buyersguide.caranddriver.com/media/assets/submodel/7085.jpg"},
            new Car {Id=2, Brand="Audi", Model="A6", Price=29000, ImageUrl="http://www.autowiki.fi/images/3/30/Audi_A6_2.0_TDI_%28C7%29_%E2%80%93_Frontansicht.jpg"},
            new Car {Id=3, Brand="BMW", Model="320", Price=22000, ImageUrl=""},
            new Car {Id=4, Brand="Volvo", Model="V90", Price=47000, ImageUrl="http://student.labranet.jamk.fi/~salesa/mat/VolvoV90.PNG"}
        };

        public IEnumerable<Car> GetAllCars()
        {
            return cars;
        }

        public IHttpActionResult GetCar(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
    }
}
