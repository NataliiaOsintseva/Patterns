using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.Samsung;

namespace Factory.Factory
{
    public class SamsungFactory : IPhoneFactory
    {
        public IBudgetModel GetBudgetModel()
        {
            return new SamsungGalaxyA6();
        }

        public IFlagman GetFlagman()
        {
            return new SamsungGalaxyS6();
        }
    }
}
