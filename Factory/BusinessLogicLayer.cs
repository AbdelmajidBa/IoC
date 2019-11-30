using Factory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccess;

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
