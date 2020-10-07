using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string name)
                    : base(name)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Open XML file");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML file");
        }

        public override void Chenge()
        {
            Console.WriteLine("Chenge XML file");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML file");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string name)
                    : base(name)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT file");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT file");
        }

        public override void Chenge()
        {
            Console.WriteLine("Chenge TXT file");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT file");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string name)
                    : base(name)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC file");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC file");
        }

        public override void Chenge()
        {
            Console.WriteLine("Chenge DOC file");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC file");
        }
    }
}
