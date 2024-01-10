﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_fundamentals_control_flow.Main
{
    public class Core
    {
        /*
            One of the core building blocks of programming in any language is conditional statements.
            We ask the computer yes / no questions and perform things based on the answer, e.g.
                Do we have milk?
                If yes, make a coffee
                Else buy some milk
            We represent yes and no in code using booleans: true / false. If something is true, do something.
            We ask these questions in this format:
            if (a condition is true) {
                do the thing inside these curly brackets
            } else {
                the condition was false, so do the thing inside these brackets instead
            }
            The result of the yes / no question goes into the "a condition is true" bit. This is usually the result
            of making some kind of comparison, e.g. checking that 1 < 5. Running 1 < 5 will result in the boolean, true.
            Running 1 > 5 will result in the boolean, false.
            if (1 < 5) {
                // 1 is less than 5, so the condition is true and this block runs
            } else {
                // This else block will not run because the condition tested is true, not false
            }
            See the example below, study it and spend some time understanding it before moving on.
         */
        public string sayGoodMorning(bool isMorning)
        {
            if (isMorning)
            {
                return "Good morning!";
            }
            else
            {
                return "Good day!";
            }
        }

        //TODO: 1. What will the output be if I run sayGoodMorning(false)?
        // Change the returned value in the method below to your answer. It is case-sensitive.
        public string one()
        {
            return "Good day!";
        }

        //TODO: 2. What will the output be if I run sayGoodMorning(true)?
        // Change the returned value in the method below to your answer. It is case-sensitive.
        public string two()
        {
            return "Good morning!";
        }

        //TODO: 3. What will the output be if I run sayGoodMorning("Hello" == "Hello")?
        // Change the returned value in the method below to your answer. It is case-sensitive.
        public string three()
        {
            return "Good morning!";
        }

        //TODO: 4. What will the output be if I run sayGoodMorning("A word" != "Another word")
        public string four()
        {
            return "Good morning!";
        }

        // 5. What will the output be if I run sayGoodMorning(25 != 25)
        public string five()
        {
            return "Good day!";
        }

        //TODO: 6. Use a conditional statement to return "Correct!" if the input is more than 7
        // or "Wrong!" if not
        public string six(int num)
        {
            string answer = "";

            if (num > 7)
            {
                answer = "Correct!";
            }
            else
            {
                answer = "Wrong!";
            }
            return answer;
        }

        //TODO: 7. Use a conditional statement to return "Correct!" if the input is false
        // or "Wrong!" if not
        public string seven(bool boolean)
        {
            //throw new NotImplementedException();
            if (boolean)
            {
                return "Wrong!";
            }
            else 
            { 
                return "Correct!";
            }
        }

        //TODO: 8. Use a conditional statement to return "Correct!" if numOne is more than or equal to numTwo
        // or "Wrong!" if not
        public string eight(int numOne, int numTwo)
        {
            if ((numOne == numTwo) || (numOne > numTwo))
            {
                return "Correct!";
            }
            else
            {
                return "Wrong!";
            }
        }

        //TODO: 9. Use a conditional statement to return true if the array provided is not empty
        // or false if it is empty
        public bool nine(int[] nums)
        {
            //throw new NotImplementedException();
            bool boolToReturn = true;

            if (nums.Length == 0)
            {
                boolToReturn = false;
            }

            return boolToReturn;
        }

        //TODO: 10. Use a conditional statement to return true if the provided string contains the word
        // "milk", or false if not
        // https://www.w3schools.com/java/java_ref_string.asp
        public bool ten(string sentence)
        {
            //throw new NotImplementedException();
            bool booleanToReturn = false;

            if (sentence.Contains("milk"))
            {
                booleanToReturn = true;
            }
            return booleanToReturn;
        }

        //TODO: 11. Use conditional statements to return the number 3 if the provided string contains
        // the word milk. Return the number 6 if the provided string contains the word coffee.
        // Return the number 9 if the string contains both coffee and milk.
        // Otherwise, return the number 0.
        public int eleven(string sentence)
        {
            //throw new NotImplementedException();
            int numberToReturn = 0;

            if (sentence.Contains("milk") && !(sentence.Contains("coffee")))
            {
                numberToReturn = 3;
            }
            else if (!(sentence.Contains("milk")) && (sentence.Contains("coffee")))
            {
                numberToReturn = 6;
            }
            else if ((sentence.Contains("milk")) && (sentence.Contains("coffee")))
            {
                numberToReturn = 9;
            }
            return numberToReturn;
        }

        //TODO: 12. Use conditional statements to return true if num is more than or equal to lower and is
        // less than or equal to upper, otherwise return false.
        public bool twelve(int num, int lower, int upper)
        {
            //throw new NotImplementedException();
            bool boolToReturn = false;

            if ((num >= lower) && (num <= upper)) 
            {
                boolToReturn = true;
            }
            return boolToReturn;
        }

        /*
            12. Use conditional statements to return a string based on what the age parameter is.
            The table below shows the string that should be returned for each range of values that age can be.
            For example: If age is 3, you should return "Toddler"
            0       | Baby
            1-4     | Toddler
            5-12    | Child
            13-19   | Teenager
            20+     | Adult
         */
        public string thirteen(int age)
        {
            //throw new NotImplementedException();

            string category = "Null";

            switch (age)
            {
                case int n when (n == 0):
                    category = "Baby";
                    break;

                case int n when ((n >= 1) && (n <= 4)):
                    category = "Toddler";
                    break;

                case int n when ((n >= 5) && (n <= 12)):
                    category = "Child";
                    break;

                case int n when ((n >= 13) && (n <= 19)):
                    category = "Teenager";
                    break;

                case int n when (n >= 20):
                    category = "Adult";
                    break;


            }
            return category;
        }
    }
}
