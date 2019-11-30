using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.ConstructorInjection
{
    public class BusinessLogicLayer
    {
        IDataAccess _dataAccess;
        public BusinessLogicLayer(IDataAccess _custDataAccess)
        {
            _dataAccess = _custDataAccess;
        }

        public IEnumerable<Actor> GetActors()
        {
            return _dataAccess.GetActors();
        }

        public Actor GetActorById(int id)
        {
            return _dataAccess.GetActorById(id);
        }

        public IEnumerable<Actor> GetActorByName(string name)
        {
            return _dataAccess.GetActorByName(name);
        }
    }
}
