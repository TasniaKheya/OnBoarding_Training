using System;
using System.IO;

namespace Code
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a String");
            String input = Console.ReadLine();
            String[] listt = input.Split('_', '.');

            Console.WriteLine("Account Number is :" + listt[2]);
            Console.ReadLine();

            */
            //File Read
            string filePath = "C://New folder/sample_string.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists!");
                StreamReader reader = new StreamReader(filePath);

                string line;

                // Read each line until the end of the file
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("adult", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("adult");

                    }
                    else if (line.Contains("pediatrics", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("pediatrics");
                    }
                    else
                    {
                        Console.WriteLine("Nothing Found");
                    }
                }
            }

            else
            {
                Console.WriteLine("File does not exist.");
            }
            
            
            

        }
    }
}

