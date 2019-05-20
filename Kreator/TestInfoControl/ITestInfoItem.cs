using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.TestInfoControl {
    interface ITestInfoItem {
        
        string Title { get; }
        string Author { get; }
        string Description { get; }

    }
}
