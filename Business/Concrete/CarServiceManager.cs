using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarServiceManager : ICarService
    {
        ICarDao _icarDao;
        public CarServiceManager(ICarDao carDao)
        {
            _icarDao = carDao;
        }

        public void Add(Car car)
        {
            _icarDao.Add(car);
        }

        public void Delete(Car car)
        {
            _icarDao.Delete(car);

        }

        public List<Car> GetAll()
        {
            return _icarDao.GetAll();
        }

        public Car GetById(int id)
        {
           return _icarDao.GetById(id);
        }

        public void Update(Car car)
        {
            _icarDao.Update(car);
        }
    }
}
