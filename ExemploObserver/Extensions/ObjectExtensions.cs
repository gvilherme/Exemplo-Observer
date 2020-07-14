using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploObserver.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this Object obj)
        {
            return obj == null;
        }
    }
}
