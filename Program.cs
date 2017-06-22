using System;
public class Exercise5
{
       public static void Main(string[] args)
         {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : "); //writes the message to the console
            number1 = int.Parse(Console.ReadLine()); //sets the var to the user input
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1; //sets temp var = #1
            number1 = number2; //moves the value of #2 to #1
            number2 = temp; //moves the original value of #1 to #2
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : "+number1);
            Console.Write("\nSecond Number : "+number2);
            Console.Read();
        }
}
