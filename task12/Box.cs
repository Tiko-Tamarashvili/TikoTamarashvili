using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box1;

public class Box <T>
{
    private T value;

    //public Box() 
    //{
    //    this.value = value;
    //}

    public void SetValue(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }

}
