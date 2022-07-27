using System;

namespace cs_con_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string? name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string? ageInput = Console.ReadLine();
            int age = -1;
            if (ageInput != null)
            {
                age = int.Parse(ageInput);
            }

            // Ver 1: string concatenation
            Console.WriteLine("Hi " + name + ". You are " + age.ToString() + " years old!");

            // Ver 3: parameterized version (implicitly converted to string)
            Console.WriteLine("Hi {0}. You are {1} years old!", name, age);

            // Ver 2: actual version which shows how the parameterized version works
            string message = string.Format("Hi {0}. You are {1} years old!", name, age);
            Console.WriteLine(message);

            // Ver 4: C# 5.0 version - string Interpolation (converts to string implicitly)
            Console.WriteLine($"Hi {name}. You are {age} years old!");
        }
    }
}