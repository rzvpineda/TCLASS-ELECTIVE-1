using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("ENROLLMENT AND TUITION ASSESSMENT");
        Console.WriteLine("========================================");

        Console.Write("Student ID : ");
        string id = Console.ReadLine();

        Console.Write("Full Name  : ");
        string name = Console.ReadLine();

        Console.Write("Age        : ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("COURSES");
        Console.WriteLine("1 - BSIT");
        Console.WriteLine("2 - BSCS");
        Console.WriteLine("3 - BSIS");
        Console.WriteLine("4 - BSEMC");

        Console.Write("Select Course : ");
        int courseChoice = Convert.ToInt32(Console.ReadLine());

        string course = "";

        switch (courseChoice)
        {
            case 1:
                course = "BSIT";
                break;

            case 2:
                course = "BSCS";
                break;

            case 3:
                course = "BSIS";
                break;

            case 4:
                course = "BSEMC";
                break;

            default:
                course = "Invalid";
                break;
        }

        Console.WriteLine();

        Console.WriteLine("YEAR LEVEL");
        Console.WriteLine("1 - First Year");
        Console.WriteLine("2 - Second Year");
        Console.WriteLine("3 - Third Year");
        Console.WriteLine("4 - Fourth Year");

        Console.Write("Select Year Level : ");
        int yearChoice = Convert.ToInt32(Console.ReadLine());

        string year = "";

        switch (yearChoice)
        {
            case 1:
                year = "First Year";
                break;

            case 2:
                year = "Second Year";
                break;

            case 3:
                year = "Third Year";
                break;

            case 4:
                year = "Fourth Year";
                break;

            default:
                year = "Invalid";
                break;
        }

        Console.WriteLine();

        Console.Write("Tuition Fee        : ");
        double tuition = Convert.ToDouble(Console.ReadLine());

        Console.Write("Miscellaneous Fee  : ");
        double misc = Convert.ToDouble(Console.ReadLine());

        Console.Write("Laboratory Fee     : ");
        double lab = Convert.ToDouble(Console.ReadLine());

        double total = tuition + misc + lab;

        Console.WriteLine();

        Console.Write("Scholarship? (Y/N) : ");
        string scholar = Console.ReadLine().ToUpper();

        double discount = 0;
        double balance = total;

        if (scholar == "Y")
        {
            Console.Write("Scholarship Percentage : ");
            double percent = Convert.ToDouble(Console.ReadLine());

            discount = total * (percent / 100);
            balance = total - discount;
        }

        Console.WriteLine();

        Console.Write("General Average : ");
        double average = Convert.ToDouble(Console.ReadLine());

        string standing = "";

        if (average >= 95)
            standing = "Outstanding";
        else if (average >= 90)
            standing = "Excellent";
        else if (average >= 85)
            standing = "Very Good";
        else if (average >= 80)
            standing = "Good";
        else if (average >= 75)
            standing = "Passed";
        else
            standing = "Failed";

        Console.WriteLine();

        Console.WriteLine("PAYMENT METHOD");
        Console.WriteLine("1 - Cash");
        Console.WriteLine("2 - Installment");
        Console.WriteLine("3 - Online Payment");

        Console.Write("Choose : ");
        int paymentChoice = Convert.ToInt32(Console.ReadLine());

        string payment = "";

        switch (paymentChoice)
        {
            case 1:
                payment = "Cash";
                break;

            case 2:
                payment = "Installment";
                break;

            case 3:
                payment = "Online Payment";
                break;

            default:
                payment = "Invalid";
                break;
        }

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("ENROLLMENT SUMMARY");
        Console.WriteLine("========================================");

        Console.WriteLine($"Student ID : {id}");
        Console.WriteLine($"Name       : {name}");
        Console.WriteLine($"Age        : {age}");
        Console.WriteLine($"Course     : {course}");
        Console.WriteLine($"Year Level : {year}");

        Console.WriteLine();

        Console.WriteLine($"Total Fees           : {total:F2}");
        Console.WriteLine($"Scholarship Discount : {discount:F2}");
        Console.WriteLine($"Remaining Balance    : {balance:F2}");

        Console.WriteLine();

        Console.WriteLine($"Academic Standing : {standing}");
        Console.WriteLine($"Payment Method    : {payment}");

        Console.WriteLine();

        if (balance == 0)
            Console.WriteLine("Status : Fully Paid");
        else
            Console.WriteLine("Status : Balance Remaining");
    }
}