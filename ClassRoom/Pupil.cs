using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Study hard!");
        }

        public virtual void Read()
        {
            Console.WriteLine("Reading is helpful for brain");
        }

        public virtual void Write()
        {
            Console.WriteLine("Activate muscle memory");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Chill out!");
        }
    }
}
