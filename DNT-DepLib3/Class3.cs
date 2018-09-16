using System;
using System.Collections.Generic;
using System.Text;

namespace Lib3
{
    public class LibClass3
    {
        public static void Hello()
        {
            //Lib1.LibClass1.Hello();
            Lib2.LibClass2.Hello();
        }
    }
}
