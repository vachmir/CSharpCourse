using System;

namespace BaisicOperations
{

    class Program
    {

        static void Main(string[] args)
        {
            Conditionals conditionals = new Conditionals();
            conditionals.ShowCard(12);

            conditionals.RunCardinalToOrdinal();

            string x =  conditionals.CardinalToOrdinalAm(13);
            Console.WriteLine(x);
            conditionals.RunCardinalToOrdinalAm();

            //string[] exceptions = new string[] { "բեռ", "գառ", "դուռ", "եզ", "թոռ", "լեռ", "ծոռ", "ծունկ", "ձուկ", "մուկ", "նուռ", "մատ", "հարս" }; //Must have "ներ" suffix

        }
    }
}
