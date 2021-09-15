using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryProductDal(List<Car> cars)
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 2, ColorId = 3, DailyPrice = 20000, ModelYear = 1995, Description = "1995 Model Honda"},
                new Car{Id = 2, BrandId = 2, ColorId = 3, DailyPrice = 60000, ModelYear = 2006, Description = "2006 Model Honda"},
                new Car{Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 90000, ModelYear = 2012, Description = "2012 Model Honda"},
                new Car{Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 75000, ModelYear = 2007, Description = "2007 Model Mazda"},
                new Car{Id = 5, BrandId = 3, ColorId = 3, DailyPrice = 60000, ModelYear = 2006, Description = "2006 Model Mazda"},
                new Car{Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 200000, ModelYear = 2019, Description = "2019 Model Volvo"}            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.Description = entity.Description;
        }
    }
}
