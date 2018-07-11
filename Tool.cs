using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII_Q3
{
    class Tool
    {
        private int strength;
        private char type;

        public Tool(int str, char t)
        {
            this.strength = str;
            this.type = t;
        }

    
        public void setStrength( int str)
        {
            this.strength = str;
        }

        public void setType( char t)
        {
            this.type = t;
        }

        public char getType()
        {
            return this.type;
        }

        public int getStregth()
        {
            return this.strength;
        }
    }
}
