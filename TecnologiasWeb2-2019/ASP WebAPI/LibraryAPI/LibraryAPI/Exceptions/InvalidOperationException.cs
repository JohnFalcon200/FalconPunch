using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Exceptions
{
    public class InvalidOperationException: Exception
    {
        public InvalidOperationException(string message)
            :base(message)
        {
                
        }
    }
}
