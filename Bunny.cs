using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunnys_hill
{
    class Bunny
    {
        private enum Sex { male, female } //list of types of bunny's sex
        private enum Color { white, black, brown, spotted }//list of types of a bunny's color

        private Sex m_pSex = new Sex();
        private Color m_pColor = new Color();
        private int m_pAge;
        private string m_pName;

        public Bunny(int m_pSex, int m_pColor, int m_pAge, string m_pName) //constructor of bunny's
        {
            this.m_pSex = (Bunny.Sex)m_pSex;
            this.m_pColor = (Bunny.Color)m_pColor;
            this.m_pAge = m_pAge;
            this.m_pName = m_pName;

            return;
        }
    }
}
