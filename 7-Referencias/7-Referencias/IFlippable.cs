using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Referencias
{
    interface IFlippable
    {
        int CurrentPage { get; set; }
        void Flip();
    }
}
