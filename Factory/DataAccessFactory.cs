using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class DataAccessFactory
    {
        public static DataAccessLayer GetDataAccessObj()
        {
            return new DataAccessLayer();
        }
    }
}
