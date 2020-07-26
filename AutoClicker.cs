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

        //Separate thread to run the clicking operation
        private Thread ClickerThread;

        //Boolean to check if the clicker thread is running
        private Boolean ClickerEnabled = false;

        //Mouse Speed Selectors
        private Boolean Slider;
        private Boolean ManualEntry;

        //Mouse Position Selectors
        private Boolean CurrentPosition;
        private Boolean SetPosition;

        //Mouse Speed Options for manual entry
        private int Hours;
        private int Minutes;
        private int Seconds;
        private int Milliseconds;

        //Slider Speed
        private int SliderSpeed;

        //Mouse Position Options
        private int XPosition;
        private int YPosition;

        //Click Options
        private int MouseButton;
        private int ClickType;

        //Constructor to start the window and set defaults
        public AutoClicker()
        {
            InitializeComponent();

            MouseButtonBox.SelectedIndex = 0;
            MouseButtonBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ClickTypeBox.SelectedIndex = 0;
            ClickTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            CurrentPosRadio.Checked = true;
            ManualRadio.Checked = true;

            ClearButton.BackColor = Color.LightBlue;

            StopButton.Enabled = false;
            StopButton.BackColor = Color.Empty;

            StartButton.BackColor = Color.LightGreen;

            XPos.Enabled = false;
            YPos.Enabled = false;

            SpeedSlider.Enabled = false;

            this.Slider = false;
            this.ManualEntry = true;

            this.CurrentPosition = true;
            this.SetPosition = false;

            this.Hours = 0;
            this.Minutes = 0;
            this.Seconds = 0;
            this.Milliseconds = 0;

            this.SliderSpeed = 0;

            this.XPosition = 0;
            this.YPosition = 0;

            this.MouseButton = 0;
            this.ClickType = 0;
        }

        private void StartAutoClicker(object sender, EventArgs e)
        {
            if(this.ClickerEnabled == false)
            {
                ClickerThread = new Thread(new ThreadStart(AutoClickerEnableThread));
                ClickerThread.Start();

                this.ClickerEnabled = true;

                StartButton.BackColor = Color.Empty;
                StopButton.BackColor = Color.IndianRed;
                ClearButton.BackColor = Color.Empty;

                StartButton.Enabled = false;
                StopButton.Enabled = true;
                ClearButton.Enabled = false;

                ManualRadio.Enabled = false;
                SliderRadio.Enabled = false;
                CurrentPosRadio.Enabled = false;
                SetPosRadio.Enabled = false;

                if (ManualRadio.Checked)
                {
                    HoursBox.Enabled = false;
                    MinutesBox.Enabled = false;
                    SecondsBox.Enabled = false;
                    MillisecondsBox.Enabled = false;

                    ManualRadio.Enabled = false;
                    SliderRadio.Enabled = false;
                    CurrentPosRadio.Enabled = false;
                    SetPosRadio.Enabled = false;

                    MouseButtonBox.Enabled = false;
                    ClickTypeBox.Enabled = false;

                    if (SetPosRadio.Checked)
                    {
                        XPos.Enabled = false;
                        YPos.Enabled = false;
                    }
                }
                else if (SliderRadio.Checked)
                {
                    SpeedSlider.Enabled = false;

                    MouseButtonBox.Enabled = false;
                    ClickTypeBox.Enabled = false;

                    if (SetPosRadio.Checked)
                    {
                        XPos.Enabled = false;
                        YPos.Enabled = false;
                    }
                }
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

                StartButton.BackColor = Color.LightGreen;
                StopButton.BackColor = Color.Empty;
                ClearButton.BackColor = Color.LightBlue;

                StartButton.Enabled = true;
                StopButton.Enabled = false;
                ClearButton.Enabled = true;

                ManualRadio.Enabled = true;
                SliderRadio.Enabled = true;
                CurrentPosRadio.Enabled = true;
                SetPosRadio.Enabled = true;

                if (ManualRadio.Checked)
                {
                    HoursBox.Enabled = true;
                    MinutesBox.Enabled = true;
                    SecondsBox.Enabled = true;
                    MillisecondsBox.Enabled = true;

                    ManualRadio.Enabled = true;
                    SliderRadio.Enabled = true;
                    CurrentPosRadio.Enabled = true;
                    SetPosRadio.Enabled = true;

                    MouseButtonBox.Enabled = true;
                    ClickTypeBox.Enabled = true;

                    if (SetPosRadio.Checked)
                    {
                        XPos.Enabled = true;
                        YPos.Enabled = true;
                    }
                }
                else if (SliderRadio.Checked)
                {
                    SpeedSlider.Enabled = true;

                    MouseButtonBox.Enabled = true;
                    ClickTypeBox.Enabled = true;

                    if (SetPosRadio.Checked)
                    {
                        XPos.Enabled = true;
                        YPos.Enabled = true;
                    }
                }
            }
        }

        private void ClearEntryBoxes(object sender, EventArgs e)
        {
            HoursBox.Text = "";
            MinutesBox.Text = "";
            SecondsBox.Text = "";
            MillisecondsBox.Text = "";
            XPos.Text = "";
            YPos.Text = "";

            MouseButtonBox.SelectedIndex = 0;
            ClickTypeBox.SelectedIndex = 0;
        }

        private void SetPositionRadioSelector(object sender, EventArgs e)
        {
            XPos.Enabled = true;
            YPos.Enabled = true;
        }

        private void SetCurrentPositionRadioSelector(object sender, EventArgs e)
        {
            XPos.Enabled = false;
            YPos.Enabled = false;
        }

        private void SetManualEntryRadioSelector(object sender, EventArgs e)
        {
            SpeedSlider.Enabled = false;
            HoursBox.Enabled = true;
            MinutesBox.Enabled = true;
            SecondsBox.Enabled = true;
            MillisecondsBox.Enabled = true;
        }

        private void SetSliderRadioButton(object sender, EventArgs e)
        {
            SpeedSlider.Enabled = true;
            HoursBox.Enabled = false;
            MinutesBox.Enabled = false;
            SecondsBox.Enabled = false;
            MillisecondsBox.Enabled = false;
        }

        private void NumericValidation(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled= true;
            }
        }
    }
}
