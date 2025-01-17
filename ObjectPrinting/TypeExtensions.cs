﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPrinting
{
    public static class TypeExtensions
    {
        public static bool IsSimple(this Type type)
        {
            return type.IsPrimitive || type.Equals(typeof(DateTime)) || type.Equals(typeof(TimeSpan))
                   || type.Equals(typeof(string)) || type.Equals(typeof(Guid));
        }
    }
}
