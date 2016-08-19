using System;

namespace CslaDISerialization.Lib
{
    public interface IDependency
    {
        Guid UniqueKey { get; set; }
    }
}