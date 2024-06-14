// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    static void Main(string[] args)
    {
        int Numdays = GetNumdays();
        string message = NewDay(Numdays);
        Console.WriteLine(message);
    }

    static string NewDay(int Numdays)
    {
        Console.Write("Input number to add to the day: ");
        int Adddays = Convert.ToInt16(Console.ReadLine());

        int Days = (Numdays + Adddays - 1) % 7 + 1;
        string day=" ";
        switch (Days)
        {
            case 1:		
                day= "The day is MONDAY";
                break;
            case 2:
                day="The day is TUESDAY";
                break;
            case 3:
                day="The day is WEDNESDAY";
                break;
            case 4:
                day="The day is THURSDAY";
                break;
            case 5:
                day="The day is FRIDAY";
                break;
            case 6:
                day= "The day is SATURDAY";
                break;
            case 7:
                day= "The day is SUNDAY";
                break;
            default:
                day="Invalid Input.";
                break;
        }

        return$"{day}";
    }

    static int GetNumdays()
    {
        Console.Write("Enter a number between 1 to 7: ");
        int Numdays = Convert.ToInt16(Console.ReadLine());

        switch (Numdays)
        {
            case 1:
                Console.WriteLine("The day is MONDAY");
                break;
            case 2:
                Console.WriteLine("The day is TUESDAY");
                break;
            case 3:
                Console.WriteLine("The day is WEDNESDAY");
                break;
            case 4:
                Console.WriteLine("The day is THURSDAY");
                break;
            case 5:
                Console.WriteLine("The day is FRIDAY");
                break;
            case 6:
                Console.WriteLine("The day is SATURDAY");
                break;
            case 7:
                Console.WriteLine("The day is SUNDAY");
                break;
            default:
                Console.WriteLine("Invalid Input.");
                break;
        }

        return Numdays;
    }
}


