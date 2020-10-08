using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Player : IRecordable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Nice music!");
        }

        public void Record()
        {
            Console.WriteLine("Recording!");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause, but you can continue listen music!");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop!");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Pause recording!");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording!");
        }
    }
}
