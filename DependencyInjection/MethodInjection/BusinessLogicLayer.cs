using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodInjection
{
    public class BusinessLogicLayer : IDataAccessDependency
    {
        IDataAccess _dataAccess;

        public BusinessLogicLayer()
        {
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

        public void SetDependency(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
    }
}
