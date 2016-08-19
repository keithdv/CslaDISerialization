using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class DependencyAttribute : Attribute
    {

        // This is a positional argument
        public DependencyAttribute()
        {
        }

    }
}
