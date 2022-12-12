using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work3_1
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Учень вчиться");
        }

        public virtual void Read()
        {
            Console.WriteLine("Учень читає");
        }
        public virtual void Write()
        {
            Console.WriteLine("Учень пише");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Учень вiдпочиває");
        }
    }
}
