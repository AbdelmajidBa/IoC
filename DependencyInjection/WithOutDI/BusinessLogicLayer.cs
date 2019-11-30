using DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.WithOutDI
{
public class BusinessLogicLayer
{
    DataAccessLayer _dataAccess;

    public BusinessLogicLayer()
    {
        _dataAccess = new DataAccessLayer();
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
