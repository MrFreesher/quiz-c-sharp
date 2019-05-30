using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.QuestionControl {
    interface IQuestionItemPresenter {
        void SaveQuestion();
        void ClearQuestionItem();
        bool validateData();
    }
}
