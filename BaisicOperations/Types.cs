using System;
using System.Collections.Generic;
using System.Text;

namespace BaisicOperations
{
    class Types
    {
        public void RuntimeCheck()
        {
            object y = "5";
            int z = (int)y;  // Runtime error, downcast failed
        }
    }
}
