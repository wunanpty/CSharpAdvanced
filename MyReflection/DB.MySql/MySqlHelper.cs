using DB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.MySql
{
    public class MySqlHelper : IDBHelper
    {
        public MySqlHelper()
        {
            Console.WriteLine("{0} is constructed", this.GetType().Name);
        }
        public void Query()
        {
            Console.WriteLine("{0}.Query invoked", this.GetType().Name);
            Console.WriteLine("Hey, I am MySql! ");
        }
    }
}
