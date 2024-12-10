using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {


        //1-Write a program that takes a number from the user then print yes if
        //that number can be divided by 3 and 4 otherwise print no.
        #region Number1:
        /*
        Console.Write("Enter a number: ");
        int number;


        if (int.TryParse(Console.ReadLine(), out number))
        {

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
         */
        #endregion
        //2-Write a program that allows the user to insert an integer
        //then print negative if it is negative number otherwise print positive.
        #region Number2:
        /*
        Console.Write("Enter an integer: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        */
        #endregion
        //3-Write a program that takes 3 integers from the
        //user then prints the max element and the min element.
        #region Number3:
        /*
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third integer: ");
        int num3 = int.Parse(Console.ReadLine());
        int max = Math.Max(num1, Math.Max(num2, num3));
        int min = Math.Min(num1, Math.Min(num2, num3));
        Console.WriteLine($"Maximumelement: {max}");
        Console.WriteLine($"Minimumelemet: {min}");
        */
        #endregion
        //4-Write a program that allows the user to insert an integer number
        //then check If a number is even or odd.
        #region Number4:
        /*
        Console.Write("Enter an integer: ");
        int number;


        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        */
        #endregion
        //5-Write a program that takes character from the user then
        //if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
        #region Number5:
        /*
        Console.Write("Enter a single character: ");
        char input;

        if (char.TryParse(Console.ReadLine(), out input))
        {
            char lowerInput = char.ToLower(input);
            if (lowerInput == 'a' || lowerInput == 'e' || lowerInput == 'i' || lowerInput == 'o' || lowerInput == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsLetter(lowerInput))
            {
                Console.WriteLine("consonant");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a letter.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid character.");
        }
        */
        #endregion
        // 6-Write a program that allows the user to insert an
        // integer then print all numbers between 1 to that number.
        #region Number6:

        /*
        Console.Write("Enter a positive integer: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            Console.WriteLine("Numbers from 1 to {0}:", number);
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        */
        #endregion
        //7- Write a program that allows the user to insert an integer then 
        //print a multiplication table up to 12.
        #region Number7:
        /*
                Console.Write("Enter an integer: ");
        int number;


        if (int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        */
        #endregion
        //8 - Write a program that allows to user to insert 
        //number then print all even numbers between 1 to this number
        #region Number8:
        /*
        Console.Write("Enter a positive integer: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            Console.WriteLine($"Even numbers from 1 to {number}:");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        */
        #endregion
        //9- Write a program that takes two integers then prints the power.
        #region Number9:
        /*

        Console.Write("Enter the base number: ");
        int baseNumber;


        while (!int.TryParse(Console.ReadLine(), out baseNumber))
        {
            Console.Write("Invalid input. Please enter a valid integer for the base number: ");
        }


        Console.Write("Enter the exponent: ");
        int exponent;

        while (!int.TryParse(Console.ReadLine(), out exponent))
        {
            Console.Write("Invalid input. Please enter a valid integer for the exponent: ");
        }

        double result = Math.Pow(baseNumber, exponent);

        Console.WriteLine($"{baseNumber} to the power of {exponent} is {result}");
            */
        #endregion
        //10- Write a program to enter marks of five subjects and calculate total,
        //average and percentage.
        #region Number10:
        /*
        int total = 0; 
        const int numberOfSubjects = 5; 
        const int maxMarksPerSubject = 100; 

        Console.WriteLine("Enter marks for five subjects (out of 100):");


        for (int i = 1; i <= numberOfSubjects; i++)
        {
            int marks;
            Console.Write($"Subject {i}: ");
            while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > maxMarksPerSubject)
            {
                Console.Write($"Invalid input. Please enter marks between 0 and {maxMarksPerSubject} for Subject {i}: ");
            }
            total += marks; // Add valid marks to the total
        }


        double average = total / (double)numberOfSubjects;
        double percentage = (total / (double)(numberOfSubjects * maxMarksPerSubject)) * 100;


        Console.WriteLine($"\nTotal Marks: {total}");
        Console.WriteLine($"Average Marks: {average:F2}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        */
        #endregion
        //11- Write a program to input the month number and print
        //the number of days in that month.
        #region Number11:
        /*
     Console.Write("Enter the month number (1-12): ");
     int monthNumber;
     if (int.TryParse(Console.ReadLine(), out monthNumber) && monthNumber >= 1 && monthNumber <= 12)
     {
         int daysInMonth;
         switch (monthNumber)
         {
             case 1: // يناير
             case 3: // مارس
             case 5: // مايو
             case 7: // يوليو
             case 8: // أغسطس
             case 10: // أكتوبر
             case 12: // ديسمبر
                 daysInMonth = 31;
                 break;
             case 4: // إبريل
             case 6: // يونيو
             case 9: // سبتمبر
             case 11: // نوفمبر
                 daysInMonth = 30;
                 break;
             case 2:
                     // طلب السنة فقط في حالة شهر فبراير
                 Console.Write("Enter the year: ");
                 int year;
                 if (int.TryParse(Console.ReadLine(), out year))
                 {
                     // التحقق من السنة الكبيسة
                     if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                     {
                         daysInMonth = 29; // سنة كبيسة
                     }
                     else
                     {
                         daysInMonth = 28; // سنة غير كبيسة
                     }
                 }
                 else
                 {
                     Console.WriteLine("Invalid year input.");
                     return;
                 }
                 break;
             default:
                 daysInMonth = 0; // لا ينبغي أن يحدث هذا بسبب التحقق من الإدخال
                 break;
         }


         Console.WriteLine($"The number of days in month {monthNumber} is {daysInMonth}.");
     }
     else
     {
         Console.WriteLine("Invalid input. Please enter a month number between 1 and 12.");
     }

 */
        #endregion
        //12- Write a program to create a Simple Calculator.
        #region Number12:
        /*
        double num1, num2, result;
        string operation;

        // Display the calculator options
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Choose an operation: ");
        Console.WriteLine("1. Add (+)");
        Console.WriteLine("2. Subtract (-)");
        Console.WriteLine("3. Multiply (*)");
        Console.WriteLine("4. Divide (/)");


        Console.Write("Enter the operation: ");
        operation = Console.ReadLine();
        Console.Write("Enter the first number: ");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input for the first number.");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input for the second number.");
            return;
        }
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"The result of {num1} + {num2} is {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"The result of {num1} - {num2} is {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"The result of {num1} * {num2} is {result}");
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"The result of {num1} / {num2} is {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                break;
        }
        */
        #endregion
    }
}