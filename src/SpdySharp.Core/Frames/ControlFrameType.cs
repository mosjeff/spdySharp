using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpdySharp.Core.Frames
{
    public enum ControlFrameType
    {
        SYN_STREAM = 0x1,
        SYN_REPLY = 0x2,
        RST_STREAM = 0x3,
        SETTINGS = 0x4,

        PING = 0x6,
        GOAWAY = 0x7,
        HEADERS = 0x8,
        WINDOW_UPDATE = 0x9,

        CREDENTIAL = 0x11
    }
}
