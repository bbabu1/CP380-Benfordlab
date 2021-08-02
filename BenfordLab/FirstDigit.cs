using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenfordLab
{
    public class FirstDigit
    {
        /* Given an integer X, this method returns the first digit
         * 
         * For example,
         *   5 ==> returns 5
         *   10 ==> returns 1
         *   654321 ==> returns 6
         */
        public static int getFirstDigit(int digit) {
            int num = digit;
            while(num>=10)
            {
                num = num / 10;
            }
            /*int count = 0;
            int div = 1;
            while(num > 0)
            {
                count++;
                num = num / 10;
            }
            for(int i=0; i<(count-1);i++)
            {
                div = div * 10;
            }
            return digit / div;*/
            // TODO
            return num;
        }    
    }
}
