using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreator
{
    public partial class Form1 : Form,IForm
    {
        
        public Form1()
        {
            InitializeComponent();
           
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
    }
}
