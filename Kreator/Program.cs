using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreator {
    static class Program {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main() {
            IForm view = new Form1();
            IFormPresenter presenter = new Presenter(view);

            Application.EnableVisualStyles();

            Application.Run((Form)view);
        }
    }
}
