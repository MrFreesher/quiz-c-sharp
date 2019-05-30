using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreator.Model;
namespace Kreator.TestInfoControl {
    public class TestInfoPresenter : ITestInfoItemPresenter,IPresenter {
        private ITestInfoItem view;
        private TestModel model;
        public TestInfoPresenter(ITestInfoItem testInfo) {
            this.view = testInfo;
            this.model = TestModel.Instance;
        }
        
        public void SaveTestInfo() {
            this.model.TestItem.Author = this.view.Author;
            this.model.TestItem.Description = this.view.Description;
            this.model.TestItem.Title = this.view.Title;
            Console.WriteLine(this.view.Title);
            Console.WriteLine(this.model.TestItem.Title);
        }

        public bool validateData() {
            if(!view.Author.Equals("") && !view.Description.Equals("") && !view.Title.Equals("")) {
                return true;
            } else {
                return false;
            }
        }
    }
}
