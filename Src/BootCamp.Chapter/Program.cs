using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("input 1 start ,input 2 end!");
            int mark = int.Parse(Console.ReadLine());


            while (true)
            {

                if (mark == 1)
                {

                    Console.WriteLine("please input your name!");
                    string name = Console.ReadLine();
                    Console.WriteLine("please input your age!");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("please input your weight!");
                    double weight = double.Parse(Console.ReadLine());
                    Console.WriteLine("please input your height!");
                    double height = double.Parse(Console.ReadLine());

                    string message = @$"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.";
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("game over!");
                }

            }


        }
    }
}
