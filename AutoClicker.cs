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

        private Boolean ClickerEnabled = false;

        //Mouse Speed Selectors
        private Boolean Slider;
        private Boolean ManualEntry;

        //Mouse Position Selectors
        private Boolean CurrentPosition;
        private Boolean SetPosition;

        //Mouse Speed Options
        private int Hours;
        private int Minutes;
        private int Seconds;
        private int Milliseconds;
        private int SliderSpeed;

        //Mouse Position Options
        private int XPosition;
        private int YPosition;

        //Click Options
        private int MouseButton;
        private int ClickType;

        public AutoClicker()
        {
            InitializeComponent();

            MouseButtonBox.SelectedIndex = 0;
            MouseButtonBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ClickTypeBox.SelectedIndex = 0;
            ClickTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            CurrentPosRadio.Checked = true;
            ManualRadio.Checked = true;
        }

        private void StartAutoClicker(object sender, EventArgs e)
        {
            if(this.ClickerEnabled == false)
            {
                ClickerThread = new Thread(new ThreadStart(AutoClickerEnableThread));
                ClickerThread.Start();

                this.ClickerEnabled = true;
            }
        }

        private void AutoClickerEnableThread()
        {
            AutoClickerDriver AutoClick = new AutoClickerDriver();
        }

        private void StopAutoClicker(object sender, EventArgs e)
        {
            if (this.ClickerEnabled)
            {
                ClickerThread.Abort();
                this.ClickerEnabled = false;
            }
        }
    }
}
