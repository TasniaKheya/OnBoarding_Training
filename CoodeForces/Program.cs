using System;
using System.Globalization;
using System.Net.WebSockets;

namespace CodeForces
{
    class Calc
    {
        static void Main(string[] args)
        {
            long t;

            t = 1;
            //t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                callSolve();
            }
        }

        private static void callSolve()
        {
            Dictionary<int ,List<string>> Student = new Dictionary<int ,List<string>>();
            Console.WriteLine("Enter Number of Students");
            int noOfStudents = int.Parse(Console.ReadLine());
            for(int i  = 1; i <= noOfStudents; i++) 
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enter ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Middle Name:");
                string middleName = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Department:");
                string dept = Console.ReadLine();
                List<string> listOfStudent = new List<string> { id,firstName, middleName, lastName,dept };
                Student.Add(i,listOfStudent);
            }
            Console.WriteLine(" ");
            Console.WriteLine("ID, First Name, Middle-Name, Last-Name, Department");
            for (int i = 1 ; i <= noOfStudents ; i++)
            {
                int p = 1;
                foreach(string s in Student[i])
                {
                    if(p<5)
                    Console.Write(s+", ");
                    else
                    Console.Write(s+" ");
                    p++;
                }
                Console.WriteLine("");
            }
            //string line = Console.ReadLine();
            //string[] s = line.Split(" ");
            //long a, b, i, j=0;
            //a = long.Parse(s[0]);   
            //b = long.Parse(s[1]);
            //long p = 1;
            //for(i=0;i<b-1;i++)
            //{
            //    j = j + p;
            //    p = p + 2;
            //}
            //if((a-j)%2==1 && (a-j)>(p-2))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            //string s,s1="",s2="";
            //s  = Console.ReadLine();
            //char[] c = s.ToCharArray();
           
            //Array.Sort(c);
            //for(int i=0;i<c.Length;i++)
            //{
            //    s1 += c[i];
            //}

            ////Console.WriteLine(s1);
            //char[] c1 = s1.ToCharArray();
            //Array.Reverse(c1);
            //for(int i = 0; i<c1.Length;i++)
            //{
            //    s2 += c1[i];
            //}
            //if(s1==s2)
            //{
            //    Console.WriteLine("-1");
            //}
            //else
            //{
            //    Console.WriteLine(s1);
            //}
            //string inp = Console.ReadLine();
            //string[] aray = inp.Split(' ');
            //long n = int.Parse(aray[0]);
            //long k = int.Parse(aray[1]);
            //string line = Console.ReadLine();
            //long a, b = 0;
            //string[] arr = line.Split(' ');
            //long[] arr1 = new long[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr1[i] = int.Parse(arr[i]);
            //}
            // Array.Sort(arr1);
            //long median = n / 2;
            //if(n==1)
            //{
            //    Console.WriteLine(n + k);
            //}
            //else
            //{
            //   // a = arr1[median];
            //    for (long i = median+1; i < n; i++)
            //    {
            //        //if (arr1[i]-a>=k)
            //        //{
            //        //    arr1[median] += k;
            //        //}
            //        //else
            //        //{
            //        //    arr1[median] = arr1[median + 1];
            //        //}
            //    }
            //    //a = arr1[median + 1] - arr1[median];
            //    //if (a >= k)
            //    //{
            //    //    Console.WriteLine(n + k);
            //    //}
            //    //else
            //    //{
            //    //    arr1[median] = arr1[median + 1];

            //    //}
            //}
            ////for(int i = 0;i<arr1.Length;i++)
            ////{
            ////    a = arr1[i];
            ////    if(a<0) { a = a * -1; }
            ////    b += a;
            ////}
            ////Console.WriteLine(b);
            ////if(n==1)
            ////{
            ////    Console.WriteLine(0);
            ////}
            ////double d;
            //if(n<=6)
            //{
            //    d = ((6 % n) % 2);
            //    if(d==0)
            //    {
            //        Console.WriteLine()
            //    }

