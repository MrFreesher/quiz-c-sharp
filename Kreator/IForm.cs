using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kreator.QuestionControl;
using Kreator.TestInfoControl;
namespace Kreator {
    interface IForm {
        string Scene { get; }
        IQuestionItem qItem { get; }
        ITestInfoItem tItem { get; }

        event Action AddTestInfo;
        event Action AddQuestion;
        event Action EndCreatingTest;
        event Action ChangeScene;

        void ChangeUserControl(string ControlName);
        void ShowSaveTestMessage();

    }
}
