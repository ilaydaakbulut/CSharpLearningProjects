using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car> {
                new Car { Id = 1, BrandId = 5, ColorId = 1, DailyPrice = 150, Description = "", ModelYear = 2018 },
                new Car { Id = 2, BrandId = 4, ColorId = 1, DailyPrice = 200, Description = "", ModelYear = 2020 },
                new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 125, Description = "", ModelYear = 2017 },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 175, Description = "", ModelYear = 2019 },
                new Car { Id = 5, BrandId = 1, ColorId = 3, DailyPrice = 160, Description = "", ModelYear = 2019 }, };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int Id)
        {
            return cars.Where(Car => Car.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
