using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {

        private Thread ClickerThread;
        private Boolean ClickerEnabled;

        public AutoClicker()
        {
            InitializeComponent();

        }

        private void StartAutoClicker(object sender, EventArgs e)
        {

        }

        private void StopAutoClicker(object sender, EventArgs e)
        {

        }
    }
}
