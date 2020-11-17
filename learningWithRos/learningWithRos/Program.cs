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
    class myclass{
        public string test = "it works!";

    }
    class vehicle
    {
        public string Type;
        public int NumTires;
        public int Year;
        public bool Runs;
        public vehicle(string type, int numTires, int year, bool runs)

        {
            Type = type;
            NumTires = numTires;
            Year = year;
            Runs = runs;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            vehicle mycar = new vehicle("BMW", 4, 2002, true);
            Console.WriteLine(mycar.Type+" "+ mycar.NumTires+" "+ mycar.Year+" "+mycar.Runs);
            myclass myclass1 = new myclass();
            Console.WriteLine(myclass1.test);
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

            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(matrix[0, 0]);

            string[] friuts = new string[3];
            friuts[0] = "apple";
            friuts[1] = "orange";
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
            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("Alex", 45699677);
            phonebook["Jessica"] = 3487567;
            if (phonebook.ContainsKey("Alex"))
            {
                Console.WriteLine("the phononumber of Alex is:"+phonebook["Alex"]);
            
            }
            phonebook.Remove("Jessica");
            Console.WriteLine(phonebook.Count);
            Dictionary<int, string> inventory = new Dictionary<int, string>();
            inventory.Add(3, "Apple");
            inventory.Add(5, "Orange");
            inventory.Add(2, "banana");
            Console.WriteLine("the list of fruits are:" + inventory[3] + "," + inventory[5] + "," + inventory[2]);
            string firstname = "Rozita";
            String lastname="karimi";
            String fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            string sentence = "I like to play ";
            sentence += "chess";
            Console.WriteLine(sentence);
            int integer = 1;
            string ourString = "Something to be replaced by an int";
           ourString = integer.ToString();
           System.Console.WriteLine(ourString);
            int s = 2, k = 5;
            int sumint = s + k;
            string sumCalculation = string.Format("{0} + {1} = {2} ",s,k,sumint);
            Console.WriteLine(sumCalculation);
            string fullstring = "Rozita Karimi";
            string partofs = fullstring.Substring(7);
            string partofs1 = fullstring.Substring(7, 5);
            Console.WriteLine(partofs);
            Console.WriteLine(partofs1);
            string previousname = "Rozita Karimi";
            string newname = previousname.Replace("Rozita", "Shahrzad");
            Console.WriteLine(newname);
            string fruit1 = "apple,orange,banana";
            Console.WriteLine("Found orange in position: " + fruit1.IndexOf("apple"));
            Console.WriteLine("Found lemon in position: " + fruit1.IndexOf("lemon"));
            string firstname1 = "Sheida";
            string lastname1 = "Jamalian";
            int age = 28;
            string sentence1 = string.Format("{0} {1} is {2} years old", firstname1, lastname1, age);
            Console.WriteLine(sentence1);

            for (int i = 0; i < 16; i++)
            {

                if (i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);

            }

            int w = 2;
            int e = 2;
            int d = Foo(w, e);
            Console.WriteLine(d);



        }
        public static int Foo(int w, int e)
        {

            return w / e;
        }
    }
}
