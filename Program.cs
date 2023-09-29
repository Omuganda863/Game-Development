using System;

namespace GamePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";

            Console.WriteLine("My Name is XT-4000, an AI from the Future Programmed To Destroy Mankind\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+name+" What is your favourite Colour");
            string colour = Console.ReadLine();

            Console.WriteLine("Your favourite colour is "+colour+", Weak, Mine is Destruction!");

            Console.ReadKey();
        }
    }
}
