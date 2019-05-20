using System;
using System.IO;
using JednokrotnyWybor;
namespace Kreator.Model {
    class TestModel : ITestModel {

        private TestModel instance = null;
        public TestModel Instance { get {
                if (instance != null) {
                    return this.Instance;
                } else {
                    instance = new TestModel();
                    return this.instance;
                }
            }

        }
        private Test test;
        public Test TestItem { get { return test; } } 

        public string NormaliseFileName() {
            return TestItem.Title.ToLower().Trim();
        }

        public void SaveTestToJson() {
            string filename = NormaliseFileName();
            string json = JsonConverter.Serialize(TestItem);
            using (StreamWriter outputFile = new StreamWriter(filename)) {
                
                    outputFile.WriteLine(json);
            }
        }
        private TestModel() {
            test = new Test();
        }
    }
}
