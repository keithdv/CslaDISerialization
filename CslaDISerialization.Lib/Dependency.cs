using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    internal class Dependency : IDependency
    {

        public Dependency()
        {
            UniqueKey = Guid.NewGuid();
        }
        public Guid UniqueKey { get; set; }

    }
}
