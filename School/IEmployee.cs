using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace School
{
    public interface IEmployee {
    
        void getSalary();
        int takeFromAcct(int amount);
    }
}
        