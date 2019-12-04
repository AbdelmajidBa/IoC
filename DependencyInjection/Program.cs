using ConstructorInjection = DependencyInjection.ConstructorInjection;
using MethodInjection = DependencyInjection.MethodInjection;
using PropertyInjection = DependencyInjection.PropertyInjection;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            //DependencyInjection with Constructor Injection Technique 
            var service = new ConstructorInjection.InjectorService();
            var actor = service.GetActorById(1);
            var actors = service.GetActors();
            foreach (var a in actors)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("----------------------------------------------");
            //DependencyInjection with Method Injection Technique 
            var methodInjectionService = new MethodInjection.InjectorService();
            actor = methodInjectionService.GetActorById(1);
            actors = methodInjectionService.GetActors();
            foreach (var a in actors)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("----------------------------------------------");
            //DependencyInjection with Property Injection Technique
            var propertyInjectionService = new PropertyInjection.InjectorService();
            actor = propertyInjectionService.GetActorById(1);
            actors = propertyInjectionService.GetActors();
            foreach (var a in actors)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
