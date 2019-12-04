using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            var bl = new BusinessLogicLayer();
            var actor = bl.GetActorById(1);
            var actors = bl.GetActors();
            foreach (var a in actors)
            {
                Console.WriteLine(a.ToString());
            }

        }
    }
}
