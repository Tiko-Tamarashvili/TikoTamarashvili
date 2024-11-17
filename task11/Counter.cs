using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter1;

    internal class Counter
    {
        static int _count = 0;


        public Counter()
        {
            _count++;
        }


        public static int GetCount()
        {
            return _count;
        }

        public static void ResetCount()
        {
            _count = 0;
        }

}


   