            //}    
            //  long way = 0;
            //  long n = int.Parse(Console.ReadLine());
            //  string line = Console.ReadLine();
            //  char[] line1 = line.ToCharArray();
            ////  Console.WriteLine(line1);
            //  //foreach(char c in line1)
            //  //{
            //  //    Console.WriteLine(c);
            //  //}
            //  if(n>1)
            //  {
            //      for (int i = 0; i < line1.Length; i++)
            //      {
            //          if (line1[i] == '?')
            //          {
            //              if (i == 0)
            //              {
            //                  if (line1[i + 1] == 'B') line1[i] = 'R';
            //                  else line1[i] = 'B';
            //              }
            //              else if (i == n - 1)
            //              {
            //                  if (line1[i - 1] == 'B') line1[i] = 'R';
            //                  else line1[i] = 'B';
            //              }
            //              else
            //              {
            //                  if ((line1[i - 1] == 'R' && line1[i + 1] == 'B') || (line1[i - 1] == 'B' && line1[i + 1] == 'R'))
            //                  {
            //                      line1[i] = 'R';
            //                  }
            //                  else if (line1[i - 1] == 'R') line1[i] = 'B';
            //                  else line1[i] = 'R';
            //              }
            //          }
            //      }
            //  }
            //  else if(n==1)
            //  {
            //      if (line1[0]=='?')
            //      {
            //          line1[0] = 'R';
            //          way++;
            //      }
            //  }

            //  for(int i=1;i<n;i++)
            //  {
            //      if (line1[i] == line1[i-1])
            //      {
            //          way++;
            //      }
            //  }
            //  string s = "";
            //  for(int i = 0; i < line1.Length;i++)
            //  {
            //      s += line1[i];
            //  }
            //  Console.WriteLine(s);
            // string[] ara = line.Split(" ");
            // HashSet<long> sett = new HashSet<long>();
            //// int[] ara1 = new int[ara.Length];
            // for (int i = 0; i < ara.Length; i++)
            // {
            //     // Console.WriteLine(ara[i]);
            //     if (int.Parse(ara[i]) != 0)
            //     {
            //         sett.Add(int.Parse(ara[i]));
            //     }
            // }

            // Console.WriteLine(sett.Count);

            //char c = 'A';
            //c++;
            //Console.WriteLine(c);
            //Dictionary<long, long> map = new Dictionary<long, long>();
            //long n, a, k, lie = 0, p, good = 0;
            //n = int.Parse(Console.ReadLine());
            //List<long> list = new List<long>();
            //a = 0;
            //var line = Console.ReadLine();
            //char[] s = line.ToCharArray();
            //if (n < 3)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (line[i] == '.')
            //        {
            //            lie++;
            //        }
            //    }
            //    if (lie == n)
            //    {
            //        Console.WriteLine(1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(0);
            //    }
            //}
            //else if (n >= 3)
            //{
            //    for (int i = 1; i < (n - 1); i++)
            //    {
            //        if (s[i - 1] == '.' && s[i + 1] == '.')
            //        {
            //            s[i - 1] = '#';
            //            s[i + 1] = '#';
            //            good = good + 2;
            //        }
            //    }
            //    Console.WriteLine(good);
            //}


            //string[] ara =line.Split(" ");
            //int[] ara1 = new int[ara.Length];
            //for (int i = 0;i < ara.Length;i++)
            //{
            //    ara1[i] = int.Parse(ara[i]);
            //    if (ara1[i] == 0)
            //    {
            //        ara1[i]++;
            //        good++;
            //    }
            //}
            //for(int i = 0;i<ara1.Length;i++)
            //{
            //    lie += ara1[i];
            //}
            //if(lie == 0)
            //{
            //    good++;
            //}
            //Console.WriteLine(good);

