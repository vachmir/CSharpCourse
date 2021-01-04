using System;
using System.Collections.Generic;
using System.Text;

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
        public void ConditionalsSwitch()
        {
            static void ShowCard(int cardNumber)
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
        }
    }
}
