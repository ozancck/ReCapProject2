using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
         {
             new Car {CarId=1, BrandId=1, ColorId=2, DailyPrice = 150000, Description="Fresh Car", ModelYear= 2002},
             new Car {CarId=2, BrandId=2, ColorId=2, DailyPrice = 160000, Description="Egüzel", ModelYear= 2003},
             new Car {CarId=3, BrandId=5, ColorId=5, DailyPrice = 1450000, Description="Fresh Car", ModelYear= 2005},
             new Car {CarId=4, BrandId=6, ColorId=5, DailyPrice = 190000, Description="Fresh Car", ModelYear= 2020},
             new Car {CarId=5, BrandId=7, ColorId=0, DailyPrice = 100000, Description="Fresh Car", ModelYear= 2021},
         };
            
        }






        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId== car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int brandId)
        {
            return _cars.Where(c => c.BrandId== brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
