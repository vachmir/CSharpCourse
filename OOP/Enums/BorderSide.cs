using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Enums
{
    [Flags]
    enum BorderSide          //value type group of named numeric constants
    {      
        Left,
        Right,
        Top = 1 << 4,
        Botom
    }
}

