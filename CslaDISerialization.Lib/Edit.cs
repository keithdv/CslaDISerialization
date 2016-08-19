using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    [Serializable]
    public class Edit : DIBusinessBase<Edit>
    {

        public static readonly PropertyInfo<EditChildList> EditChildListProperty = RegisterProperty<EditChildList>(c => c.EditChildList);
        public EditChildList EditChildList
        {
            get { return GetProperty(EditChildListProperty); }
            set { SetProperty(EditChildListProperty, value); }
        }

        private void DataPortal_Fetch()
        {
            EditChildList = DataPortal.FetchChild<EditChildList>();
        }

    }
}
