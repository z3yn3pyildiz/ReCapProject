using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
   public class InMemoryCarDao : ICarDao
    {
        List<Car> _car;
        public InMemoryCarDao()
        {
            //burda listemize eleman ekliyoruz
            _car = new List<Car> { 
            new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=234,Description="Kia"},
             new Car{Id=21,BrandId=51,ColorId=51,ModelYear=2500,DailyPrice=234,Description="BMW"},
              new Car{Id=31,BrandId=51,ColorId=61,ModelYear=2070,DailyPrice=234,Description="hONDA"},
              new Car{Id=41,BrandId=21,ColorId=31,ModelYear=2090,DailyPrice=234,Description="AUDI"}
            };

        }
        public void Add(Car car)
        {
            _car.Add(car); //listeye car ekliyoruz
        }

        public void Delete(Car car)
        {
            Car deletCar = _car.SingleOrDefault(p=>p.Id==car.Id);
        }

        public List<Car> GetAll()
        {
            return _car; //elimdeki listyi dön
        }

        public Car GetById(int id)
        {
           
              return  (Car)_car.Where(p => p.Id == id);

           
           
        }

        public void Update(Car car)
        {
            Car updateCar = _car.SingleOrDefault(p => p.Id == car.Id);
            updateCar.ColorId = car.ColorId;
            updateCar.Description = car.Description;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.BrandId = car.BrandId;
            updateCar.ModelYear = car.ModelYear;
        }
    }
}
