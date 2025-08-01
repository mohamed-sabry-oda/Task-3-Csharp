using System;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {

            #region problem 1
            //Console.WriteLine("enter a string");
            //checked
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("enter a string");
            //checked
            //{
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(y);

            //}
            #endregion

            #region problem 2
            //Console.WriteLine("enter a number");
            //bool flag = int.TryParse(Console.ReadLine(), out int X);
            //if (flag == true)
            //{
            //    Console.WriteLine(X);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}
            #endregion



            #region problem 3
            //object O1;
            //O1 = new object();
            //O1 = 7;
            //Console.WriteLine(O1);
            //Console.WriteLine(O1.GetHashCode());
            //O1 = "mohamed";
            //Console.WriteLine(O1);
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 120.5;
            //Console.WriteLine(O1);
            //Console.WriteLine(O1.GetHashCode());
            #endregion


            #region problem 4
            //Object O1 = new Object();
            //Object O2 = new Object();
            //Console.WriteLine(O1.GetHashCode()); 
            //Console.WriteLine(O2.GetHashCode());

            //O1 = O2;
            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine(O2.GetHashCode());

            #endregion



            #region problem 5
            //string mystring = "Hello ";
            //Console.WriteLine(mystring);
            //Console.WriteLine(mystring.GetHashCode());

            //mystring = "Hello " + "Hi Willy";
            //Console.WriteLine(mystring);
            //Console.WriteLine(mystring.GetHashCode());
            #endregion


            #region problem 6
            //StringBuilder myStringBuilder = new StringBuilder("Hello, ");
            //Console.WriteLine(myStringBuilder);
            //Console.WriteLine(myStringBuilder.GetHashCode());

            //myStringBuilder.Append("Hi Willy");
            //Console.WriteLine(myStringBuilder);
            //Console.WriteLine(myStringBuilder.GetHashCode());

            #endregion


            #region problem 7
            //// enter num 1
            //Console.WriteLine("enter number 1");
            //int x=int.Parse(Console.ReadLine());
            //// enter num 2
            //Console.WriteLine("enter number 2");
            //int y=int.Parse(Console.ReadLine());

            //// sum
            //// Concat : +Operator
            //string Msg = "res : " + x + " + " + y + " = " + (x + y);
            //Console.WriteLine(Msg);

            //string Msg2 = string.Format("res : {0} + {1} = {2}",x,y,(x+y));
            //Console.WriteLine(Msg2);

            //string Msg3 = $"res : {x} + {y} = {x + y}";
            //Console.WriteLine(Msg3);
            #endregion


            #region problem 8
            //// Start with a base string
            //StringBuilder sb = new StringBuilder("Hello, this is a test string.");
            //Console.WriteLine($"Current string: {sb}");

            //Console.WriteLine();

            //// 1. Append text
            //Console.WriteLine("--- Appending text ---");
            //sb.Append(" This text has been appended.");
            //Console.WriteLine($"After Append(): {sb}");

            //Console.WriteLine();

            //// 2. Replace a substring
            //Console.WriteLine("--- Replacing a substring ---");
            //// Replace "test" with "sample"
            //sb.Replace("test", "sample");
            //Console.WriteLine($"After Replace(): {sb}");

            //Console.WriteLine();

            //// 3. Insert a string at a specific position
            //Console.WriteLine("--- Inserting a string ---");
            //int insertPosition = sb.ToString().IndexOf("a sample") + "a ".Length;
            //sb.Insert(insertPosition, "very ");
            //Console.WriteLine($"After Insert(): {sb}");
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine();

            //// 4. Remove a portion of text
            //sb.Remove(0, 6);
            //Console.WriteLine(sb);
            #endregion
        }
    }
}
