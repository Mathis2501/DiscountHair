using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountHair
{
    class Chair
    {
        public static object scissorAB = new object();
        public static object scissorBC = new object();
        public static object scissorCD = new object();
        public static object scissorDE = new object();
        public static object scissorEF = new object();
        public static object scissorFA = new object();
        public object scissorR;
        public object scissorL;

        public Chair(int i)
        {
            
            switch (i)
            {
                case 0:
                    scissorR = scissorFA;
                    scissorL = scissorAB;
                    break;

                case 1:
                    scissorR = scissorAB;
                    scissorL = scissorBC;
                    break;

                case 2:
                    scissorR = scissorBC;
                    scissorL = scissorCD;
                    break;

                case 3:
                    scissorR = scissorCD;
                    scissorL = scissorDE;
                    break;

                case 4:
                    scissorR = scissorDE;
                    scissorL = scissorEF;
                    break;

                case 5:
                    scissorR = scissorEF;
                    scissorL = scissorFA;
                    break;
            }
        }
    }
}
