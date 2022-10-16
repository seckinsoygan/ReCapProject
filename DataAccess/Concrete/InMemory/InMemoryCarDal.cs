using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car { Id = 1, BrandId = 1, ColorId = 2, ModelYear = 2020, DailyPrice = 100000, Description = "Fiat Linea" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2021, DailyPrice = 300000, Description = "BMW" },
                new Car { Id = 3, BrandId = 2, ColorId = 1, ModelYear = 2022, DailyPrice = 200000, Description = "AUDI" }
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _car;
        }
        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
