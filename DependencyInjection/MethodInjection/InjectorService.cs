using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodInjection
{
    public class InjectorService
    {
        BusinessLogicLayer _businessLogic;
        public InjectorService()
        {
            _businessLogic = new BusinessLogicLayer();
            _businessLogic.SetDependency(new DataAccessLayer());
        }

        public IEnumerable<Actor> GetActors()
        {
            return _businessLogic.GetActors();
        }

        public Actor GetActorById(int id)
        {
            return _businessLogic.GetActorById(id);
        }

        public IEnumerable<Actor> GetActorByName(string name)
        {
            return _businessLogic.GetActorByName(name);
        }
    }
}
