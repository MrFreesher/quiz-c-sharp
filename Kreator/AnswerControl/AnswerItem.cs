using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreator.AnswerControl {
    public partial class AnswerItem : UserControl, IAnswerItem {
        public AnswerItem() {
            InitializeComponent();
        }

        public string AnswerContent => answerContentInput.Text;

        public int Points => Convert.ToInt32(answerPointInput.Value);
    }
}
