using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenshotHD
{
    public partial class SSUI : Form
    {
        entry objx = new entry();

        //calling win32 APIs
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public SSUI()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 69, 0x0002 | 0x4000, 0x7B); //0x7B 12; 0x0002 MOD_CONTROL; 0x4000 MOD_NOREPEAT
            //Hotkey ID 69
        }

        protected override void WndProc(ref Message msg)
        {
            

            switch (msg.Msg)
            {
                case 0x0312:
                    base.WndProc(ref msg);
                    Visible = false;
                    objx.takeSS();
                    Visible=true;
                    break;

                case 0x84:
                    base.WndProc(ref msg);
                    if ((int)msg.Result == 0x1)
                    {
                        msg.Result = (IntPtr)0x2;
                        return;
                    }
                    break;
            }
            base.WndProc(ref msg);

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, 69);
            Application.Exit();
        }

        private void CAPTURE_Click(object sender, EventArgs e)
        {
            Visible = false;
            objx.takeSS();
            Visible = true;
        }
        private void SSUI_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
