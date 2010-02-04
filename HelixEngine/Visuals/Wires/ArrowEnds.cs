//------------------------------------------
// ArrowEnds.cs (c) 2007 by Charles Petzold
//------------------------------------------
using System;

namespace HelixEngine.Wires
{
    /// <summary>
    ///     Indicates which end of the line has an arrow.
    /// </summary>
    [Flags]
    public enum ArrowEnds
    {
        None = 0,
        Start = 1,
        Begin = 1,
        End = 2,
        Both = 3
    }
}