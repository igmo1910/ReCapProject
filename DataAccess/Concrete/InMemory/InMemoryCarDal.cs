using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2011", DailyPrice = 135000, Description = "Muayyer Mitsubishi L200 4*4"
                },
                new Car()
                {
                    Id = 2, BrandId = 1, ColorId = 2, ModelYear = "2013", DailyPrice = 175000, Description = "Hatasız Mitsubishi Lancer"
                },
                new Car()
                {
                    Id = 3, BrandId = 2, ColorId = 2, ModelYear = "2014", DailyPrice = 155000,
                    Description = "Meraklısına Vosvos"
                },
                new Car()
                {
                    Id = 4, BrandId = 2, ColorId = 3, ModelYear = "2011", DailyPrice = 115000,
                    Description = "Pazarlıksız Volkswagen Passat!"
                },
                new Car()
                {
                    Id = 5, BrandId = 3, ColorId = 4, ModelYear = "2019", DailyPrice = 335000, Description = "Emsalsiz Audi A6 Quatro"
                }
            };
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}
