using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoClicker
{
    class AutoClickerDriver
    {
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

        //Mouse move value
        private const int MOUSEEVENTF_MOVE = 0x0001;

        //Mouse wheel movement
        private const int MOUSEEVENTF_WHEEL = 0x0800;

        //Mouse tilt wheel movement
        private const int MOUSEEVENTF_HWHEEL = 0x01000;

        private Boolean Enabled = false;

        //Manaul Entry Constructor
        public AutoClickerDriver(int Milliseconds, int Seconds, int Minutes, int Hours, int MouseButton, int ClickType, Point CursorPosition, Boolean ActivePosition, Boolean SetPosition)
        {
            //TODO
        }

        //Slider Entry Constructor
        public AutoClickerDriver(int SliderSpeed, int MouseButton, int ClickerType, Point CursorPosition, Boolean ActivePosition, Boolean SetPosition)
        {
            //TODO
        }

        //Left click the mouse
        private static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(1);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        //Middle click the mouse
        private static void MiddleClick()
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
            Thread.Sleep(1);
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
        }

        //Right click the mouse
        private static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(1);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        //Move the mouse based on the change in x and y values
        private static void MoveMouse(int dx, int dy)
        {
            mouse_event(MOUSEEVENTF_MOVE, dx, dy, 0, 0);
        }

        //Acceleration for mouse movement
        private static double Acceleration(double a0, double a1, double b0, double b1, double a)
        {
            return b0 + (b1 - b0) * ((a - a0) / (a1 - a0));
        }

    }
}
