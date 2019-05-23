using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator {
    public interface ITestInfoItem {
        
        string Title { get; }
        string Author { get; }
        string Description { get; }

    }
}
