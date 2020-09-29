using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil Vlad = new BadPupil();
            BadPupil Dima = new BadPupil();
            ExcelentPupil Andrew = new ExcelentPupil();

            ClassRoom SecondA = new ClassRoom(Vlad, Dima, Andrew);

            SecondA.GetStudyFeedBack();
        }
    }
}
