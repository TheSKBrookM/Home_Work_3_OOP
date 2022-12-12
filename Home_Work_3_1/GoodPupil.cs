using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work3_1
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учень вчиться: Good");
        }
        public override void Read()
        {
            Console.WriteLine("Учень читає: Good");
        }
        public override void Write()
        {
            Console.WriteLine("Учень пише: Good");
        }
        public override void Relax()
        {
            Console.WriteLine("Учень вiдпочиває: Good");
        }
    }
}
