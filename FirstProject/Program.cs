using System;

namespace FirstProject
{
    class Base
    {
        string name;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }

    class Derived : Base
    {
        
        public void Show()
        {
            Console.WriteLine(Name, base.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived cls = new Derived();

            cls.Name = "sdasd";
            cls.Show();


        }
    }
}
