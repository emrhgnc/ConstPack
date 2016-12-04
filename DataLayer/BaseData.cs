using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayer
{
    public class BaseData
    {
        public Base ok(bool access)
        {
            Base b = new Base();
            if(access)
            {
                b.result = true;
            }
            else
            {
                b.result = false;
                b.errorId = 101;
                b.errorMsg = "Internal Server Error";
            }
            return b;
        }
    }
}
