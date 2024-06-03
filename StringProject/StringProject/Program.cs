//String Operations
///Whole String Concept

using System;
using System.Reflection.Metadata;

namespace CSharpString
{
    class Test
    {
        public static void Main(string[] args)
        {
            for(int i = 0;i<5;i++)
            Console.Beep();
            string name = "Lily";

            //format String
            //Single Line Format
            string OutStr = String.Format("Hello {0}", name);
            Console.WriteLine(OutStr);
            Console.WriteLine(" ");

            //Multiple Line Format
            String person = "Lily";
            String food = "Apple";
            String mulOutStr = String.Format("{0} eats {1}", person, food);
            Console.WriteLine(mulOutStr);
            Console.WriteLine(" ");

            //Control Spacing and Right Allignment
            String rightAString = String.Format("{0,20}", "Lily");
            Console.WriteLine(rightAString);
            Console.WriteLine(" ");

            //Control Spacing and Left Allignment
            String LeftAString = String.Format("{0,-10} {1,-20}", "Lily","Bloom");
            Console.WriteLine(LeftAString);
            Console.WriteLine(" ");

            //String Split
            string text = "C# is a programming Language.pdf";
            string[] result = text.Split('.',' ');
            Console.WriteLine("Result is : ");
            foreach (String str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(" ");
            //String Split using Separators
            string text1 = "Programiz is developed for programmers";
            string[] separators = { "is", "for" };

            // separates string at separators
            string[] result1 = text1.Split(separators, StringSplitOptions.TrimEntries);

            foreach (string str in result1)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(" ");
            //separate string in a number of substrings
            string text2= "a::b::c::d::e::f";

            string[] separators2 = { "::" };

            // create a maximum of 2 substrings 
            string[] result2 = text2.Split(separators2,6, StringSplitOptions.None);

            foreach (string str in result2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(" ");

            //Substring
            string txt = "ABCDEFGHIJKLMN";
            string sub = txt.Substring(0,1);
            Console.WriteLine(sub);
            Console.WriteLine(" ");

            //Compare
            string str1 = "P#";
            string str2 = "p#";
            // returns -1 because C# comes before Programiz in alphabetical order
            bool ignoreCase = true;
            int r = String.Compare(str1, str2, ignoreCase);
            Console.WriteLine(r);
            Console.WriteLine(" ");

            //Replace
            string strr = "Programming is fun";

            // replaces "Programming" with "C#" 
            string output = strr.Replace("Programming", "C#");
            Console.WriteLine(output);
            string output1 = output.Replace('C','R');
            Console.WriteLine(output1);
            //replace Chain
            String stt = "AAA";
            string output2 = stt.Replace("AAA", "BBB").Replace("BBB","CCC");
            Console.WriteLine(output2);
            Console.WriteLine(" ");

            string str5 = "I love Ice cream";

            // check if str contains "ice cream"
            bool check = str5.Contains("ice cream",StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(check);

            ///Remove
            string outt = str5.Remove(8,1);
            Console.WriteLine(outt);

            //Join
            string[] tex = { "C#", "Java", "C++" };

            // joins string with space between them
            Console.WriteLine(String.Join("/", tex,1,2));


            //Concat
            string str0 = "ice ";
            string str11 = "cream";
            string result11;

            // concatenates str0 and str1
            result11 = String.Concat(str0, str11);
            Console.WriteLine(result11);

            // concatenates str0 and str1
            result11 = String.Concat(str11, str0);
            Console.WriteLine(result11);


            string[] str111 = { "Chocolate", " Ice cream", " Vanilla" };
            // concatenates string array
            string result111 = String.Concat(str111);
            Console.WriteLine(result111);

            ///Trim
            string t = " Kheya ";
            string s = t.TrimEnd();
            Console.WriteLine(s);

            //Trim Characters
            char[] charsToTrim = { '(', ')', '^' };

            string text3 = "(^^Everyone loves ice cream^^)";
            Console.WriteLine("Before trim: " + text3);

            // trims leading and trailing specified chars
            string s1 = text3.Trim(charsToTrim);
            Console.WriteLine("After trim: " + s1);
            Console.WriteLine(s1.IndexOf('v',0,3));
            Console.WriteLine(s1.LastIndexOf('v'));
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1.EndsWith("cream"));
            Console.WriteLine(s1.StartsWith("cream"));


            //PadLeft
            string s9 = s1.PadRight(20);
            Console.WriteLine("Result: " + s9);


            //To CharacterArray
            string str22 = "Icecream";
            char[] result12;

            // copies 4 chars from index 3 of str
            result12 = str22.ToCharArray(3, 4);

            // prints result
            for (int i = 0; i < result12.Length; i++)
            {
                Console.WriteLine(result12[i]);
            }

            //To remove CaseSensitivity we have to use StringComparision.Ordinal
            Console.ReadLine();
        }
    }
}