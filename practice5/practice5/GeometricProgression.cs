using System;
using System.Collections.Generic;
using System.Text;

namespace practice4
{
    class GeometricProgression
    {
        public int start;
        public int step;


        public GeometricProgression(int start, int step)
        {
            this.start = start;
            this.step = step;
        }

        public int SumElement(int k)
        {
            int sum = start;
            int result = 0;
            int i = start;
            while (i < k)
            {
                sum = sum*step;
                result += sum;
                i++;
            }
            return result + 1;
        }
    }
}
