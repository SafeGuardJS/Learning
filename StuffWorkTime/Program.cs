using System;

namespace StuffWorkTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Post Andrew = Post.junior;

            Accauntant.AskForBonus(Andrew, 12);
            if (Accauntant.AskForBonus(Andrew, 12))
                Console.WriteLine("Great job! Keep up the good work!");
            else
                Console.WriteLine("Good job, but work hardly.");
        }
    }

    static class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours) return true;
            else return false;
        }
    }

    enum Post
    {
        junior = 10,
        middle = 8,
        senior = 5
    }
}
