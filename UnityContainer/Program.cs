using System;
using Unity;
using Unity.Injection;

namespace Unity.Container
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("--------------------------------------------------");
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IDataAccess, DataAccess>();

            var bl = container.Resolve<BusinessLogic>();
            var actors = bl.GetActors();
            foreach (var actor in actors)
            {
                Console.WriteLine(actor.ToString());
            }

            Console.WriteLine("--------------------------------------------------");



            Driver driver = new Driver(new BMW());
            driver.RunCar();

            Console.WriteLine("Using Unity Container");

            container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            Driver drv = container.Resolve<Driver>();
            drv.RunCar();

            Console.WriteLine("Multiple Registration");

            container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>();

            driver = container.Resolve<Driver>();
            driver.RunCar();


            Console.WriteLine("Register Named Type");
            container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            // Registers Driver type            
            container.RegisterType<Driver>("LuxuryCarDriver",
                            new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));


            Driver driver1 = container.Resolve<Driver>();// injects BMW
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            driver2.RunCar();

            Console.WriteLine("Register Instance");
            container = new UnityContainer();
            ICar audi = new Audi();
            container.RegisterInstance<ICar>(audi);

            driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            driver1.RunCar();

            driver2 = container.Resolve<Driver>();
            driver2.RunCar();

            Console.WriteLine("Constructor Injection for Multiple Parameters");

            container = new UnityContainer();

            container.RegisterType<ICar, Audi>();
            container.RegisterType<ICarKey, AudiKey>();

            Driver2 driver3 = container.Resolve<Driver2>();
            driver3.RunCar();


            Console.WriteLine("Multiple Constructors");
            
            container = new UnityContainer();
            container.RegisterType<Driver>(new InjectionConstructor(new Ford()));
            driver = container.Resolve<Driver>();
            driver.RunCar();

            container = new UnityContainer();
            container.RegisterType<ICar, Ford>();
            container.RegisterType<Driver>(new InjectionConstructor(container.Resolve<ICar>()));
            driver.RunCar();


            Console.WriteLine("Primitive Type Parameter");
            container = new UnityContainer();
            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" }));
            driver = container.Resolve<Driver>(); // Injects Audi and Steve
            driver.RunCar();

            Console.WriteLine("Unity Container: Property Injection");
            //Console.WriteLine("         [Dependency] Attribute");

            //container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();

            //Driver3 d = container.Resolve<Driver3>();
            //d.RunCar();

            //Console.WriteLine("         [Dependency] Attribute Named Mapping");
            //container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //Driver3 d = container.Resolve<Driver3>();
            //d.RunCar2();


            //Console.WriteLine("         Run-time Configuration");
            //container = new UnityContainer();

            ////run-time configuration
            //container.RegisterType<Driver3>(new InjectionProperty("Car", new BMW()));

            //Driver3 d = container.Resolve<Driver3>();
            //d.RunCar();

            Console.WriteLine("Unity Container: Method Injection");
            //Console.WriteLine("                 [InjectionMethod] Attribute");
            //container = new UnityContainer();
            //container.RegisterType<ICar, BMW>();

            //var d4 = container.Resolve<Driver4>();
            //d4.RunCar();


            Console.WriteLine("                 Run-time Configuration");

            container = new UnityContainer();

            //run-time configuration
            container.RegisterType<Driver4>(new InjectionMethod("UseCar", new Audi()));

            //to specify multiple parameters values
            //container.RegisterType<Driver>(new InjectionMethod("UseCar", new object[] { new Audi() }));

            var d4 = container.Resolve<Driver4>();
            d4.RunCar();
            Console.ReadKey();
        }

        public interface ICar
        {
            int Run();
        }

        public class BMW : ICar
        {
            private int _miles = 0;

            public int Run()
            {
                return ++_miles;
            }
        }

        public class Ford : ICar
        {
            private int _miles = 0;

            public int Run()
            {
                return ++_miles;
            }
        }

        public class Audi : ICar
        {
            private int _miles = 0;

            public int Run()
            {
                return ++_miles;
            }

        }

        public interface ICarKey
        {

        }

        public class BMWKey : ICarKey
        {

        }

        public class AudiKey : ICarKey
        {

        }

        public class FordKey : ICarKey
        {

        }
        public class Driver
        {
            private ICar _car = null;
            private string _name = string.Empty;

            //[InjectionConstructor]
            public Driver(ICar car)
            {
                _car = car;
            }

            public Driver(ICar car, string name)
            {
                _car = car;
                _name = name;
            }


            public void RunCar()
            {
                if(!string.IsNullOrEmpty(_name))
                    Console.WriteLine("{0} is Running {1} - {2} mile ", _name, _car.GetType().Name, _car.Run());
                else
                    Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());

            }
        }

        public class Driver2
        {
            private ICar _car = null;
            private ICarKey _key = null;

            

            public Driver2(ICar car, ICarKey key)
            {
                _car = car;
                _key = key;
            }
            public void RunCar()
            {
                Console.WriteLine("Running {0} with {1} - {2} mile ", _car.GetType().Name, _key.GetType().Name, _car.Run());

            }
        }

        public class Driver3
        {
            public Driver3()
            {
            }

            //[Dependency]
            public ICar Car { get; set; }
            
            //[Dependency("LuxuryCar")]
            public ICar Car2 { get; set; }

            public void RunCar()
            {
                Console.WriteLine("Running {0} - {1} mile ",
                                    this.Car.GetType().Name, this.Car.Run());
            }

            public void RunCar2()
            {
                Console.WriteLine("LuxuryCar is running {0} - {1} mile ",
                                    this.Car2.GetType().Name, this.Car2.Run());
            }
        }


        public class Driver4
        {
            private ICar _car = null;

            public Driver4()
            {
            }

            //[InjectionMethod]
            public void UseCar(ICar car)
            {
                _car = car;
            }

            public void RunCar()
            {
                Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
            }
        }


    }
}
