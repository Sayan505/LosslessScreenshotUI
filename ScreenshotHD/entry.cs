using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing;
using System.Drawing.Imaging;


//CONTROLS:
//CTRL+F12, CAPTURE SCREENSHOT.

namespace ScreenshotHD

{
    class entry
    {
        RNGCryptoServiceProvider rNG = new RNGCryptoServiceProvider();
        byte[] x = new byte[4]; //4 = INT32

        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SSUI());

        }

        public void takeSS()
        {
            //set data location
            Bitmap _bmx = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                    Screen.PrimaryScreen.Bounds.Height,
                                    PixelFormat.Format32bppArgb);

            //get screen rect
            Rectangle _rect = Screen.AllScreens[0].Bounds;

            //capture screenshot
            Graphics pic = Graphics.FromImage(_bmx);
            pic.CopyFromScreen(_rect.Left, _rect.Top, 0, 0, _rect.Size);

            //save
            
            
            rNG.GetNonZeroBytes(x);
            uint rnd = BitConverter.ToUInt32(x, 0);
            _bmx.Save(AppDomain.CurrentDomain.BaseDirectory + rnd + ".bmp", ImageFormat.Png);

            //dispose
            _bmx.Dispose(); pic.Dispose();
        }
    }
}
