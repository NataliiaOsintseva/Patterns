using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.Samsung;
using Factory.Phone.Apple;
using Factory.Phone.WindowsPhone;

namespace Factory.Factory
{
    public interface IPhoneFactory
    {
        IFlagman GetFlagman();
        IBudgetModel GetBudgetModel();
    }
}
