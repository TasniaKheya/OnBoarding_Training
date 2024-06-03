using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 1;
           
            //While LOOP
            while (i <= 15)
            {
                Console.WriteLine(i);  
                i++;    
            }

            //Do While Loop =  Factorial
            Console.Write("X = ");
            int x  = int.Parse(Console.ReadLine());
            int fact = 1;
            do
            {
                fact = fact * x;
                x--;
            } while (x > 0);
            Console.WriteLine("The Factorial is : {0}",fact);

            //For Loop =  power
            Console.WriteLine("Enter a Number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Number :");
            int b = int.Parse(Console.ReadLine());

            int result=1;
            for(int d = 1; d <= b; d++)
            {
                result = result * a;
            }
            Console.WriteLine("Result : {0}",result);


            //ForEachLoop
            int[] num = {2,3,5,7,9,11,13,14};
            foreach (int item in num)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("");

            //Nested Loop in C#
            int value = 5;
            int row, k;
            for(row = 1; row <= value; row++)
            {
               
                for(k = 1; k <= row; k++)
                {
                    Console.Write('*');
                } 
                Console.WriteLine("");
            }

            //Continue and break
            int r = 6;
            while (true)
            {
                r--;
                if (r == 1)
                {
                    break;
                }
                else if(r != 3)
                {
                    Console.WriteLine(r);
                }
               
            }

            //Switch Case
            char c = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(c))
             {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Given Character is a vowel");
                    break;
                default:
                    Console.WriteLine("Given Character is not a vowel");
                    break;

            }
                
            Console.ReadKey();
        }
    }
}