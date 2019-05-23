using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.AnswerControl {
    interface IAnswerItem {
        string AnswerContent { get; }
        int Points { get; }
    }
}
