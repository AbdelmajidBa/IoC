using System;
using System.Collections.Generic;
using System.Text;

namespace Unity.Container.Model
{
    public class Actor
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? LastUpdate { get; set; }

        public override string ToString()
        {
            var actorStr= $"Actor : id={ID},        firstName={FirstName},          lastName={LastName}";
            return "{" + actorStr + "}";
        }

    }
}
