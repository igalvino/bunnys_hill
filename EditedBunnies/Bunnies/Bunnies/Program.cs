using bunnys_hill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    public class Program
    {
        static void Main(string[] args)
        {

            Bunny[] bunnies;//creating bunnies

            bunnies = Logic.GenerateRandomBunnies(5); //giving random features (color and gender)for the bunnies

            Logic.PrintBunnies(bunnies); //printing all info about bunny

            Console.ReadKey();

        }
    }
}
