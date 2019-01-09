using System;

namespace preWork
{
    class Controller
    {
        public static string input1()
        {
            string charInput = Console.ReadLine();
        
            return charInput;
        }

        public static string input2()
        {
            string numInput = Console.ReadLine();

            return numInput;
        }
        
    }

    class View
    {
        public static void openingText()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("We're gonna repeat characters!");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Please enter a character:");
        }

        public static void followUpText()
        {
            Console.WriteLine("And the number of times you want it repeated:");
        }
        
    }

    class Model
    {
        public static void Main(string[] args)
        {
            //Displays first chunk of text.
            View.openingText();

            //First set of variables.
            string charInput = Controller.input1();
            char charToRepeat = ' ';
            //Validates the char.
            try
            {
                charToRepeat = makeAChar(charInput);
            }
            catch
            {
                Console.WriteLine("One character only, please.");
                charInput = Controller.input1();
                throw;
            }


            //Displays second chunk of text.
            View.followUpText();

            //Second set of variables.
            string numInput = Controller.input2();
            int timesToRepeat = 0;

            //Makes sure the repeat int is actually an int.
            try
            {
                timesToRepeat = convertIntFromString(numInput);
            }
            catch
            {
                Console.WriteLine("Bad Input, Please enter a number:");
                numInput = Controller.input2();
                throw;
            }
           //Debug, makes sure variables are actually there.
            Console.WriteLine("Char: " + charToRepeat + " Num: " + timesToRepeat);

            Result(charToRepeat, timesToRepeat);
        }


        //Takes raw input, turns it into char.
        public static char makeAChar(string charInput)
        {
            char charConvert = ' ';

            if (charInput.Length > 1)
            {
                throw new Exception("Invalid input.");
            }
            else
            {
                charConvert = Convert.ToChar(charInput);
            }
            return charConvert;
        }

        //takes raw input, turns it into an int.
        public static int convertIntFromString(string numInput)
        {
            int intConvert = 0;

            intConvert = Convert.ToInt32(numInput);

            return intConvert;
        }

         //Builds new string with variables we collected.
        public static void Result(char charToRepeat, int timesToRepeat)
        {
            string result = new String(charToRepeat, timesToRepeat);
            Console.WriteLine(result);
        }
    }
}
