using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kreator.TestInfoControl;
using Kreator.Model;
using Kreator.QuestionControl;
namespace Kreator {
    class Presenter : IFormPresenter {
        private IForm view;
        private ITestInfoItemPresenter testItemPresenter;
        private IQuestionItemPresenter questionItemPresenter;
        private TestModel model;
        public Presenter(IForm view) {
            this.view = view;
            this.model = TestModel.Instance;
            this.view.ChangeScene += SetupPresenter;
            this.view.AddQuestion += AddQuestionToTest;
            this.view.AddTestInfo += AddTestInfo;
            this.view.EndCreatingTest += EndTest;
            
            Console.WriteLine(this.view);
            Console.WriteLine("Podpiete");
            this.view.ChangeUserControl("TestInfo");

        }
        public void AddQuestionToTest() {
            this.questionItemPresenter.SaveQuestion();
        }
        
        public void AddTestInfo() {
            Console.WriteLine("zapis");
            testItemPresenter.SaveTestInfo();
           
            this.view.ChangeUserControl("Question");
        }

        public void EndTest() {
            this.model.SaveTestToJson();
            this.view.ShowSaveTestMessage();
        }
        public void SetupPresenter() {
            string name = this.view.Scene;
            Console.WriteLine("To jest scena {0}", this.view.Scene);
            if (name.Equals("TestInfo")) {
                testItemPresenter = new TestInfoPresenter(this.view.tItem);
                Console.WriteLine("Stworzono prezenter dla testinfoitem");

            } else if (name.Equals("Question")) {
                questionItemPresenter = new QuestionItemPresenter(this.view.qItem);
            }
        }
    }
}
