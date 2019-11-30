using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            var bl = new BusinessLogicLayer();
            var autor = bl.GetActorById(1);
            var autors = bl.GetActors();

        }
    }
}
