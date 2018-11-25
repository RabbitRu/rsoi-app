using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rsoi_app
{
    public class BusinesLogic
    {
        public static int Factorial(int? x)
        {
            if (x == null)
            {
                throw new Exception("Recieved null");
            }
            else if (x < 1)
            {
                throw new Exception("Negative Number");
            }

            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;

        }
    }
}
