using CarRentalApplication.Core.Entities;
using CarRentalApplication.Pages;

namespace CarRentalApplication.Core.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car GetById(Guid id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
