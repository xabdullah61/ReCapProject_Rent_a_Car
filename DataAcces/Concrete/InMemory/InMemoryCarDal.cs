using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=15,ModelYear=2004,DailyPrice=150,Description="Sol kaput çizik"},
                new Car{CarId=2,BrandId=1,ColorId=18,ModelYear=2007,DailyPrice=175,Description="Tampon yamuk"},
                new Car{CarId=3,BrandId=2,ColorId=12,ModelYear=2018,DailyPrice=275,Description="sağ arka kapı çizik"},
                new Car{CarId=4,BrandId=3,ColorId=27,ModelYear=2014,DailyPrice=185,Description="Temiz"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar;
            deletedCar = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

       

        public void Update(Car car)
        {
            Car UpdatedCar;
            UpdatedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            UpdatedCar.CarId = car.CarId;
            UpdatedCar.ColorId = car.ColorId;
            UpdatedCar.DailyPrice = car.DailyPrice;
            UpdatedCar.Description = car.Description;
            UpdatedCar.BrandId = car.BrandId;
            UpdatedCar.ModelYear = car.ModelYear;
            
        }

        Car ICarDal.GetById(int id)
        {
            Car selectedCar;
            selectedCar = _cars.SingleOrDefault(s => s.CarId == id);
            return selectedCar;
        }
    }
}
