using DependencyInversion.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class BusinessLogicLayer
    {
        IDataAccess _dataAccess;
        public BusinessLogicLayer()
        {
            _dataAccess = DataAccessFactory.GetDataAccessObj();
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
