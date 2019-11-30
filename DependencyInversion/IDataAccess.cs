using DependencyInversion.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public interface IDataAccess
    {
        IEnumerable<Actor> GetActors();
        IEnumerable<Actor> GetActorByName(string name);
        Actor GetActorById(int id);
    }
}
