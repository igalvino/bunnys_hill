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

        public Bunny(int m_pSex, int m_pColor, int m_pAge, string m_pName) //overloaded constructor
                                                           //if custom information is there
        {
            this.m_pSex = (Bunny.Sex)m_pSex;
            this.m_pColor = (Bunny.Color)m_pColor;
            this.m_pAge = m_pAge;
            this.m_pName = m_pName;

            return;
        }
    }
}
