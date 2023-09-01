using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_control_flow.Main
{
    public class Extension
    {


        /* 
         Extension: 1.  We're going to improve our cake baking capabilities!
        //TODO: Create a public method named timerStatus that accepts one parameter:
        - the number of minutes left on the timer
        The method must return "The cake is ready!" if the remaining minutes is 0,
        "The cake is still baking!" if there are any remaining minutes left,
        and "The timer finished ages ago!" if the remaining minutes is a negative number
        */
        public string timerStatus(int minutes)
        {
            if (minutes == 0)
                return "The cake is ready!";
            else if (minutes > 0)
                return "The cake is still baking!";
            else
                return "The timer finished ages ago!";
        }



        //TODO: Extension: 2. Create a method named estimatePrepTime that accepts two parameters:
        /*  - an array of ingredients, e.g. ["sugar", "milk", "flour", "eggs"]
            - the prep time per ingredient in minutes
            The method must return the total prep time required based on the number of ingredients
            provided and the prep time per ingredient.
            If a prep time of 0 is provided, the method should assume each ingredient takes 2 minutes to prepare.
         */


        public int estimatePrepTime(string[] ingredients, int time)
        {
            int perIngreTime = (time == 0) ? 2 : time; //check if time is zero, if time is zero then two is asigned to perIngreTime,otherwise the time is asigned to perIngreTime
            return ingredients.Length * perIngreTime; // return the amount of ingredients multiplied by the prep time
        }

        //TODO: 3.  Create a method named calculateGramsOfSugar that accepts two parameters:
        /*  - an array of ingredients that will always contain 3 ingredients
            - the number of layers the cake has
            The cake will need 100g of sugar per layer, if that ingredient is present in the provided list of ingredients.
            The method should return the number of grams of sugar needed to make the cake.
         */
        // https://learn.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-7.0   used this one
        public int calculateGramsOfSugar(string[] ingredients, int layers)
        {
            bool hasItSugar = Array.Exists(ingredients, ingredient => ingredient.ToLower() == "sugar"); // Checking if sugar exists in array. ToLower to be sure the sugar is case-insinsitive
            if (hasItSugar)
            {
                return layers * 100;      //for 100 gram is each layer
            }
            else
            {
                return 0;
            }
        }
    }
}
