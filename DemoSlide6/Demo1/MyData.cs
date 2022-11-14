using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class MyData : IDataIO
    {
        int nPrivateData;
        public int GetData()
        {
            return nPrivateData;
        }

        public void SetData(int s)
        {
            nPrivateData = s;
        }
    }
}
