using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator {
    interface IFormPresenter {
        void AddQuestionToTest();
        void AddTestInfo();
        void EndTest();
    }
}
