using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_Exercise_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resource where I located these exercises: https://www.w3resource.com/csharp-exercises/basic/index.php
            Console.WriteLine("Hello!");
            Console.WriteLine("");
            Console.WriteLine("Amanda Bledsoe here, and I completed Exercises 1-10 from the w3resource website for C#.");
            Console.WriteLine("(The website can be located here: https://www.w3resource.com/csharp-exercises/basic/index.php)");
            Console.WriteLine("");
            Console.WriteLine("This program shows you those results - Enjoy!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            #region #1. Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("--Exercise 1--");
            Console.WriteLine("");
            Console.WriteLine("We're simply going to print \"Hello\" and \"your name\" in separate lines.");
            Console.WriteLine("");
            Console.WriteLine("Hello");
            Console.WriteLine("your name");
            Console.WriteLine("");
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #2. Write A C# program to print the sum of two numbers.
            Console.WriteLine("--Exercise 2--");
            Console.WriteLine("");
            Console.WriteLine("We're going to add up some numbers this time!");
            Console.WriteLine("");

            bool summingNums = true;
            while (summingNums)
            {
                bool getNum1 = true;
                while (getNum1)
                {
                    Console.WriteLine("Enter a number:");
                    string input = Console.ReadLine();
                    Console.WriteLine("");
                    int num1;
                    bool yesNum = int.TryParse(input, out num1);
                    if (yesNum)
                    {
                        bool getNum2 = true;
                        while (getNum2)
                        {
                            Console.WriteLine("Enter another number:");
                            string input2 = Console.ReadLine();
                            Console.WriteLine("");
                            int num2;
                            bool yesNumber = int.TryParse(input2, out num2);
                            if (yesNumber)
                            {
                                int sum = num1 + num2;
                                Console.Write("The sum of your numbers is: ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($"{sum}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                getNum2 = false;
                                getNum1 = false;
                                summingNums = false;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that's not a number. Please try again.");
                                Console.WriteLine("");
                                getNum2 = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's not a number. Please try again.");
                        Console.WriteLine("");
                        getNum1 = true;
                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #3. Write a C# Sharp program to print the result of dividing two numbers.
            Console.WriteLine("--Exercise 3--");
            Console.WriteLine("");
            Console.WriteLine("Now, we are going to do a little division with some numbers!");
            Console.WriteLine("");

            bool dividingNums = true;
            while (dividingNums)
            {
                bool getNum1 = true;
                while (getNum1)
                {
                    Console.WriteLine("Enter a number:");
                    string input = Console.ReadLine();
                    Console.WriteLine("");
                    int num1;
                    bool yesNum = int.TryParse(input, out num1);
                    if (yesNum)
                    {
                        bool getNum2 = true;
                        while (getNum2)
                        {
                            Console.WriteLine("Enter another number:");
                            string input2 = Console.ReadLine();
                            Console.WriteLine("");
                            double num2;
                            bool yesNumber = double.TryParse(input2, out num2);
                            if (yesNumber)
                            {
                                if (num2 <= 0)
                                {
                                    Console.WriteLine("I'm sorry, we can't divide a number by zero or anything lower than that. Please enter another number.");
                                    Console.WriteLine("");
                                    getNum2 = true;
                                }
                                else
                                {
                                    double sum = num1 / num2;
                                    Console.Write("The quotient of your numbers is: ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"{sum}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("");
                                    getNum2 = false;
                                    getNum1 = false;
                                    dividingNums = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that's not a number. Please try again.");
                                Console.WriteLine("");
                                getNum2 = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's not a number. Please try again.");
                        Console.WriteLine("");
                        getNum1 = true;
                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #4. Write a C# Sharp program to print the result of the specified operations.
            Console.WriteLine("--Exercise 4--");
            Console.WriteLine("");
            Console.WriteLine("We're going to get the results of a few noted mathematical operations next!");
            Console.WriteLine("");
            // -1 + 4 * 6
            Console.Write("- 1 + 4 * 6 = ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ -1 + 4 * 6}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            // (35 + 5) % 7
            Console.Write("(35 + 5) % 7 = ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{(35 + 5) % 7}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            // 14 + -4 * 6 / 11
            Console.Write("14 + -4 * 6 / 11 = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{14 + -4 * 6 / 11}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            // 2 + 15 / 6 * 1 - 7 % 2
            Console.Write("2 + 15 / 6 * 1 - 7 % 2 = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #5. Write a C# Sharp program to swap two numbers.
            Console.WriteLine("--Exercise 5--");
            Console.WriteLine("");
            Console.WriteLine("For this exercise, we're going to get two numbers and then swap them around!");
            Console.WriteLine("");

            bool swappingNums = true;
            while (swappingNums)
            {
                bool getNum1 = true;
                while (getNum1)
                {
                    Console.WriteLine("Enter you're first number:");
                    string input = Console.ReadLine();
                    int num1;
                    bool yesNum = int.TryParse(input, out num1);
                    if (yesNum)
                    {
                        Console.Write("Excellent! Your first number ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"= {num1}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");

                        bool getNum2 = true;
                        while (getNum2)
                        {
                            Console.WriteLine("Now, enter your second number:");
                            string input2 = Console.ReadLine();
                            int num2;
                            bool yesNumber = int.TryParse(input2, out num2);
                            if (yesNumber)
                            {
                                if (num1 == num2)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine($"Hang on ... {num2} again?");
                                    Console.WriteLine("Swapping numbers that are the same isn't that fun.");
                                    Console.WriteLine("Try again, and let's do two different numbers this time!");
                                    Console.WriteLine("");
                                    getNum2 = false;
                                    getNum1 = true;
                                }
                                else
                                {
                                    Console.Write("Got it! Your second number ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"= {num2}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("");

                                    Console.WriteLine("SWAP TIME!");
                                    Console.WriteLine("");
                                    Console.Write($"Number 1 is no longer ");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write($"{num1}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("... it's now ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write($"{num2}!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("");

                                    Console.Write($"and Number 2 is no longer ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write($"{num2}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("... it's now ");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write($"{num1}!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    getNum2 = false;
                                    getNum1 = false;
                                    swappingNums = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that's not a number. Please try again.");
                                Console.WriteLine("");
                                getNum2 = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's not a number. Please try again.");
                        Console.WriteLine("");
                        getNum1 = true;
                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            Console.WriteLine("--Exercise 6--");
            Console.WriteLine("");
            Console.WriteLine("In this excercise, I want to multiply three of your numbers. Let's do this!");
            Console.WriteLine("");

            bool multiplyingNumbers = true;
            while (multiplyingNumbers)
            {
                bool getNum1 = true;
                while (getNum1)
                {
                    Console.Write("Let's have your first number please: ");
                    string userNum1 = Console.ReadLine();
                    Console.WriteLine("");
                    int num1;
                    bool isANum = int.TryParse(userNum1, out num1);
                    if (isANum)
                    {
                        bool getNum2 = true;
                        while (getNum2)
                        {
                            Console.Write("Now let's get your second number: ");
                            string userNum2 = Console.ReadLine();
                            Console.WriteLine("");
                            int num2;
                            bool confirmedNum = int.TryParse(userNum2, out num2);
                            if (confirmedNum)
                            {
                                bool getNum3 = true;
                                while (getNum3)
                                {
                                    Console.Write("Finally, let's get your third number: ");
                                    string userNum3 = Console.ReadLine();
                                    Console.WriteLine("");
                                    int num3;
                                    bool confirmedNumber = int.TryParse(userNum3, out num3);
                                    if (confirmedNumber)
                                    {
                                        int product = num1 * num2 * num3;
                                        Console.WriteLine($"When you multiply {num1} x {num2} x {num3},");
                                        Console.Write($"the product is: ");
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine($"{product}");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("");
                                        getNum3 = false;
                                        getNum2 = false;
                                        getNum1 = false;
                                        multiplyingNumbers = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("That doesn't appear to be a number. Please try again.");
                                        getNum3 = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("That doesn't appear to be a number. Please try again.");
                                getNum2 = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("That doesn't appear to be a number. Please try again.");
                        getNum1 = true;
                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            Console.WriteLine("--Exercise 7--");
            Console.WriteLine("");
            Console.WriteLine("This time, I'm gonna hook you up with a mathematical operation of your choice! (Like a calculator)");
            Console.WriteLine("");

            Console.WriteLine("");
            bool calculating = true;
            while (calculating)
            {
                bool getNumber1 = true;
                while (getNumber1)
                {
                    Console.Write("Enter a number: ");
                    string entry1 = Console.ReadLine();
                    int num1;
                    bool isANum = int.TryParse(entry1, out num1);
                    if (isANum)
                    {
                        bool gettingOp = true;
                        while (gettingOp)
                        {
                            Console.Write("Enter your operation choice (+, -, *, or /): ");
                            string opChoice = Console.ReadLine();
                            if (opChoice == "+" || opChoice == "-" || opChoice == "*" || opChoice == "/")
                            {
                                bool gettingNum2 = true;
                                while (gettingNum2)
                                {
                                    Console.Write("Enter another number: ");
                                    string entry2 = Console.ReadLine();
                                    Console.WriteLine("");
                                    int num2;
                                    bool isANumber = int.TryParse(entry2, out num2);
                                    if (isANumber)
                                    {
                                        if (num2 == 0 && opChoice == "/")
                                        {
                                            Console.WriteLine("Sorry, not possible to divide by 0.");
                                            Console.WriteLine("");
                                            gettingNum2 = true;
                                        }
                                        else if (opChoice == "+")
                                        {
                                            Console.WriteLine($"The result of your operation, ");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write($"{ num1} {opChoice} {num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(",");
                                            Console.Write($"= ");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write($"{ num1 / num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine();
                                            gettingNum2 = false;
                                            gettingOp = false;
                                            getNumber1 = false;
                                            calculating = false;
                                        }
                                        else if (opChoice == "-")
                                        {
                                            Console.WriteLine($"The result of your operation, ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write($"{ num1} {opChoice} {num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(",");
                                            Console.Write($"= ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write($"{ num1 - num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine();
                                            gettingNum2 = false;
                                            gettingOp = false;
                                            getNumber1 = false;
                                            calculating = false;
                                        }
                                        else if (opChoice == "*")
                                        {
                                            Console.WriteLine($"The result of your operation, ");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write($"{ num1} {opChoice} {num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(",");
                                            Console.Write($"= ");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write($"{ num1 * num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine();
                                            gettingNum2 = false;
                                            gettingOp = false;
                                            getNumber1 = false;
                                            calculating = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"The result of your operation, ");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write($"{ num1} {opChoice} {num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(",");
                                            Console.Write($"= ");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write($"{ num1 / num2}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine();
                                            gettingNum2 = false;
                                            gettingOp = false;
                                            getNumber1 = false;
                                            calculating = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("That doesn't appear to be a number. Please try again.");
                                        Console.WriteLine("");
                                        gettingNum2 = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Don't quite recognize that operator. Please try again");
                                Console.WriteLine("");
                                gettingOp = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("That doesn't appear to be a number. Please try again.");
                        Console.WriteLine("");

                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #8. Write a C# Sharp program that takes a number as input and print its multiplication table.
            Console.WriteLine("--Exercise 8--");
            Console.WriteLine("");

            Console.WriteLine("Give me a number, and we'll show you it's multiplication table!");
            Console.WriteLine("");
            bool makingTable = true;
            while(makingTable)
            {
                Console.Write("Enter your number: ");
                string entry8 = Console.ReadLine();
                int numToMultiply;
                bool itsANum = int.TryParse(entry8, out numToMultiply);
                if(itsANum)
                {
                    if(numToMultiply <= 0)
                    {
                        Console.WriteLine("That number isn't a number we can work with. Please try again.");
                        Console.WriteLine("");
                        makingTable = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("{0, -20} {1, -20} {2}", $"1-{numToMultiply}", "x2", "x3");
                        Console.WriteLine("=============================================================");
                        for (int i = 1; i < numToMultiply + 1; i++)
                        {
                            Console.WriteLine("{0, -20} {1, -20} {2}", $"{i}", $"{i*2}", $"{i*3}");
                        }
                        Console.WriteLine("");
                        makingTable = false;
                    }
                }
                else
                {
                    Console.WriteLine("That doesn't appear to be a number. Please try again");
                    makingTable = true;

                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            Console.WriteLine("--Exercise 9--");
            Console.WriteLine("");

            Console.WriteLine("This time, I'll collect 4 numbers from you and return the average of those numbers. Let's go!");
            Console.WriteLine("");
            bool gettingAverages = true;
            while(gettingAverages)
            {
                Console.WriteLine("Begin entering your numbers below: ");
                bool getNumberOne = true;
                while(getNumberOne)
                {
                    Console.Write("Number 1: ");
                    string input1 = Console.ReadLine();
                    double number1;
                    bool confNum = double.TryParse(input1, out number1);
                    if(confNum)
                    {
                        bool getNumberTwo = true;
                        while (getNumberTwo)
                        {
                            Console.Write("Number 2: ");
                            string input2 = Console.ReadLine();
                            double number2;
                            bool confirmNum = double.TryParse(input2, out number2);
                            if (confirmNum)
                            {
                                bool getNumberThree = true;
                                while (getNumberThree)
                                {
                                    Console.Write("Number 3: ");
                                    string input3 = Console.ReadLine();
                                    double number3;
                                    bool confNumber = double.TryParse(input3, out number3);
                                    if (confNumber)
                                    {
                                        bool getNumberFour = true;
                                        while (getNumberFour)
                                        {
                                            Console.Write("Number 4: ");
                                            string input4 = Console.ReadLine();
                                            double number4;
                                            bool confirmedNumber = double.TryParse(input4, out number4);
                                            if (confirmedNumber)
                                            {
                                                double average = (number1 + number2 + number3 + number4) / 4;
                                                Console.WriteLine("");
                                                Console.WriteLine("Time for Averages!");
                                                Console.WriteLine($"The average of the 4 numbers you entered is: ");
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.Write($"{average}");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("");
                                                getNumberOne = false;
                                                getNumberTwo = false;
                                                getNumberThree = false;
                                                getNumberFour = false;
                                                gettingAverages = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("I'm sorry, that doesn't appear to be a number. Please try again.");
                                                getNumberFour = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("I'm sorry, that doesn't appear to be a number. Please try again.");
                                        getNumberThree = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("I'm sorry, that doesn't appear to be a number. Please try again.");
                                getNumberTwo = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that doesn't appear to be a number. Please try again.");
                        getNumberOne = true;
                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            #region #10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            Console.WriteLine("--Exercise 10--");
            Console.WriteLine("");
            Console.WriteLine("This time, we're going to do three mathematical operations using three numbers you provide:");
            Console.WriteLine("First Operation: (x+y).z");
            Console.WriteLine("Second Operation: x.y");
            Console.WriteLine("Third Operation: y.z");
            Console.WriteLine("Let's begin!");
            Console.WriteLine("");
            bool doingOperations = true;
            while(doingOperations)
            {
                bool gettingNumberX = true;
                while(gettingNumberX)
                {
                    Console.Write("Enter Number \"X\": ");
                    string inputX = Console.ReadLine();
                    int numX;
                    bool trueNum = int.TryParse(inputX, out numX);
                    if(trueNum)
                    {
                        bool gettingNumberY = true;
                        while(gettingNumberY)
                        {
                            Console.Write("Enter Number \"Y\": ");
                            string inputY = Console.ReadLine();
                            int numY;
                            bool trueNumber = int.TryParse(inputY, out numY);
                            if (trueNumber)
                            {
                                bool gettingNumberZ = true;
                                while(gettingNumberZ)
                                {
                                    Console.Write("Enter Number \"Z\": ");
                                    string inputZ = Console.ReadLine();
                                    int numZ;
                                    bool trueNumb = int.TryParse(inputZ, out numZ);
                                    if (trueNumb)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Results of the operations based on your inputs are as follows:");
                                        Console.WriteLine("{0, -20} {1, -10} {2, -10} {3}", "First Operation:", "(x+y).z  =", $"({numX}+{numY}).{numZ}", $"Result:{(numX+numY)*numZ}");
                                        Console.WriteLine("{0, -20} {1, -10} {2, -10} {3}", "Second Operation:", "x.y  =", $"{numX}.{numY}", $"Result:{numX * numY}");
                                        Console.WriteLine("{0, -20} {1, -10} {2, -10} {3}", "Third Operation:", "y.z  =", $"{numY}.{numZ}", $"Result:{numY * numZ}");
                                        Console.WriteLine("");
                                        gettingNumberX = false;
                                        gettingNumberY = false;
                                        gettingNumberZ = false;
                                        doingOperations = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("I'm sorry, that doesn't appear to be a number we can work with. Please try again.");
                                        gettingNumberZ = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("I'm sorry, that doesn't appear to be a number we can work with. Please try again.");
                                gettingNumberY = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that doesn't appear to be a number we can work with. Please try again.");
                        gettingNumberX = true;
                    }
                }
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            #endregion
            Console.Clear();
            Console.WriteLine("Exercises 1-10 complete! Onto 11-20 next!");
            Console.WriteLine("See you there!");
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
}
