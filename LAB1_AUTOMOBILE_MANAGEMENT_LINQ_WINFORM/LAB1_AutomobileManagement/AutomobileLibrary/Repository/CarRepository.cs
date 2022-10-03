using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void deleteCar(int carId) => CarDBContext.Instance.Remove(carId);

        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarById(carID);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;

        public void insertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void updateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
