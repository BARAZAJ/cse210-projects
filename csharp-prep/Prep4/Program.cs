using System;
using System.Net;
using System.Collection.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numberslist = new List<int>();

        int number = -1;

        while (number != 0)

        {
            Console.Write("Enter a number or enter 0 to quit");
            string response = Console.ReadLine();
            number = float.Parse(response);
            
            if (number!= 0)
            { numberslist.Add(number);

            }

        }
        int sum =0;
        foreach (float number in numberslist)
        { sum += number;
            
        }
        console.WriteLine($"The sum is {sum}");

        float average = ((float)sum)/number.Count;
        console.WriteLine($"The average is {average}");

        float maximum = numberslist[0];

        foreach (float number in numberslist)
        {  if (number > maximum)
        {maximum = number;}   
        }
        Console.WriteLine($"The maximum number is {maximu}");









































    }
}