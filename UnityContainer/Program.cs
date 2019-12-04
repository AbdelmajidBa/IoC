using System;
using Unity;
using Unity.Injection;

namespace Unity.Container
{
    class Program
    {
        static void Main(string[] args)
        {


            // Create a new instance 
            IUnityContainer container = new UnityContainer();

            //Register the type-mapping
            container.RegisterType<IDataAccess, DataAccessLayer>();

            //Create or Resolve a new object of BusinessLogic   
            var bl = container.Resolve<BusinessLogicLayer>();
            var actors = bl.GetActors();
            foreach (var actor in actors)
            {
                Console.WriteLine(actor.ToString());
            }
        
            //
            Console.ReadKey();
        }
    }
}
