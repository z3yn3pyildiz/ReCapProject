using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Api
{
    class Program
    {
        static void Main(string[] args)
        {
            CarServiceManager carServiceManager = new CarServiceManager(new InMemoryCarDao());
            foreach (var item in carServiceManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            
        }
    }
}
