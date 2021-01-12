using System;
using System.IO;

namespace BaisicOperations
{
    class Conditionals
    {
        public void ConditionalsIf()
        {
            if (true)
            {
                if (false)
                    Console.WriteLine("This will never execute");
                else
                    Console.WriteLine("executes");
            }
            else
            {
                Console.WriteLine("This will never execute");
            }
        }
        public void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1: // Joker is -1
                    goto case 12; // In this game joker counts as queen
                default: // Executes for any other cardNumber
                    Console.WriteLine(cardNumber);
                    break;
            }
        }
      
        public string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11: // special cases for 11th to 13th
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;
                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }
        public void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Console.WriteLine($"{CardinalToOrdinal(number)} ");
            }
            Console.WriteLine();
        }

        public string CardinalToOrdinalAm(int number)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            switch (number)
            {
                case 1:
                    return "առաջին";
                case 2:
                    return "երկրորդ";
                case 3:
                    return "երրորդ";
                case 4:
                    return "չորրորդ";
                default:
                    return $"{number}երորդ";
                    break;
            }
        }
        public void RunCardinalToOrdinalAm()
        {
            for (int number = 1; number <= 40; number++)
            {
                Console.WriteLine($"{CardinalToOrdinalAm(number)} ");
            }
            Console.WriteLine();            
        }
    }
}
