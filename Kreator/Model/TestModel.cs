using System;
using System.IO;
using JednokrotnyWybor;
namespace Kreator.Model {
    class TestModel : ITestModel {

        private static TestModel instance = null;
        public static TestModel Instance { get {
                if (instance != null) {
                    return instance;
                } else {
                    instance = new TestModel();
                    return instance;
                }
            }

        }
        private Test test;
        public Test TestItem { get { return test; } } 

        public string NormaliseFileName() {
            return TestItem.Title;
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
