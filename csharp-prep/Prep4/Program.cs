using System;
using System.Net;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<float> numberslist = new List<float>();

        float number = -1;
        

        while (number != 0)
       {
        Console.Write("Enter a number or enter 0 to quit");

        string response = Console.ReadLine();
        number = float.Parse(response);

        
            
            
            if (number!= 0)
            { numberslist.Add(number);

            }

        }
        float sum =0;
        foreach (float item in numberslist)
        { sum += item;
            
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum)/numberslist.Count;
        Console.WriteLine($"The average is {average}");

        float max = numberslist[0];

        foreach (float item in numberslist)
        {  if (item > max)
        {max = item;}   
        }
        Console.WriteLine($"The maximum number is {max}");

        float mini = float.MaxValue;

        foreach (float item in numberslist)
        {
            if (item >0  && item <mini)
           {mini = item;}
        }

        if (mini  != float.MaxValue)
            
        {Console.WriteLine($"The smallest positive number is {mini}.");}

            else
            {
                Console.WriteLine("No positive Number was found in the List");
            }
    }
}
            
    

        









































 