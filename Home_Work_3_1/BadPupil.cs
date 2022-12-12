using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work3_1
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учень вчиться: Bad");
        }
        public override void Read()
        {
            Console.WriteLine("Учень читає: Bad");
        }
        public override void Write()
        {
            Console.WriteLine("Учень пише: Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Учень вiдпочиває: Bad");
        }
    }
}
