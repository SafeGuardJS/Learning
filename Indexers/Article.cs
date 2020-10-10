using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    class Article
    {
        public string productName, storeName;
        double productPrice;

        public string StoreName
        {
            set { storeName = value; }
            get { return storeName; }
        }

        public string ProductName
        {
            set { productName = value; }
            get { return productName; }
        }

        public double ProductPrice
        {
            set { productPrice = value; }
            get { return productPrice; }
        }
    }
}
