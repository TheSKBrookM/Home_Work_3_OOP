namespace Home_Work3_1
{
    class Program
    {
        static void Main()
        {
            Pupil pupil1 = new BadPupil();
            Pupil pupil2 = new GoodPupil();

            ClassRoom pupilClass = new ClassRoom(pupil1, pupil2);

            pupilClass.Study();
            Console.WriteLine();

            pupilClass.Read();
            Console.WriteLine();

            pupilClass.Write();
            Console.WriteLine();

            pupilClass.Relax();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}