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
            var autor = service.GetActorById(1);
            var autors = service.GetActors();

            //DependencyInjection with Method Injection Technique 
            var methodInjectionService = new MethodInjection.InjectorService();
            autor = methodInjectionService.GetActorById(1);
            autors = methodInjectionService.GetActors();
            
            //DependencyInjection with Property Injection Technique
            var propertyInjectionService = new PropertyInjection.InjectorService();
            autor = propertyInjectionService.GetActorById(1);
            autors = propertyInjectionService.GetActors();
        }
    }
}
