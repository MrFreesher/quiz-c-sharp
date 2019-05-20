using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.QuestionItem {
    interface IQuestionItemPresenter {
        void SaveQuestion();
        void ClearQuestionItem();
    }
}
