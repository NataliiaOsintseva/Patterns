using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.Apple;

namespace Factory.Factory
{
    public class AppleFactory : IPhoneFactory
    {
        public IBudgetModel GetBudgetModel()
        {
            return new IPhone5S();
        }

        public IFlagman GetFlagman()
        {
            return new IPhone6SPlus();
        }
    }
}
