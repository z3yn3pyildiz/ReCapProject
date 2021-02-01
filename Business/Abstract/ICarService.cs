using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
        public Car GetById(int id);
    }
}
