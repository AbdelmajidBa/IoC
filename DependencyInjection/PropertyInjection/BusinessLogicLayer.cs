using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.PropertyInjection
{
    public class BusinessLogicLayer
    {   
        public IDataAccess DataAccess  { get; set; }
        public BusinessLogicLayer()
        {
        }

        public IEnumerable<Actor> GetActors()
        {
            return DataAccess.GetActors();
        }

        public Actor GetActorById(int id)
        {
            return DataAccess.GetActorById(id);
        }

        public IEnumerable<Actor> GetActorByName(string name)
        {
            return DataAccess.GetActorByName(name);
        }
    }
}
