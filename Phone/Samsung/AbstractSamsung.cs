using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone.Samsung
{
    public abstract class AbstractSamsung : PhoneBase, IGoogleNow, ICamera
    {
        public override string OperationalSystem
        {
            get { return "My os is Android!"; }
        }

        public void Alarm()
        {
            Console.WriteLine("I'll wake you up");
        }

        public void CreateNotes()
        {
            Console.WriteLine("I've made a note");
        }

        public void Flash()
        {
            Console.WriteLine("Let the light come here!");
        }

        public void Search()
        {
            Console.WriteLine("Let me google that for you...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Let's take selfies!");
        }
    }
}
