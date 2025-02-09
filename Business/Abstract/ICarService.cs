﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByBrandId(int brandId);
    }
}
