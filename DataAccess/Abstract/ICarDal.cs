using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        public void Add(Car car);
        public void Delete(Car car);
        public List<Car> GetAll();
        public List<Car> GetById(int Id);
        public void Update(Car car);
    }
}
