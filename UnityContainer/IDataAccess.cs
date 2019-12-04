using System;
using System.Collections.Generic;
using System.Text;
using Unity.Container.Model;

namespace Unity.Container
{
    public interface IDataAccess
    {
        IEnumerable<Actor> GetActors();
        IEnumerable<Actor> GetActorByName(string name);
        Actor GetActorById(int id);
    }
}
