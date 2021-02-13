using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.ColorId == id));
        }

        public IResult Add(Car car)
        {
            if (CheckCarNameLength(car))
            {
                if (CheckCarDailyPrice(car))
                {
                    _carDal.Add(car);
                    return new SuccessResult(Messages.CarAdded);
                }
                else
                {
                    return new ErrorResult(Messages.InvalidDailyPrice);
                }
            }
            else
            {
                return new ErrorResult(Messages.InvalidCarName);
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

        public IResult Update(Car car)
        {
            if (CheckCarNameLength(car))
            {
                if (CheckCarDailyPrice(car))
                {
                    _carDal.Update(car);
                    return new SuccessResult(Messages.CarUpdated);
                }

                return new ErrorResult(Messages.InvalidDailyPrice);
            }

            return new ErrorResult(Messages.InvalidCarName);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Car> GetCarById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}
