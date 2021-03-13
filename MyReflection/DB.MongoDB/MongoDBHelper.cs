using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Interface;

namespace DB.MongoDB
{
    public class MongoDBHelper : IDBHelper
    {
        public MongoDBHelper()
        {
            Console.WriteLine("{0} is constructed", this.GetType().Name);
        }
        public void Query()
        {
            Console.WriteLine("{0}.Query invoked", this.GetType().Name);
            Console.WriteLine("Hey, I am MongoDB! ");
        }
    }
}
