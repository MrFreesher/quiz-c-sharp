using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.QuestionItem {
    interface IQuestionItem {
        string Content { get; }
        void ClearAnswerContainer();
        void ClearQuestionContent();
        

    }
}
