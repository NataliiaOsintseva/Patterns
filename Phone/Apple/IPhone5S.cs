using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Apple
{
    public class IPhone5S : AbstractIPhone, IBudgetModel
    {
        public override string Name
        {
            get { return "IPhone 5S"; }
        }

        public string Moto()
        {
            return "Not expensive, but still it's Apple";
        }
    }
}
