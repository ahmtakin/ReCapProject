using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,DailyPrice=150000,ModelYear=2005,ColorId=1,Description="Volkswagen Passat Siyah"},
                new Car{Id=2,BrandId=1,DailyPrice=350000,ModelYear=2020,ColorId=2,Description="Volkswagen Golf Beyaz"},
                new Car{Id=3,BrandId=2,DailyPrice=40000,ModelYear=2006,ColorId=2,Description="Peugeot 206 Beyaz"},
                new Car{Id=4,BrandId=2,DailyPrice=30000,ModelYear=2004,ColorId=3,Description="Peugeot 205 Gri"},
                new Car{Id=5,BrandId=3,DailyPrice=120000,ModelYear=2010,ColorId=4,Description="Ford Fiesta Kırmızı"},
                new Car{Id=6,BrandId=3,DailyPrice=250000,ModelYear=2016,ColorId=5,Description="Ford Focus Mavi"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
