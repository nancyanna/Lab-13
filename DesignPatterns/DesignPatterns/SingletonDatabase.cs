using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class SingletonDatabase
    {
        private static SingletonDatabase _instance = null;
        public static SingletonDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonDatabase();
                }
                return _instance;

            }
        }
        private SingletonDatabase()
        {

        }
    }
}
