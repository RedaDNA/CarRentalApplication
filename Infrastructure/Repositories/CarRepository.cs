using CarRentalApplication.Core.Entities;
using CarRentalApplication.Core.Interfaces;
using CarRentalApplication.Infrastructure.Data;
using CarRentalApplication.Pages;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApplication.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarRentalContext _context;

        public CarRepository(CarRentalContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return _context.Cars.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void Update(Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }

        public void Delete(Car car)
        {
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }
    }
}
