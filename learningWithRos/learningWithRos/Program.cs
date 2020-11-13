using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace learningWithRos
{
   

    public enum CarType
    {
        Honda ,
        Ford ,
        toyota ,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World rozita!");
            string productName = "tv";
            int productYear = 2012;
            float productPrice = 275.12f;
            Console.WriteLine("Hello World!");
            Console.WriteLine("productname:" + productName + "productyear:" + productYear);
            Console.WriteLine(productYear);
            Console.WriteLine(productPrice);
            var x = 4;
            var y = 7;
            var sum = x + y;
            Console.WriteLine(sum);
            int MyCarType = (int)CarType.Ford;
            Console.WriteLine(MyCarType);
            int c = 2;
            bool f = c == 2;
            Console.WriteLine(f);
            if (f)
            {
                Console.WriteLine("its true");
            }
            int guess = 500;
            if (guess==500)
            {
                Console.WriteLine("Success!");
            }

            int[,] matrix = new int[2, 2] { {1,2 }, {3,4 } };
            Console.WriteLine(matrix[0, 0]);

            string[] friuts = new string[3];
            friuts[0]= "apple";
            friuts[1]= "orange";
            friuts[2] = "banana";
            Console.WriteLine(friuts[2]);
            string[] cars = new string[] { "Ford", "Honda" };
            Console.WriteLine(cars[0]);
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            Console.WriteLine(numbers[1]);
            List<int> r = new List<int>();
            int[] array = new int[] { 1, 2, 3 };
            r.AddRange(array);
            List<string> people = new List<string>();
            people.Add("Rozita");
            people.Add("Shahrzad");
            people.Add("Sheida");
            Console.WriteLine(people.Count);
            people.Remove("Sheida");
            Console.WriteLine(people.Count);
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine("fistnumber"+primeNumbers[0]+"secondnumber"+ primeNumbers[1]+"thirdnumber"+ primeNumbers[2] +"forthnumber"+ primeNumbers[3]);



          
        }
    }
}
