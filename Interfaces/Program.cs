using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable music = new Player();

            music.Pause();

            ((Player)music as IRecordable).Record();
        }
    }
}
