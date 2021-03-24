using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunnys_hill
{
    class Bunny
    {
        private enum Sex { male, female }
        private enum Color { white, black, brown, spotted }//list of types of a bunny's color

        private Sex m_pSex = new Sex();
        private Color m_pColor = new Color();
        private int m_pAge;
        private string m_pName;

        public Bunny()
        {
            Random random = new Random();//overloaded constructor
                                         //if custom info isn't there
            int m_pSex = random.Next(2);
            int m_pColor = random.Next(4);
            int m_pAge = random.Next(10);

            this.m_pSex = (Bunny.Sex)m_pSex;
            this.m_pColor = (Bunny.Color)m_pColor;
            this.m_pAge = m_pAge;

            return;
        }

        public Bunny(int m_pSex, int m_pColor, int m_pAge) //overloaded constructor
                                                           //if custom information is there
        {
            this.m_pSex = (Bunny.Sex)m_pSex;
            this.m_pColor = (Bunny.Color)m_pColor;
            this.m_pAge = m_pAge;
        }

        public void setName()
        {
            string m_pName = Console.ReadLine();
            this.m_pName = m_pName;
        }

        public void getValues()
        {
            Console.WriteLine("\nBunny " + this.m_pName + " was born!");
            Console.WriteLine("Age: " + this.m_pAge + "\nSex: " + this.m_pSex + "\nColor: " + this.m_pColor);
        }

        public void Randomizer(int m_pSex, int m_pColor, int m_pAge) //if need to rerandom
        {
            int m_pSexMaximum = 1; // male or female (enum begins from '0')
            int m_pColorMaximum = 3; //white, black, brown, spotted (enum begins from '0')
            int m_pAgeMaximum = 10; //0-10

            Random random = new Random();
            m_pSex = random.Next(m_pSexMaximum);
            m_pColor = random.Next(m_pColorMaximum);
            m_pAge = random.Next(m_pAgeMaximum);

            this.m_pSex = (Bunny.Sex)m_pSex;
            this.m_pColor = (Bunny.Color)m_pColor;
            this.m_pAge = m_pAge;
        }
    }
}
