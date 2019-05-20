using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kreator.TestInfoControl;
using Kreator.QuestionControl;
namespace Kreator
{
    public partial class Form1 : Form,IForm
    {
        private string scene = "Question";
        public string Scene {
            get {
                return this.Scene;
            }
            set {
                this.scene = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            HideButtons();
            ChangeUserControl(Scene);
           
        }

        public event Action AddTestInfo;
        public event Action AddQuestion;
        public event Action EndCreatingTest;

        private void AddTestInfoBtn_Click() {
            AddTestInfo?.Invoke();
        }
        private void AddQuestionBtn_Click() {
            AddQuestion?.Invoke();
        }
        private void EndCreatingTestBtn_Click() {
            EndCreatingTest?.Invoke();
        }

        public void ChangeUserControl(string ControlName) {
            if (ControlName.Equals("TestInfo")) {
                ClearControls();
                ITestInfoItem testInfoItem = new TestInfoItem();
                controlContainer.Controls.Add((UserControl)testInfoItem);
                ShowButtons(ControlName);
            } else if(ControlName.Equals("Question")){
                    ClearControls();
                    IQuestionItem questionItem = new QuestionItem();
                    controlContainer.Controls.Add((UserControl)questionItem);
                    ShowButtons(ControlName);
            }
            
            
        }
        private void ClearControls() {
            controlContainer.Controls.Clear();
        }
        private void HideButtons() {
            addQuestionBtn.Visible = false;
            addTestInfoBtn.Visible = false;
            endTestBtn.Visible = false;
        }
        private void ShowButtons(string name) {
            if (name.Equals("TestInfo")) {
                HideButtons();
                addTestInfoBtn.Visible = true;
            }else if (name.Equals("Question")) {
                HideButtons();
                addQuestionBtn.Visible = true;
                endTestBtn.Visible = true;
            }
        }

        private void endTestBtn_Click() {
            EndCreatingTest?.Invoke();
        }
        private void addTestInfoBtn_Click() {
            AddTestInfo?.Invoke();
        }
        private void addQuestionBtn_Click() {
            AddQuestion?.Invoke();
        }
    }
}
