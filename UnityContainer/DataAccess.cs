using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity.Container.Model;

namespace Unity.Container
{
    class DataAccess : IDataAccess
    {
        private List<Actor> customes;
        public DataAccess()
        {
            customes = new List<Actor> {
                        new Actor { ID=1, FirstName="PENELOPE", LastName="GUINESS" },
                        new Actor { ID=2, FirstName="NICK", LastName="WAHLBERG" },
                        new Actor { ID=3, FirstName="ED", LastName="CHASE" },
                        new Actor { ID=4, FirstName="JENNIFER", LastName="JENNIFER" },
                        new Actor { ID=5, FirstName="JOHNNY", LastName="LOLLOBRIGIDA" },
                        new Actor { ID=6, FirstName="BETTE", LastName="NICHOLSON" },
                        new Actor { ID=7, FirstName="GRACE", LastName="MOSTEL" },
                        new Actor { ID=8, FirstName="MATTHEW", LastName="JOHANSSON" },
                        new Actor { ID=9, FirstName="JOE", LastName="SWANK" }};
        }

        public IEnumerable<Actor> GetActors()
        {
            return customes;
        }

        public IEnumerable<Actor> GetActorByName(string name)
        {
            return customes.Where(a => a.FirstName.ToLower().Equals(name.ToLower()) || a.FirstName.ToLower().Equals(name.ToLower()));
        }

        public Actor GetActorById(int id)
        {
            return customes.Where(a => a.ID == id).FirstOrDefault();
        }

    }
}
