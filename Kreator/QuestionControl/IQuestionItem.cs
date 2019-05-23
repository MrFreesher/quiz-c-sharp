using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreator.AnswerControl;
namespace Kreator {
    public interface IQuestionItem {
        #region Props
        string Content { get; }
        List<AnswerItem> Answers { get; }
        #endregion
        #region Methods
        void ClearAnswerContainer();
        void ClearQuestionContent();
        #endregion

    }
}
