using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Android
{
    interface ISHealth
    {
        void CountSteps();
        void CheckWeight(int weight, int height);
    }
}
