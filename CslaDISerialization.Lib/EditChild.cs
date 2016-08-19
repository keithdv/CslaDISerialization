using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    [Serializable]
    public class EditChild : DIBusinessBase<EditChild>
    {

        public static readonly PropertyInfo<EditGrandChildList> EditGrandChildListProperty = RegisterProperty<EditGrandChildList>(c => c.EditGrandChildList);
        public EditGrandChildList EditGrandChildList
        {
            get { return GetProperty(EditGrandChildListProperty); }
            set { SetProperty(EditGrandChildListProperty, value); }
        }

        private void Child_Fetch()
        {
            EditGrandChildList = DataPortal.FetchChild<EditGrandChildList>();
        }

    }
}
