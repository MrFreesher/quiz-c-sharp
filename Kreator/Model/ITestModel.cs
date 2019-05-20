using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreator.Model {
    interface ITestModel {
        Test TestItem { get;  }
        void SaveTestToJson();
        string NormaliseFileName();




    }
}
