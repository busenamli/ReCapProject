using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //_ --> global değişken genelde bu şekilde isimlendirilir, naming commention

        //Başladığında ilk önce ürün listesini çağıracak
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 1975, DailyPrice = 1500, Description = "Siyah Renult"},
                new Car{CarId = 2, BrandId = 3, ColorId = 5, ModelYear = 2005, DailyPrice = 2500, Description = "Siyah Hyundai"},
                new Car{CarId = 3, BrandId = 3, ColorId = 4, ModelYear = 2010, DailyPrice = 7500, Description = "Siyah BMW"},
                new Car{CarId = 4, BrandId = 2, ColorId = 2, ModelYear = 1990, DailyPrice = 8500, Description = "Gri Renult"},
                new Car{CarId = 5, BrandId = 1, ColorId = 2, ModelYear = 2000, DailyPrice = 3500, Description = "Beyaz Şahin"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
