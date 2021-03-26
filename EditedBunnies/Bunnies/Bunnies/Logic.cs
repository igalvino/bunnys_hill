using bunnys_hill;
using System;

namespace Bunnies
{
    public class Logic
    {

        const int MAX_AGE = 11; //0 - 10 (useless)

        const int InitialAge = 0;


        /// <summary>
        /// A method for generating random bunnies.
        /// </summary>
        /// <param name="numberOfBunnies"> How many bunnies to generate</param>
        /// <returns> An array of the generated bunnies </returns>
        public static Bunny[] GenerateRandomBunnies(int numberOfBunnies)
        {
            Bunny[] bunny_arr = new Bunny[numberOfBunnies];

            Random random = new Random();
            for (int i = 0; i < numberOfBunnies; i++)
            {
                int generatedSex = random.Next(Enum.GetNames(typeof(Sex)).Length);
                int generatedColor = random.Next(Enum.GetNames(typeof(Color)).Length);

                Console.Write("Please, Enter Bunny's name: ");

                string givenName = Console.ReadLine();

                Bunny generatedBunny = new Bunny(givenName, generatedSex, generatedColor, InitialAge);

                bunny_arr[i] = generatedBunny;
            }

            return bunny_arr;
        }

        /// <summary>
        /// A method to print bunnies details.
        /// </summary>
        /// <param name="bunnies"></param>
        public static void PrintBunnies(Bunny[] bunnies)
        {
            for (int i = 0; i < bunnies.Length; i++)
            {
                Console.WriteLine("Hi, I am a bunny with Sex : " + bunnies[i].Sex  + "\n" + "Color: " + bunnies[i].Color);
            }
        }
    }
}
