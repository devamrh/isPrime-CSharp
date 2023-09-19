using System;

namespace HelloWorld
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Prime Numbers From 1 to 100 :");


            for (int i = 2; i <=100; i++)

            {

                bool isPrime = true;
                for (int j = 2; j*j <=i; j++)
                {
                    if (i%j==0)
                    {
                        isPrime = false;
                        break;

                    }

                   
                }

                if (isPrime)
                {

                    Console.WriteLine($"{i} ");
                }
            }
        }
    }



}
