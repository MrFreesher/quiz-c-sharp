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
    public partial class Form1 : Form, IForm {
        public event Action ChangeScene;
        private string scene = "TestInfo";
        private IQuestionItem qitem;
        private ITestInfoItem titem;
        
        
        public IQuestionItem qItem {
            get {
                return qitem;
            }
        }

        public ITestInfoItem tItem => titem;

        public string Scene {
            get {
                return this.scene;
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

        private void AddTestInfoBtn_Click(object sender, EventArgs args) {
            Console.WriteLine("Dodaj test info click");
            this.scene = "Question";
            AddTestInfo?.Invoke();
            if(AddTestInfo == null) {
                Console.Write("a");
            }
        }
        private void AddQuestionBtn_Click(object sender, EventArgs args) {
            AddQuestion?.Invoke();
        }
        private void EndCreatingTestBtn_Click(object sender, EventArgs args) {
            EndCreatingTest?.Invoke();
        }

        public void ChangeUserControl(string ControlName) {
            Console.WriteLine("Zmiana sceny");
            if (ControlName.Equals("TestInfo")) {
                ClearControls();
                titem = new TestInfoItem();
                controlContainer.Controls.Add((UserControl) titem);
                ShowButtons(ControlName);
                if(ChangeScene != null) {
                    Console.WriteLine("nie null");
                } else {
                    Console.WriteLine("To jest null");
                }
                ChangeScene?.Invoke();
                Console.WriteLine("Zmiana sceny na test info");
               
            } else if (ControlName.Equals("Question")) {
                ClearControls();
                qitem = new QuestionItem();
                controlContainer.Controls.Add((UserControl)qitem);
                ShowButtons(ControlName);
               
                
               ChangeScene?.Invoke();
                
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

       

        public void ShowSaveTestMessage() {
            MessageBox.Show("Test został zapisany do pliku JSON", "Kreator", MessageBoxButtons.OK);
        }

        
    }
}
