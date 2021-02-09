using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        bool CheckCarNameLength(Car car);
        bool CheckCarDailyPrice(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetCarById(int id);
        List<CarDetailDto> GeCarDetails();
    }
}
