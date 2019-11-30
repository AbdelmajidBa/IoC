using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class DataAccessFactory
    {
        public static IDataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }
}
