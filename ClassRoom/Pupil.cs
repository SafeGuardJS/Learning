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

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study hard? Rofl!");
        }

        public override void Read()
        {
            Console.WriteLine("Reading is helpful for brain. Never said this.");
        }

        public override void Write()
        {
            Console.WriteLine("Writing? Just grafity.");
        }

        public override void Relax()
        {
            Console.WriteLine("Chill out! As meaning of life.");
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study hard! For a bright future and glory night");
        }

        public override void Read()
        {
            Console.WriteLine("Reading is helpful for brain. Кead all notes");
        }

        public override void Write()
        {
            Console.WriteLine("Activate muscle memory. Write lectures");
        }

        public override void Relax()
        {
            Console.WriteLine("Chill out! Just a little bit");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study hard!Maybe");
        }

        public override void Read()
        {
            Console.WriteLine("Reading is helpful for brain.Maybe");
        }

        public override void Write()
        {
            Console.WriteLine("Activate muscle memory. Maybe");
        }

        public override void Relax()
        {
            Console.WriteLine("Chill out!. Yes!");
        }
    }
}
