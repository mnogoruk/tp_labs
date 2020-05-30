using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    public interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
    }
}
