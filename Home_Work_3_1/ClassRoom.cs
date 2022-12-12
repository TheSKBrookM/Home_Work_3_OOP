using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Home_Work3_1
{
    class ClassRoom
    {
        Pupil[] pupil = new Pupil[4];

        private int group = 4;  
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = GenerateNewPupil();
            pupil[3] = GenerateNewPupil();
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
            pupil[3] = GenerateNewPupil();
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupil[0] = pupil1;
            pupil[1] = pupil2;
            pupil[2] = pupil3;
            pupil[3] = pupil4;
        }

        private Pupil GenerateNewPupil()
        {
            Random random = new Random();

            int rand = random.Next(1,group);

            if (rand == 1)
            {
                return new BadPupil();
            }
            else if (rand == 2)
            {
                return new GoodPupil();
            }
            else if (rand == 3)
            {
                return new ExcelentPupil();
            }
            return new BadPupil();
        }

        public void Study()
        {
            for (int i = 0; i < group; i++)
            {
                pupil[i].Study();
            }
        }

        public void Read()
        {
            for (int i = 0; i < group; i++)
            {
                pupil[i].Read();
            }
        }
        public void Write()
        {
            for (int i = 0; i < group; i++)
            {
                pupil[i].Write();
            }
        }
        public void Relax()
        {
            for (int i = 0; i < group; i++)
            {
                pupil[i].Relax();
            }
        }
    }
}
