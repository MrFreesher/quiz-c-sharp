using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kreator.AnswerControl;

namespace Kreator.QuestionControl {
    public partial class QuestionItem : UserControl,IQuestionItem {
        private List<AnswerItem> answers;
        public List<AnswerItem> Answers {
            get {
                return this.answers;
            }
        }
        public QuestionItem() {
            InitializeComponent();
            answers = new List<AnswerItem>();
        }

        public string Content => questionContentInput.Text;

        public void ClearAnswerContainer() {
            answersContainer.Controls.Clear();
        }

        public void ClearQuestionContent() {
            questionContentInput.Text = "";
        }
        public void AddAnswerItem(object sender,EventArgs eventArgs) {
            AnswerItem answerItem = new AnswerItem();
            answers.Add(answerItem);
            this.answersContainer.Controls.Add(answerItem);
        }

        
    }
}
