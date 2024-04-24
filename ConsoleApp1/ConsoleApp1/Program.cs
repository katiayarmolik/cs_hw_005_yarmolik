using System;

namespace ConsoleApp1
{
    class ForeignPassport
    {
        //    private string number;
        //    private string fullName;
        //    private DateTime dateOfIssue;

        //    public ForeignPassport(string number, string fullName, DateTime dateOfIssue)
        //    {
        //        if (string.IsNullOrEmpty(number))
        //        {
        //            throw new ArgumentException("The passport number cannot be empty or null");
        //        }
        //        if (string.IsNullOrEmpty(fullName))
        //        {
        //            throw new ArgumentException("The owner name cannot be empty or null");
        //        }
        //        if (dateOfIssue > DateTime.Now)
        //        {
        //            throw new ArgumentException("The issue date cannot be in the future");
        //        }

        //        this.number = number;
        //        this.fullName = fullName;
        //        this.dateOfIssue = dateOfIssue;
        //    }

        //    public string Number
        //    {
        //        get { return number; }
        //    }

        //    public string FullName
        //    {
        //        get { return fullName; }
        //    }

        //    public DateTime DateOfIssue
        //    {
        //        get { return dateOfIssue; }
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        try
        //        {
        //            ForeignPassport passport = new ForeignPassport("dfghj", "Andriy Kravets", new DateTime(2024, 1, 1));
        //            Console.WriteLine("Passport number: " + passport.Number);
        //            Console.WriteLine("Owner name: " + passport.FullName);
        //            Console.WriteLine("Date of issue: " + passport.DateOfIssue.ToShortDateString());
        //        }
        //        catch (ArgumentException ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //        }
        //}









        //static void Main()
        //{
        //    Console.WriteLine("Enter a logical expression (example 3 > 2 or 7 < 3):");
        //    string input = Console.ReadLine();

        //    try
        //    {
        //        bool result = EvaluateExpression(input);
        //        Console.WriteLine("Result:" + result);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error: The format of the entered expression is incorrect.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error:" + ex.Message);
        //    }
        //}

        //static bool EvaluateExpression(string expression)
        //{
        //    string[] parts = expression.Split(' ');
        //    if (parts.Length != 3)
        //    {
        //        throw new FormatException("Invalid number of elements in expression.");
        //    }

        //    if (!int.TryParse(parts[0], out int operand1) || !int.TryParse(parts[2], out int operand2))
        //    {
        //        throw new FormatException("The number format in the expression is incorrect.");
        //    }

        //    string op = parts[1];
        //    switch (op)
        //    {
        //        case "<":
        //            return operand1 < operand2;
        //        case ">":
        //            return operand1 > operand2;
        //        case "<=":
        //            return operand1 <= operand2;
        //        case ">=":
        //            return operand1 >= operand2;
        //        case "==":
        //            return operand1 == operand2;
        //        case "!=":
        //            return operand1 != operand2;
        //        default:
        //            throw new FormatException("Error.");
            }
        }
    }
}