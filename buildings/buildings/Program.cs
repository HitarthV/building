using System;

namespace buildings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building mybuilding = new Building(2,200,300);
            Console.WriteLine(mybuilding.getWidth());
            Console.WriteLine(mybuilding.getHeight());
            Console.WriteLine(mybuilding.getNumberFloors());
        }
    }
}
