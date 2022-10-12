using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {

        Stack<string> s = new Stack<string>();

        string result;
        string temp;
        do
        {
            if (n % 15 == 0)
            {
                temp = "FizzBuzz";

            }
            else
            {
                if (n % 3 == 0)
                {
                    temp = "Fizz";
                }
                else if (n % 5 == 0)
                {
                    temp = "Buzz";
                }
                else
                {
                    temp = n.ToString();
                }
            }

            s.Push(temp);

            n--;

        }
        while (n > 0);

        int len = s.Count();


        for (int i = 0; i < len; i++)
        {

 result = s.Pop();
            Console.WriteLine(result);
        }
           
        
       



    }




}
class Solution
{



    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
