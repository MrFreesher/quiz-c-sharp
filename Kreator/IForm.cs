using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator {
    interface IForm {
        event Action AddTestInfo;
        event Action AddQuestion;
        event Action EndCreatingTest;

        void ChangeUserControl(string ControlName);

    }
}
