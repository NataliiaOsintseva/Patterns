using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Phone;
using Factory.Phone.Android;
using Factory.Phone.IOS;
using Factory.Phone.WindowsPhone;

namespace Factory.Factory
{
    public interface IPhoneFactory
    {
        IPhoneBase CreatePhone();
    }
}
