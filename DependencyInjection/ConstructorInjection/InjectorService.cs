using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.ConstructorInjection
{
    public class InjectorService
    {
        BusinessLogicLayer _businessLogic;
        public InjectorService()
        {
            _businessLogic = new BusinessLogicLayer(new DataAccessLayer());
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

