using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    [Serializable]
    public class EditGrandChild : DIBusinessBase<EditGrandChild>
    {

        private IDependency _dependency;

        [Dependency]
        public IDependency Dependency
        {
            get { return _dependency; }
            set { _dependency = value; }
        }

        public static readonly PropertyInfo<Guid?> UniqueKeyProperty = RegisterProperty<Guid?>(c => c.UniqueKey);
        public Guid? UniqueKey
        {
            get { return GetProperty(UniqueKeyProperty); }
            set { SetProperty(UniqueKeyProperty, value); }
        }

        private void Child_Fetch()
        {
            this.UniqueKey = Dependency?.UniqueKey;
        }



    }
}
