using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreator.TestInfoControl {
    public partial class TestInfoItem : UserControl,ITestInfoItem {
        public TestInfoItem() {
            InitializeComponent();
        }

        public string Title => testTitleInput.Text;

        public string Author => testAuthorInput.Text;

        public string Description => testDescriptionInput.Text;

        public event Action SaveTestInfo;


        private void SaveTestBtn_Click() {
            if (SaveTestInfo != null) {
                SaveTestInfo();
            };

        }
    }
}
