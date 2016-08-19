using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaDISerialization.Lib
{
    [Serializable]
    public class EditChildList : BusinessListBase<EditChildList, EditChild>
    {

        private void Child_Fetch()
        {
            this.Add(DataPortal.FetchChild<EditChild>());
            this.Add(DataPortal.FetchChild<EditChild>());
            this.Add(DataPortal.FetchChild<EditChild>());
            this.Add(DataPortal.FetchChild<EditChild>());
            this.Add(DataPortal.FetchChild<EditChild>());
        }
    }
}
