using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.TestInfoItem {
    interface ITestInfoItemPresenter {
        void SaveTestInfo();
        event Action AddTestInfo;

    }
}
