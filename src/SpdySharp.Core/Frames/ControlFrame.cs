using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpdySharp.Core.Frames
{
    public abstract class ControlFrame : Frame
    {
        protected ControlFrame()
        {
            ControlBit = true;
        }

        public ControlFrameType Type { get; set; }
    }
}
