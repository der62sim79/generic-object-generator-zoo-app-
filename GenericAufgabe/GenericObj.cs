using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAufgabe
{
    class GenericObj
    {
        public static T GenerateObj<T>(object[] values)
        {
            return (T)Activator.CreateInstance(typeof(T), values);
        }

        public static T NewObj<T>() where T : new()
        {
            return new T();
        }
    }
}
