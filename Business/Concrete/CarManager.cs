﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCars()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(car => car.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(car => car.ColorId == id);
        }

        public void Add(Car car)
        {
            if (CheckCarNameLength(car) && CheckCarDailyPrice(car))
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba eklenmedi! Araba ismi en az 2 karakter olmalıdır ve günlük fiyatı 0'dan büyük olmalıdır!");
            }

        }

        public bool CheckCarNameLength(Car car)
        {
            if (car.Description.Length >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckCarDailyPrice(Car car)
        {
            if (car.DailyPrice > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
