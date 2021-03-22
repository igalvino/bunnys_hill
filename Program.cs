using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunnys_hill
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunny bunny1 = new Bunny();

            Console.Write ("Please, enter bunny's name: ");
            bunny1.m_pName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nBunny " + bunny1.m_pName + " was born!");
            bunny1.getValues();
            Console.ReadKey();
        }
    }

    class Bunny
    {
        private enum Sex { male, female }
        private enum Color { white, black, brown, spotted }

        private Sex m_pSex = new Sex();
        private Color m_pColor = new Color();
        private int m_pAge;
        public string m_pName;

        public Bunny()
        {
            Random random = new Random();

            int m_pSex = random.Next(0, 2);
            int m_pColor = random.Next(0, 4);
            int m_pAge = random.Next(0, 11);

            this.m_pSex = (Bunny.Sex)m_pSex;
            this.m_pColor = (Bunny.Color)m_pColor;
            this.m_pAge = m_pAge;

            return;
        }

        public void getValues()
        {
            Console.WriteLine("Age: " + this.m_pAge + "\nSex: " + this.m_pSex + "\nColor: " + this.m_pColor);
        }
    }
}
