using System;
using System.DirectoryServices;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace DataCollection
{
    public partial class Form1 : Form
    {
        string[] cars1 = { "Volvo", "BMW", "Ford" };
        List<int> lstInt = new List<int>();
        Dictionary<string,string> diction = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();

            //Array Declaration and Data Adding
            string[] cars = new string[3]
            {
           "Volvo","BMW","Ford"
            };
            int[] number = new int[3]
            {
            10,20,30
            };

            int[] number1 = new int[3];
            number1[0] = 1;
            string[] cars2 = new string[10];
            cars2[0] = "Volvo";
            cars2[1] = "BMW";
            cars[2] = "Ford";

            //Data Printing in Array
            Console.WriteLine("Cars in the List :");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            for (int i = 0; i < cars1.Length; i++)
            {
                Console.WriteLine(cars1[i]);
            }


            ///////////////////////////////////////////////////////////////////////////////////
            //List Declaration and Data Adding
            //////////List = ChatGpt

            lstInt.Add(1);
            lstInt.Add(2);
            lstInt.Add(3);
            // lstInt.Add(4);

            foreach (int k in lstInt)
            {
                Console.Write("At Position {0}: ", k);
                Console.WriteLine(k);

            }

            //Using the List<T> constructor
            //It is useful when the elements of the list are known at compile time
            //And I want to initialize the list with those elements directly
            List<int> numberr = new List<int>() { 1, 2, 3, 4, 5, 6 };


            //Using Collection Initializer Sytax
            //It's more concise and visually appealing,
            //especially when I am initializing the list with a small number of elements.
            List<string> countries = new List<string> { "Bangladesh", "America", "South Korea" };


            //Declaring an empty list and then adding the elements
            //This method is useful when I need to dynamically
            //add elements to the list at runtime.
            List<int> marks = new List<int>();
            marks.Add(80);
            marks.Add(90);
            marks.Add(85);

            //AddRange<> == generic version and AddRange == non generic version
            int[] array = { 1, 2, 3, 4, 6, 7 };
            marks.AddRange(array);

            //Implicit type inference
            //It's similar to using the constructor but allows omitting the type
            //when initializing the list.
            List<int> value = new() { 1, 2, 3, 4, 5, 6 };


            ///////////////////////////////////////////////////////////////////////////////
            //Dictionary = Geekforgeeks
            //C# dictionary is the generic collection when I want to store key and value in pairs
            //similar == non generic hashtable
            ///dynamic in nature ->The size of the dictionary can grow according to need
            //In dictionary the key can't be NULL (but value can be) and the keys are unique and the values are of same type
            Dictionary<int, string> exampleDic = new Dictionary<int, string>();
            exampleDic.Add(11, "Bangladesh");
            exampleDic.Add(22, "America");
            exampleDic.Add(33, "India");
            foreach (KeyValuePair<int, string> pair in exampleDic)
            {
                Console.WriteLine("{0} and {1},", pair.Key, pair.Value);
            }

            diction.Add("a", "abcd");
            diction.Add("b", "bcde");
            diction.Add("c", "cdef");
        }
        private void btnArray_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";

            foreach (string car in cars1)
            {
                txtBox.Text += car + " ";
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < lstInt.Count; i++)
            {
                s = s + lstInt[i] + " ";
            }
            MessageBox.Show("Elements of List: " + s);
        }

        private void btnAddArrayData_Click(object sender, EventArgs e)
        {
            string[] newCars1 = new string[cars1.Length + 1];
            Array.Copy(cars1, newCars1, cars1.Length);
            newCars1[cars1.Length] = "Toyota";
            // cars1 = newCars1;
            txtBox.Text = "";
            foreach (string car in newCars1)
            {
                txtBox.Text += car + " ";

            }

        }

        private void btnAddListData_Click(object sender, EventArgs e)
        {
            lstInt.Add(4);
            lstInt.Add(5);
            lstInt.Add(6);
            string s = "";
            for (int i = 0; i < lstInt.Count; i++)
            {
                s = s + lstInt[i] + " ";
            }
            MessageBox.Show("Elements of List: " + s);
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            ///chatGpt
            
          
            ICollection<string> keys = diction.Keys;
            txtBox.Text = "";
            for(int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                txtBox.Text += key + ": " + diction[key] + " ";
               // Console.WriteLine("Key: " + key + ", Value: " + diction[key]);
            }

        }

        private void btnAddDictionData_Click(object sender, EventArgs e)
        {
            diction.Add("d", "defg");
            diction.Add("e", "efgh");
            string s = "";
            ICollection<string> keys = diction.Keys;
            txtBox.Text = "";
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                s += key + ": " + diction[key] + " ";
                // Console.WriteLine("Key: " + key + ", Value: " + diction[key]);
            }
            MessageBox.Show(s);
        }
    }
}
