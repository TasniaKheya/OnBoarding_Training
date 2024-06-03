using System;
using System.Reflection.Metadata;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //problem : Write a program that will split the following line based on " " (space) and print "fox" and "dog" if word is found in the string. 
            //A ^ quick ^ brown ^ fox ^ ^jumps ^ over ^ the ^ ^lazy ^ dog ^
            //////////////////way no one/////////////////////
            string line = "A^quick^brown^fox^^jumps^over^the^^lazy^dog^";
            string line2 = line.Replace("^", " ");
            line = line2;
            string[] stringssss = line.Split(' ');
            foreach (string s in stringssss)
            {
                //Console.WriteLine(s);
                if (s == "fox")
                {
                    Console.WriteLine("fox");
                }
                else if (s == "dog")
                {

                    Console.WriteLine("dog");
                }
            }
            //Console.WriteLine(" ");
            // string line = Console.ReadLine();
            ///Console.WriteLine(s);
            //string s1 = line;
            //string line3 = line,line2=line;
            /*
            if(line.Contains("fox"))
            {
                line2 = line.Replace("fox", " fox ");
            }
            if (line.Contains("dog"))
            {
               line3= line2.Replace("dog", " dog ");
            }
            line = line3;
            Console.WriteLine(line);

            string[] strings = line.Split(" ");

            
            foreach (string s in strings)
            {
               // Console.WriteLine(s);
                if(s == "fox")
                {
                    Console.WriteLine("fox");
                }
                if(s=="dog")
                {

                    Console.WriteLine("dog");
                }
            }

            Console.WriteLine(" ");
            //////////////////way no two/////////////////////
            line = s1;
            string[] stringss = line.Split(" ");
            foreach (string s in strings)
            {
                // Console.WriteLine(s);
                if (s.Contains("fox"))
                {
                    Console.WriteLine("fox");
                }
                if (s.Contains("dog"))
                {

                    Console.WriteLine("dog");
                }
            }
            Console.WriteLine(" ");
            //////////////////way no three/////////////////////

            foreach (string s in strings)
            {
                // Console.WriteLine(s);
                if (s.IndexOf("fox")!=-1)
                {
                    Console.WriteLine("fox");
                }
                if (s.IndexOf("dog") != -1)
                {

                    Console.WriteLine("dog");
                }
            }
            Console.WriteLine(" ");
            string[] stringsss = line.Split(null) ;
            foreach (string s in stringsss)
            {
                 Console.WriteLine(s);
                if (s.IndexOf("fox") != -1)
                {
                    Console.WriteLine("fox");
                }
                if (s.IndexOf("dog") != -1)
                {

                    Console.WriteLine("dog");
                }
            }
            Console.WriteLine(" ");
            */

            //////////////////way no four/////////////////////
            //line2 = line.Replace("^", " ");
            //line = line2;
            //string[] stringssss = line.Split(' ');
            //foreach (string s in stringssss)
            //{
            //    //Console.WriteLine(s);
            //    if (s=="fox")
            //    {
            //        Console.WriteLine("fox");
            //    }
            //    else if (s == "dog")
            //    {

            //        Console.WriteLine("dog");
            //    }
            //}
            //Console.WriteLine(" ");
        }
    }
}
