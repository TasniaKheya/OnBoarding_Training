using System;
using System.Linq.Expressions;

namespace Student
{
    class ListOfStudent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ID, First Name, Middle-Name, Last-Name, Department");
            List<Class1> list = new List<Class1>();
            Class1 student1 = new Class1();
            student1.id = 1;
            student1.firstName = "Tasnia";
            student1.middleName = "Haque";
            student1.lastName = "Kheya";
            student1.dept = "CSE";

            Class1 student2 = new Class1(2,"Radia","Shaulin","Ananna","Dental");
            list.Add(student1);
            list.Add(student2);

            foreach (Class1 student in list)
            {
                Console.WriteLine(student.id + ", "+student.firstName+", "+student.middleName+", "+student.lastName+", "+student.dept);
            }
           
            //Creating a List Of Students
            //Dictionary<int, List<string>> Student = new Dictionary<int, List<string>>();
            //Console.WriteLine("Enter Number of Students: ");
            //int noOfStudents = int.Parse(Console.ReadLine());
            //int i;

            //Adding Elements by user Input
            
            //for (i = 1; i <= noOfStudents; i++)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Enter ID:");
            //    string id = Console.ReadLine();
            //    Console.WriteLine("Enter First Name:");
            //    string firstName = Console.ReadLine();
            //    Console.WriteLine("Enter Middle Name:");
            //    string middleName = Console.ReadLine();
            //    Console.WriteLine("Enter Last Name:");
            //    string lastName = Console.ReadLine();
            //    Console.WriteLine("Enter Department:");
            //    string dept = Console.ReadLine();
            //    List<string> listOfStudent = new List<string> { id, firstName, middleName, lastName, dept };
            //    Student.Add(i, listOfStudent);
            //}

            //Adding Elements Manually
            //List<string> manualStudent1 = new List<string> { (noOfStudents+1).ToString(), "Tasnia", "Haque", "Kheya", "CSE" };
            //List<string> manualStudent2 = new List<string> { (noOfStudents + 2).ToString(), "Nishat", "Sadaf", "Lira", "CSE" };
            //Student.Add(noOfStudents+1, manualStudent1);
            //Student.Add(noOfStudents+2, manualStudent2);

            ////Printing the List
            //Console.WriteLine(" ");
            //Console.WriteLine("ID, First Name, Middle-Name, Last-Name, Department");
            //for (i = noOfStudents+1; i <= noOfStudents+2; i++)
            //{
            //    int countingNoOfListElements = 1;
            //    foreach (string i_ListElement in Student[i])
            //    {
            //        if (countingNoOfListElements < 5)
            //            Console.Write(i_ListElement + ", ");
            //        else
            //            Console.Write(i_ListElement + " ");
            //        countingNoOfListElements++;
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("");
            //List<string> listStudent = new List<string>();
            //listStudent.Add("1");
            //listStudent.Add("Tasnia");
            //listStudent.Add("Haque");
            //listStudent.Add("Kheya");
            //listStudent.Add("CSE");
            //listStudent.Add("2");
            //listStudent.Add("Radia");
            //listStudent.Add("Shaulin");
            //listStudent.Add("Ananna");
            //listStudent.Add("Dental");
            //int flag = 0;
            //Console.WriteLine("ID, First Name, Middle-Name, Last-Name, Department");
            //foreach (string element in listStudent)
            //{
            //    flag++;
            //    if(flag % 5 == 1)
            //    {
            //        Console.Write(element + ", ");
            //    }
            //    if (flag % 5 == 2)
            //    {
            //        Console.Write(element + ", ");
            //    }
            //    if (flag % 5 == 3)
            //    {
            //        Console.Write(element + ", ");
            //    }
            //    if (flag % 5 == 4)
            //    {
            //        Console.Write(element + ", ");
            //    }
            //    if (flag % 5 == 0)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}



        }

    }
}
