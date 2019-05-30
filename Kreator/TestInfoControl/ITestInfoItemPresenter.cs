using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.TestInfoControl {
    public interface ITestInfoItemPresenter {
        void SaveTestInfo();
        bool validateData();

    }
}
