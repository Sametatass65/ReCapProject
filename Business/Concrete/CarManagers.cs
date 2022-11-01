﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManagers : ICarService
    {
        ICarDal _carDal;
        public CarManagers(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDto> GetAllCarDto()
        {
            return _carDal.getCarDto();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
