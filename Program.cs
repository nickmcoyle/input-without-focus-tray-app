using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeoutBeater.Properties;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Collections;

namespace TimeoutBeater
{
    static class Program
    {        
        public static string processName = Properties.Settings.Default.Name;
        public static string processKeyPress = Properties.Settings.Default.ProcessKeyPress;
        public static bool isEnabled = Properties.Settings.Default.ProcessEnabled;
        public static int Interval = Properties.Settings.Default.Interval;

        const UInt32 WM_KEYDOWN = 0x0100;        
       

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
       string lpWindowName); 

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [STAThread]
        static void Main()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(RefreshIt);
            timer.Interval = Interval;
            //only runs if enabled setting is true
            timer.Enabled =  isEnabled;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MyCustomApplicationContext());

        }

        public static void RefreshIt(object sender, System.Timers.ElapsedEventArgs e)
        {            
                bool isActive = false;
                Process[] processes = Process.GetProcessesByName(processName);
                foreach (var proc in processes)
                {
                    IntPtr currActiveHandle = GetForegroundWindow();
                    int activeProcId;
                    GetWindowThreadProcessId(currActiveHandle, out activeProcId);
                    for (int j = 0; j < processes.Length; ++j)
                    {
                        //if any process from this application matches the active window, then flag so we don't send a keypress to the application
                        if (processes[j].Id == activeProcId)
                        {
                            isActive = true;
                        }

                    }
                    if (!isActive)
                    {
                        int keyPress = KeyPresses[processKeyPress];                        
                        PostMessage(proc.MainWindowHandle, WM_KEYDOWN, keyPress, 0);
                        break; //return after the first keypress is sent
                    }
                }            

        }

        public static Dictionary<string, int> KeyPresses = new Dictionary<string, int>
        {
            {"ESCAPE", 0x1B },
            {"BACKSPACE", 0x08 },
            {"DELETE", 0x2E },
            {"RETURN", 0x0D },
            {"SPACE", 0x20 },
            {"TAB", 0x09 },
            {"ARROWDOWN", 0x28 },
            {"F1", 0x70 },
            {"F2", 0x71 },
            {"F3", 0x72 },
            {"F4", 0x73 },
            {"F5", 0x74 },
            {"F6", 0x75 },
            {"F7", 0x76 },
            {"F8", 0x77 },
            {"F9", 0x78 },
            {"F10", 0x79 },
            {"F11", 0x7A },
            {"F12", 0x7B },
            {"0", 0x30 },
            {"1", 0x31 },
            {"2", 0x32 },
            {"3", 0x33 },
            {"4", 0x34 },
            {"5", 0x35 },
            {"6", 0x36 },
            {"7", 0x37 },
            {"8", 0x38 },
            {"9", 0x39 },
            {"W", 0x57 }
        };


        public class MyCustomApplicationContext : ApplicationContext
        {
            private NotifyIcon trayIcon;

            public MyCustomApplicationContext()
            {
                // Initialize Tray Icon
                trayIcon = new NotifyIcon()
                {
                    Icon = Resources.AppIcon,
                    ContextMenu = new ContextMenu(
                        new MenuItem[] {
                    new MenuItem("Exit", Exit),
                    new MenuItem("Settings", OpenSettings),
                        }),
                    Visible = true
                };
            }

            void OpenSettings(object sender, EventArgs e)
            {
                Form1 SettingsForm = new Form1();
                SettingsForm.Show();
            }

            void Exit(object sender, EventArgs e)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                Application.Exit();
            }
        }
    }
}