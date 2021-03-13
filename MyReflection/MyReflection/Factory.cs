using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using DB.Interface;

namespace MyReflection
{
    public class Factory
    {
        private static string IDBHelperConfig = ConfigurationManager.AppSettings["IDBHelperConfig"];
        private static string DllName = IDBHelperConfig.Split(',')[1];
        private static string TypeName = IDBHelperConfig.Split(',')[0];

        public static IDBHelper CreateInstance()
        {
            Assembly assembly = Assembly.Load(DllName);
            Type type = assembly.GetType(TypeName);
            object oDBHelper = Activator.CreateInstance(type);
            return oDBHelper as IDBHelper;
        }
    }
}
