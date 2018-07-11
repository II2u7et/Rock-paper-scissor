using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartII_Q3
{
    class Rock : Tool
    {
        public Rock(int str, char t) : base(str, t)
        {
            this.setStrength(str);
            this.setType(t);
        }

        public Boolean fight( Tool tool )
        {
            
            if ( tool.getType() == 's')
            {
                this.setStrength((this.getStregth() )* 2);
            }
            else 
            {
                this.setStrength((this.getStregth()) / 2);
            }
            

            if ( this.getStregth() > tool.getStregth())
            {
                this.setStrength(10);
                return true;
            }
            else
            {
                this.setStrength(10);
                return false;
            }
        }
    }
}
