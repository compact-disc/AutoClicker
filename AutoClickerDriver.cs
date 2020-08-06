using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;

namespace AutoClicker
{
    class AutoClickerDriver
    {
        //Set the cursor position
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);
        //Mouse event method to be called with parameters for mouse functions
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //Mouse left click values
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        //Mouse middle click values
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        //Mouse right click values
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;

        private int TotalMilliseconds;

        private System.Timers.Timer TickTimer;

        private int MouseButton, ClickType, NumberOfClicks;
        private Point CursorPosition;
        private Boolean ActivePosition, SetPosition, Slider, ManualEntry;

        //Manual Entry Constructor
        public AutoClickerDriver(int TotalMilliseconds, int MouseButton, int ClickType, Point CursorPosition, Boolean ActivePosition, Boolean SetPosition, Boolean Slider, Boolean ManualEntry)
        {
            this.TotalMilliseconds = TotalMilliseconds;
            this.MouseButton = MouseButton;
            this.ClickType = ClickType;
            this.CursorPosition = CursorPosition;
            this.ActivePosition = ActivePosition;
            this.SetPosition = SetPosition;
            this.Slider = Slider;
            this.ManualEntry = ManualEntry;

            if(this.ClickType == 0)
            {
                this.NumberOfClicks = 1;
            }
            else if(this.ClickType == 1)
            {
                this.NumberOfClicks = 2;
            }

            if (this.ActivePosition)
            {
                this.TickTimer = new System.Timers.Timer(this.TotalMilliseconds);
                this.TickTimer.Elapsed += ActivePositionTick;
                this.TickTimer.Start();
            }
            else if (this.SetPosition)
            {
                this.TickTimer = new System.Timers.Timer(this.TotalMilliseconds);
                this.TickTimer.Elapsed += SetPositionTick;
                this.TickTimer.Start();
            }
        }

        private void ActivePositionTick(Object source, ElapsedEventArgs e)
        {
            if (!AutoClicker.ClickerEnabled)
            {
                this.TickTimer.Stop();
            }

            switch (this.MouseButton)
            {
                //Left Click
                case 0:
                    for(int i = 0; i < this.NumberOfClicks; i++)
                    {
                        LeftClick();
                    }
                    break;

                //Middle Click
                case 1:
                    for (int i = 0; i < this.NumberOfClicks; i++)
                    {
                        MiddleClick();
                    }
                    break;

                //Right Click
                case 2:
                    for (int i = 0; i < this.NumberOfClicks; i++)
                    {
                        RightClick();
                    }
                    break;
            }
        }

        private void SetPositionTick(Object source, ElapsedEventArgs e)
        {
            if (!AutoClicker.ClickerEnabled)
            {
                this.TickTimer.Stop();
            }

            switch (this.MouseButton)
            {
                //Left Click
                case 0:
                    for (int i = 0; i < this.NumberOfClicks; i++)
                    {
                        PosLeftClick(this.CursorPosition.X, this.CursorPosition.Y);
                    }
                    break;

                //Middle Click
                case 1:
                    for (int i = 0; i < this.NumberOfClicks; i++)
                    {
                        PosMiddleClick(this.CursorPosition.X, this.CursorPosition.Y);
                    }
                    break;

                //Right Click
                case 2:
                    for (int i = 0; i < this.NumberOfClicks; i++)
                    {
                        PosRightClick(this.CursorPosition.X, this.CursorPosition.Y);
                    }
                    break;
            }
        }

        //Left click the mouse
        private static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        //Middle click the mouse
        private static void MiddleClick()
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
        }

        //Right click the mouse
        private static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void PosLeftClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }
        
        private void PosMiddleClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_MIDDLEUP, x, y, 0, 0);
        }

        private void PosRightClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
        }
    }
}
