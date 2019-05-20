using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreator.QuestionItem {
    public partial class QuestionItem : UserControl,IQuestionItem {
        public QuestionItem() {
            InitializeComponent();
        }

        public string Content => questionContentInput.Text;

        public void ClearAnswerContainer() {
            answersContainer.Controls.Clear();
        }

        public void ClearQuestionContent() {
            questionContentInput.Text = "";
        }
    }
}
