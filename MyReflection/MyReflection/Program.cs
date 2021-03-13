using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Interface;
using DB.MongoDB;
using DB.MySql;
using DB.SqlServer;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Common
                {
                    //MongoDBHelper mongodb = new MongoDBHelper();
                    //mongodb.Query();

                    //Console.WriteLine("============================================");

                    //MySqlHelper mysql = new MySqlHelper();
                    //mysql.Query();
                }
                #endregion

                #region Factory+Reflection
                {
                    IDBHelper iDBHelper = Factory.CreateInstance();
                    iDBHelper.Query();
                }
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
