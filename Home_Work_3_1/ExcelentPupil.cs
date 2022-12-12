using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work3_1
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учень вчиться: Excelent");
        }
        public override void Read()
        {
            Console.WriteLine("Учень читає: Excelent");
        }
        public override void Write()
        {
            Console.WriteLine("Учень пише: Excelent");
        }
        public override void Relax()
        {
            Console.WriteLine("Учень вiдпочиває: Excelent");
        }
    }
}
