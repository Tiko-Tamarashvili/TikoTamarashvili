using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathhelper;

static class MathHelper
{
    public static int Add (int a, int b)
    { 
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply (int a, int b) 
    {
        return a * b;
    }

    public static int Divide(int a, int b)

    {
        if (b == 0)
        {
            throw new ArgumentException("nulze gayofa daushvebelia");
        }
        return a / b; 
    }


}