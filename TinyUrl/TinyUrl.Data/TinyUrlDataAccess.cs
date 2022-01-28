using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyUrl.Data
{
    public class TinyUrlDataAccess: ITinyUrlDataAccess
    {
        Sqlite database;

        public TinyUrlDataAccess()
        {
            database = new Sqlite();
        }

        public void doSomething()
        {
            Console.WriteLine("do something");
        }
    }
}