            //for (int i = 0;i < ara.Length;i++)
            //{
            //    k = int.Parse(ara[i]);
            //    map[k] = 0;
            //}
            //for (int i = 0; i < ara.Length; i++)
            //{
            //    k = int.Parse(ara[i]);
            //    map[k]++;
            //}
            //for (int i = 0; i < ara.Length; i++)
            //{


            //    k = int.Parse(ara[i]);
            //    if(k>=n || map[k]>n-k)
            //    {
            //        lie++;
            //    }    
            //}
            //if (n == lie)
            //{
            //    Console.WriteLine(-1);
            //}
            //else
            //{
            //    Console.WriteLine(lie);
            //}
            //while (a < n)
            //{
            //    k = int.Parse(ara[a]);
            //    if (k >= n)
            //    {
            //        lie++;
            //    }
            //    else
            //    {
            //        p = k;
            //        break;

            //    }
            //    //list.Add(k);
            //    a = a + 1;
            //}
            //a = 0;
            //while (a < n)
            //{
            //    k = int.Parse(ara[a]);
            //    if (k == p)
            //    {
            //        good++;
            //    }
            //    else
            //    {
            //        p = k;
            //        break;

            //    }
            //    //list.Add(k);
            //    a = a + 1;
            //}

            //if (lie==n)
            //{
            //    Console.WriteLine(-1);
            //}
            //else
            //{
            //    Console.WriteLine(lie);
            //}
            // a = n;



            //long a = 0, b = 0, c=0, k=0, j, amount = 0, e, f;
            //a = int.Parse(Console.ReadLine());
            //var line = Console.ReadLine();
            //string[] tokens = line.Split(' ');
            ////List<int> number = new List<int>();
            //// c = int.Parse(Console.ReadLine());
            ////if (c <0)
            ////{
            ////    c = c * -1;
            ////}
            //foreach (var s in tokens)
            //{
            //    int num = 0;
            //    if (Int32.TryParse(s, out num))
            //    {
            //        if (num < 0)
            //        {
            //           // c = 1;
            //            b = b + (num * -1);
            //        }
            //        else
            //        {
            //            b = b + (num * 1);
            //        }

            //        if(num < 0 && c == 0)
            //        {
            //            k++;
            //        }
            //        if(num <0 )
            //        {
            //            c = 1;
            //        }
            //        else if (num>0)
            //        {
            //            c = 0;
            //        }

            //        //b += num;
            //    }
            //}


            //Console.WriteLine("{0} {1}", b,k);

            //string s = "";
            //s = Console.ReadLine();
            //for(int i = 0;i<s.Length;i++)
            //{
            //    if (s[i] == 'A')
            //    {
            //        a++;
            //    }
            //    else
            //    {
            //        b++;
            //    }
            //}
            //if(a>=b)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    Console.WriteLine("B");
            //}
            //a = int.Parse(Console.ReadLine());

            //if(a%2==1)
            //{
            //    Console.WriteLine("NO");
            //}
            //else
            //{
            //   // if (a % 2 == 1) { a++; }
            //    for(int i=0;i<a;i++)
            //    {
            //        s += "A";
            //        b++;
            //        if(b==2)
            //        {
            //            s += "B";
            //            b = 0;
            //        }

            //    }
            //    Console.WriteLine("YES");
            //    Console.WriteLine(s);
            //}

            // var line = Console.ReadLine();
            // string[] tokens = line.Split(' ');
            // List<int>number = new List<int>();

            //foreach(var s in tokens)
            // {
            //     int num;
            //     if(Int32.TryParse(s, out num))
            //     {
            //         number.Add(num);
            //     }
            // }
            // a = number[0];
            // b = number[1];
            // c = number[2];
            // //Console.WriteLine("{0},{1},{2}", a, b, c);
            // k = (a % 2);
            // j = (a - k) / 2;
            // amount = k*b;

            // e = j * 2 * b;
            // f = j * c;
            // if (e < f) amount += e;
            // else amount += f;

            // Console.WriteLine(amount);


        }
    }
}
