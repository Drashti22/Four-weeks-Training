namespace VehicleManagementSystem
{
    internal class Program
    {
        public interface IVehicle
        {
            void Drive();
        }
        class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Driving a car.");
            }
        }

        class Truck : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Driving a truck.");
            }
        }
        public sealed class VehicleLogger
        {
            void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
        public abstract class VehicleFactory
        {
            public abstract IVehicle CreateVehicle();
            public void DoSomethingWithVehicle()
            {
                IVehicle vehicle = CreateVehicle();
                vehicle.Drive();
            }
            public class CarFactory : VehicleFactory
            {
                public override IVehicle CreateVehicle()
                {
                    return new Car();
                }
            }
            public class TruckFactory : VehicleFactory
            {
                public override IVehicle CreateVehicle()
                {

                    return new Truck();
                }
            }
            public interface IRepository<T>
            {
                T GetById(int id);
                IEnumerable<T> GetAll();
                void Add(T entity);
                void Update(T entity);
                void Delete(T entity);
            }
            public class VehicleRepository : IRepository<IVehicle>
            {
                private List<IVehicle> vehicles;
                public VehicleRepository()
                {
                    vehicles = new List<IVehicle>();
                }
                public IVehicle GetById(int id)
                {
                    return vehicles.FirstOrDefault(vehicle => vehicle.GetHashCode() == id);
                }
                public IEnumerable<IVehicle> GetAll()
                {
                    return vehicles;
                }
                public void Add(IVehicle entity)
                {
                    vehicles.Add(entity);
                }
                public void Update(IVehicle entity)
                {
                    // Implement update logic
                }
                public void Delete(IVehicle entity)
                {
                    vehicles.Remove(entity);
                }
            }
            public class VehicleService
            {
                private IRepository<IVehicle> repository;
                private VehicleLogger logger;
                public VehicleService(IRepository<IVehicle> repository)
                {
                    this.repository = repository;
                    logger = VehicleLogger.Instance;
                }
                public void AddVehicle(VehicleFactory factory)
                {
                    IVehicle vehicle = factory.CreateVehicle();
                    repository.Add(vehicle);
                    logger.Log("Vehicle added: " + vehicle.GetType().Name);
                }
                public void RemoveVehicle(int id)
                {
                    IVehicle vehicle = repository.GetById(id);
                    if (vehicle != null)
                    {
                        repository.Delete(vehicle);
                        logger.Log("Vehicle removed: " + vehicle.GetType().Name);
                    }
                }
                public void ListVehicles()
                {
                    foreach (IVehicle vehicle in repository.GetAll())
                    {
                        Console.WriteLine(vehicle.GetType().Name);
                    }
                }
                public void DoSomethingWithVehicle(int id)
                {
                    IVehicle vehicle = repository.GetById(id);
                    if (vehicle != null)
                    {
                        VehicleFactory factory;
                        if (vehicle is Car)
                        {
                            factory = new CarFactory();
                        }
                        else if (vehicle is Truck)
                        {
                            factory = new TruckFactory();
                        }
                        else
                        {
                            throw new NotSupportedException("Vehicle type not supported.");
                        }
                        factory.DoSomethingWithVehicle();
                    }
                }
            }



            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}