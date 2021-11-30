using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human pc = new Human("Winter");
            Human enemy = new Human("Skeleton");

            pc.Attack(enemy);
            
        }
    }
}
