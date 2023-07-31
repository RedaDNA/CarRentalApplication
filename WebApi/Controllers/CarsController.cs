using CarRentalApplication.Core.DTOs;
using CarRentalApplication.Core.Entities;
using CarRentalApplication.Core.Interfaces;
using CarRentalApplication.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApplication.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly CarService _service;

        public CarController(CarService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = _service.
                GetAllCars().Select(c => new CarDTO
            {
                Id = c.Id,
                CarNumber = c.CarNumber,
                Type = c.Type,
                EngineCapacity = c.EngineCapacity,
                Color = c.Color,
                DailyFare = c.DailyFare,
              
             
            });
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var car = _service.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            var carDTO = new CarDTO
            {
                Id = car.Id,
                CarNumber = car.CarNumber,
                Type = car.Type,
                EngineCapacity = car.EngineCapacity,
                Color = car.Color,
                DailyFare = car.DailyFare,
               
                
            };
            return Ok(carDTO);
        }

        [HttpPost]
        public IActionResult Create(CarDTO carDTO)
        {
            var car = new Car
            {
                CarNumber = carDTO.CarNumber,
                Type = carDTO.Type,
                EngineCapacity = carDTO.EngineCapacity,
                Color = carDTO.Color,
                DailyFare = carDTO.DailyFare,
               
                DriverId = carDTO.DriverId
            };
            _service.AddCar(car);
            return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CarDTO carDTO)
        {
            var car = _service.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            car.CarNumber = carDTO.CarNumber;
            car.Type = carDTO.Type;
            car.EngineCapacity = carDTO.EngineCapacity;
            car.Color = carDTO.Color;
            car.DailyFare = carDTO.DailyFare;
        
            _service.UpdateCar(car);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var car = _service.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            _service.DeleteCar(car);
            return NoContent();
        }
        public IActionResult Index()
        {
            var cars = _service.GetAllCars().Select(c => new CarDTO
            {
                Id = c.Id,
                CarNumber = c.CarNumber,
                Type = c.Type,
                EngineCapacity = c.EngineCapacity,
                Color = c.Color,
                DailyFare = c.DailyFare,
                
            }).ToList();
            var viewModel = new CarIndexViewModel
            {
                Cars = cars
            };
            return View(viewModel);
        }

       
    }
}


