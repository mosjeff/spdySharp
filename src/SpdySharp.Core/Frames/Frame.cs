using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpdySharp.Core.Frames
{
    public abstract class Frame
    {
        public bool ControlBit { get; set; } 
    }
}
