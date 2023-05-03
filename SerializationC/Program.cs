using System;
using GenericsExtension;

namespace SerializationC
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Name = "Dmitriy", Age = 18 };
            string jString = obj.ToJson();
            Console.WriteLine(jString);
            Console.ReadKey();
        }
    }
}