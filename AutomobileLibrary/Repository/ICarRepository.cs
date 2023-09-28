using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carID);
        void InsertCar(Car car);
        void DeleteCar(Car car);
        void UpdateCar(Car car);
    }
}
