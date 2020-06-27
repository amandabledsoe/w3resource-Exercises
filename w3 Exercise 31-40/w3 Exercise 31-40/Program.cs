using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace w3_Exercise_31_40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resource where I located these exercises: https://www.w3resource.com/csharp-exercises/basic/index.php
            ProgramIntroduction();
            #region #31. Write a C# program to multiply corresponding elements of two arrays of integers. 
            IntroduceExercise31();
            bool multiplyingElements = true;
            while(multiplyingElements)
            {
                Console.WriteLine("Give me your FIRST letter choice of A, B, C, D or E: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string letter1 = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.White;
                int numberOne = GetEvenNumberChoiceForExercise31(letter1);
                switch(numberOne)
                {
                    case -1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid selection. Please try again.");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    default:
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Give me your SECOND letter choice of A, B, C, D or E: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string letter2 = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.White;
                int numberTwo = GetOddNumberChoiceForExercise31(letter2);
                switch(numberTwo)
                {
                    case -1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid selection. Please try again.");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    default:
                        break;
                }
                int result = numberOne * numberTwo;
                Console.WriteLine("");
                Console.WriteLine($"Your Letter: {letter1} -- The Correlating Even Number: {numberOne}");
                Console.WriteLine($"Your Letter: {letter2} -- The Correlating Odd Number: {numberTwo}");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"The product of those two numbers: {result}");
                Console.ForegroundColor = ConsoleColor.White;
                multiplyingElements = false;
            }
            #endregion
            SegueSyntax();
            #region #32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.
            IntroduceExercise32();
            bool makingCopies = true;
            while(makingCopies)
            {
                Console.WriteLine("Give me a word that is at least 4 letters long: ");
                string userWord = Console.ReadLine();
                if(userWord.Count() >= 4)
                {
                    Console.WriteLine(GetLastLetterAndPrintCopiesForExercise32(userWord));
                    makingCopies = false;
                }
                else
                {
                    Console.WriteLine("That's not 4 letters or more. Please try again.");
                    Console.WriteLine("");
                    makingCopies = true;
                }
            }
            #endregion
            SegueSyntax();
            #region #33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
            IntroduceExercise33();
            bool checkingMultiples = true;
            while(checkingMultiples)
            {
                Console.WriteLine("Give me a positive & whole number of your choice: ");
                string userNumberInput = Console.ReadLine();
                int userNumber;
                bool isANumber = int.TryParse(userNumberInput, out userNumber);
                if(isANumber)
                {
                    Console.WriteLine(CheckNumberMultiplesForExercise33(userNumber));
                    checkingMultiples = false;
                }
                else
                {
                    Console.WriteLine("That's not a number, friend. Please try again.");
                    checkingMultiples = true;
                }
            }
            #endregion
            SegueSyntax();
            #region #34. Write a C# program to check if a string starts with a specified word.
            IntroduceExercise34();
            bool checkingSentences = true;
            while(checkingSentences)
            {
                Console.WriteLine("Go ahead, write out a sentence of your choice!");
                string userSentence = Console.ReadLine();
                if(userSentence.StartsWith("The"))
                {
                    Console.WriteLine("Your sentence DOES begin with the \"The\"!");
                    checkingSentences = false;
                }
                else
                {
                    Console.WriteLine("Your sentence does NOT begin with \"The\".");
                    checkingSentences = false;
                }
            }
            #endregion
            SegueSyntax();
            #region #35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200. 
            #endregion
            SegueSyntax();
            #region #36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. 
            #endregion
            SegueSyntax();
            #region #37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
            #endregion
            SegueSyntax();
            #region #38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".
            #endregion
            SegueSyntax();
            #region #39. Write a C# program to find the largest and lowest values from three integer values.
            #endregion
            SegueSyntax();
            #region #40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. 
            #endregion
            ProgramClose();
            Environment.Exit(0);
        }
        #region General Methods
        public static void ProgramIntroduction()
        {

        }
        public static void SegueSyntax()
        {
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ProgramClose()
        {

        }
        #endregion
        #region #31 Methods
        public static void IntroduceExercise31()
        {
            Console.WriteLine("--Exercise 31--");
            Console.WriteLine("");
            Console.WriteLine("In this example, we'll work with three collections and each one has 5 elements:");
            Console.WriteLine("{0, -4} {1, -5} {2}", "", "-", "The first collection is an array of even numbers.");
            Console.WriteLine("{0, -4} {1, -5} {2}", "", "-", "The second collection is an array of odd numbers.");
            Console.WriteLine("{0, -4} {1, -5} {2}", "", "-", "The third collection is a list of letters.");
            Console.WriteLine("");
            Console.WriteLine("You'll use the third collection to indicate two positions of your choice.");
            Console.WriteLine("(EXAMPLE: A = position 1, B = position 2, etc.)");
            Console.WriteLine("");
            Console.WriteLine("Then, we'll select even and odd numbers from their various lists in the selected position.");
            Console.WriteLine("Finally, we'll multiply those two numbers and display the product. ");
            Console.WriteLine("");
            Console.WriteLine("Ready?! Let's do this!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static int GetEvenNumberChoiceForExercise31(string letter)
        {
            int[] evens = new int[5] { 0, 2, 4, 6, 8 };

            List<string> letterOptions = new List<string>() { "A", "B", "C", "D", "E" };
            int numberOne;
            if (letterOptions.Contains(letter))
            {
                numberOne = letterOptions.IndexOf(letter);
                return evens[numberOne];
            }
            return -1;
        }
        public static int GetOddNumberChoiceForExercise31(string letter)
        {
            int[] evens = new int[5] { 1, 3, 5, 7, 9 };

            List<string> letterOptions = new List<string>() { "A", "B", "C", "D", "E" };
            int numberOne;
            if (letterOptions.Contains(letter))
            {
                numberOne = letterOptions.IndexOf(letter);
                return evens[numberOne];
            }
            return -1;
        }
        #endregion
        #region #32 Methods
        public static void IntroduceExercise32()
        {
            Console.WriteLine("--Exercise 32--");
            Console.WriteLine("");
            Console.WriteLine("In this example, we'll work with a word that you provide and I'll get the last letter of it.");
            Console.WriteLine("Then, I'll take that letter and print it out 4 times.");
            Console.WriteLine("");
            Console.WriteLine("Ready?! Let's do this!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static string GetLastLetterAndPrintCopiesForExercise32(string userWord)
        {
            char lastLetter = userWord.Last();
            string fourCopies = string.Format("{0}{1}{2}{3}", $"{lastLetter}", $"{lastLetter}", $"{lastLetter}", $"{lastLetter}");
            return fourCopies;
        }
        #endregion
        #region #33 Methods
        public static void IntroduceExercise33()
        {
            Console.WriteLine("--Exercise 33--");
            Console.WriteLine("");
            Console.WriteLine("In this example, we'll work with a number that you provide. The number must be a positive number.");
            Console.WriteLine("Then, I'll let you know if the number is a multiple of 3 or 7 or neither.");
            Console.WriteLine("");
            Console.WriteLine("Ready?! Let's do this!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static string CheckNumberMultiplesForExercise33(int userNumber)
        {
            if (userNumber < 0)
            {
                return "We asked for positive numbers, remember? Please try again";
            }
            else if (userNumber < 3)
            {
                return "The numbers 1 & 2 really don't work well for this exercise ... please try again.";
            }
            else if (userNumber % 3 == 0 && userNumber % 7 == 0)
            {
                return "Your number is a multiple of both 3 AND 7!";
            }
            else if (userNumber % 3 == 0)
            {
                return "Your number IS a multiple of 3!";
            }
            else if (userNumber % 7 == 0)
            {
                return "Your number IS a multiple of 7!";
            }
            else
            {
                return "That number isn't a multiple of either 3 or 7.";
            }
        }
        #endregion
        #region #34 Methods
        public static void IntroduceExercise34()
        {
            Console.WriteLine("--Exercise 34--");
            Console.WriteLine("");
            Console.WriteLine("In this example, we'll work with a sentance you provide.");
            Console.WriteLine("Then, I'll let you know if the sentance does or does not begin with the word \"The\".");
            Console.WriteLine("");
            Console.WriteLine("Ready?! Let's do this!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
        #endregion
        #region #35 Methods
        public static void IntroduceExercise35()
        {

        }
        #endregion
        #region #36 Methods
        public static void IntroduceExercise36()
        {

        }
        #endregion
        #region #37 Methods
        public static void IntroduceExercise37()
        {

        }
        #endregion
        #region #38 Methods
        public static void IntroduceExercise38()
        {

        }
        #endregion
        #region #39 Methods
        public static void IntroduceExercise39()
        {

        }
        #endregion
        #region #40 Methods
        public static void IntroduceExercise40()
        {

        }
        #endregion
    }
}