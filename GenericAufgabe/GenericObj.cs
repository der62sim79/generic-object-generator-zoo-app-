using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAufgabe
{
    class GenericObj
    {
        public static T GenerateObj<T>(object[] parameter)
        {
            return (T)Activator.CreateInstance(typeof(T), parameter);
        }

        public static T NewObj<T>() where T : new()
        {
            return new T();
        }
    }
}
