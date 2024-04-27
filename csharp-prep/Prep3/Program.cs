using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
         
        
        

        Random randomNumber = new Random();
        int MagicNumber = randomNumber.Next (1,101);

        
        int guessnumber = -1;

       while (guessnumber != MagicNumber)
       {
        Console.Write("What is your guess");
        guessnumber = int.Parse(Console.ReadLine());
        if (MagicNumber > guessnumber)
        {Console.WriteLine("Guess a higher number");}

        else if (MagicNumber < guessnumber)
        {Console.WriteLine("Guess a lower number.");}

        else 
        {
            Console.WriteLine("Congratulations. You guessed it!");
        }

       }
    }
}


