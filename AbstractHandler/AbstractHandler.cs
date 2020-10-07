using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandler
{
    abstract class AbstractHandler
    {
        string handlerName;
        public string HandlerName
        {
            get { return handlerName; }
            set
            {
                if (value.IndexOf(" ") > -1) Console.WriteLine("File's name can't contain spases!");
                else handlerName = value;
            }
        }

        public AbstractHandler(string name)
        {
            HandlerName = name;
        }

        abstract public void Open();

        abstract public void Create();

        abstract public void Chenge();

        abstract public void Save();        
    }
}
