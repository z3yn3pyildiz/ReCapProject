using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public  interface ICarDao
    {
        public Car GetById(int id);
        public List<Car> GetAll();
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);

    }
}
