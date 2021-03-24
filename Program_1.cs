using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunnys_hill
{
    class Program_1
    {
        private const int m_pBunnysQuan = 5; //how many bunnys we will create
        private const int m_pBunnysChar = 3; //sex, color, age

        private static int m_pSex;
        private static int m_pColor;
        private static int m_pAge;
        private static string m_pName;

        public static void generateBunny()
        {
            Random random = new Random();

            int m_pSexMax = 2; //male and female
            int m_pColorMax = 4; //white, black, brown, spotted
            int m_pAgeMax = 11; //0 - 10

            m_pSex = random.Next(m_pSexMax);
            m_pColor = random.Next(m_pColorMax);
            m_pAge = random.Next(m_pAgeMax);
        }


        static void Main(string[] args)
        {
            Bunny[] bunny_arr = new Bunny[m_pBunnysQuan];

            for (int i = 0; i < m_pBunnysQuan; i++)
            {
                Console.Write("Please, enter bunny's name: ");
                m_pName = Console.ReadLine();
                generateBunny();
                
                bunny_arr[i] = new Bunny(m_pSex, m_pColor, m_pAge, m_pName);
            }

            Console.ReadKey();
        }
    }
}
