using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    [Serializable]
    public class EditGrandChildList : BusinessListBase<EditGrandChildList, EditGrandChild>
    {

        private void Child_Fetch()
        {
            this.Add(DataPortal.FetchChild<EditGrandChild>());
            this.Add(DataPortal.FetchChild<EditGrandChild>());
            this.Add(DataPortal.FetchChild<EditGrandChild>());
            this.Add(DataPortal.FetchChild<EditGrandChild>());
            this.Add(DataPortal.FetchChild<EditGrandChild>());
        }

    }
}
