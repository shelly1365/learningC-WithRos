using System;
using System.Threading.Tasks.Dataflow;

namespace learningWithRos
{
    public enum CarType
    {
        Honda = 1,
        Ford = 2,
        toyota = 3,
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
            Console.WriteLine("productname:" + productName, "productyear:" + productYear);
            Console.WriteLine(productYear);
            Console.WriteLine(productPrice);
            var x = 4;
            var y = 7;
            var sum = x + y;
            Console.WriteLine(sum);
            CarType MyCarType = CarType.Ford;
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




          
        }
    }
}
