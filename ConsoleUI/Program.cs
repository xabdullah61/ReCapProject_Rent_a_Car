using Business.Concrete;
using DataAcces.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
                Console.WriteLine(car.CarId);
                Console.WriteLine("*******************");
            }

        }
    }
}
