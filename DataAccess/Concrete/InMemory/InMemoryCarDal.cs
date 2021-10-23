using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car{ Id=1,ColorId=1,BrandId=1,DailyPrice=250,ModelYear=2012,Description="Sıfır"},
                new Car{ Id=2,ColorId=2,BrandId=2,DailyPrice=500,ModelYear=2020,Description="2. El"},
                new Car{ Id=3,ColorId=3,BrandId=3,DailyPrice=300,ModelYear=2018,Description="Sıfır"},
                new Car{ Id=4,ColorId=1,BrandId=4,DailyPrice=400,ModelYear=2015,Description="2. El"},
                new Car{ Id=5,ColorId=3,BrandId=5,DailyPrice=300,ModelYear=2007,Description="Sıfır"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
