using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _ıCarDal;

        public CarManager(ICarDal carDal)
        {
            _ıCarDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _ıCarDal.GetAll();
        }
    }
}
