using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodInjection
{
    interface IDataAccessDependency
    {
        void SetDependency(IDataAccess dataAccess);
    }
}
