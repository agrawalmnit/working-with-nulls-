using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter p1 = new();

            p1.Name = null;
            p1.Bio = null;

            Console.ReadLine();
        }
    }
}
