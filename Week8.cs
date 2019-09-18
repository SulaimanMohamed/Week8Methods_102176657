using System;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet();
            Console.Write("what is your name? ");
            var name = Console.ReadLine();
            GreetName(name);
            Sum();
            string name1 = "This is a test string.";
            var count = Count(name1);
            Console.WriteLine(count);
            
            

        }

        static void Greet() //Task 1
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }


        static void GreetName(string name) //Task 2
        {
            Console.WriteLine("Hello friend, " + name);
            Console.WriteLine("Have a nice day!");
        }

        static void Sum() //Task 3
        {
            int num1 = 15;
            int num2 = 16;
            Console.WriteLine(num1 + num2);
        }

        static int Count(string name) //Task 4
        {
            int count;
            count = name.Split(' ').Length - 1;
            return count;
        }

        static void array() //Task 5
        {
            int[] arr = new int[5] { 5, 7, 3, 2, 9 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                Console.WriteLine(sum);
            }
        }
    }
}
