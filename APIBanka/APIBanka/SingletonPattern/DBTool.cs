using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBanka.SingletonPattern
{
    using Models;
    public class DBTool
    {


        private DBTool() { }

        private static BankaDBEntities _dbInstance;

        public static BankaDBEntities DBInstance
        {
            get
            {

                if (_dbInstance == null)
                {

                    _dbInstance = new BankaDBEntities();
                }

                return _dbInstance;

            }
        }




    }
}