using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    class Redactor
    {
        AbstractHandler handler;

        public Redactor(string fullName)
        {
            string type, fileName;
            type = fullName.Remove(0, fullName.Length - 4);
            fileName = fullName.Substring(0, fullName.Length - 4);

            switch (type)
            {
                case ".doc":
                    handler = new DOCHandler(fullName);
                    break;
                case ".xml":
                    handler = new XMLHandler(fullName);
                    break;
                case ".txt":
                    handler = new TXTHandler(fullName);
                    break;
            }
        }
        public void Open()
        {
            this.handler.Open();
        }

        public void Create()
        {
            this.handler.Create();
        }

        public void Chenge()
        {
            this.handler.Chenge();
        }

        public void Save()
        {
            this.handler.Save();
        }
    }
}
