using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelViewer
{
    enum Channels
    {
        Red,
        Green,
        Blue,
        All
    }
    public partial class Form1 : Form
    {
        Bitmap printscreen;
        double DPI = int.Parse((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ThemeManager", "LastLoadedDPI", "96")) / 100.0;
        Point scaledScreenSize;
        readonly ColorMatrix redMatrix = new ColorMatrix(new float[][]
                {
                    new float[]{1, 1, 1, 0, 0 },
                    new float[]{0, 0, 0, 0, 0 },
                    new float[]{0, 0, 0, 0, 0 },
                    new float[]{0, 0, 0, 1, 0 },
                    new float[]{0, 0, 0, 0, 1 }
                });
        readonly ColorMatrix greenMatrix = new ColorMatrix(new float[][]
                {
                    new float[]{0, 0, 0, 1, 0 },
                    new float[]{1, 1, 1, 0, 0 },
                    new float[]{0, 0, 0, 0, 0 },
                    new float[]{0, 0, 0, 1, 0 },
                    new float[]{0, 0, 0, 0, 1 }
                });
        readonly ColorMatrix blueMatrix = new ColorMatrix(new float[][]
                {
                    new float[]{0, 0, 0, 1, 0 },
                    new float[]{0, 0, 0, 0, 0 },
                    new float[]{1, 1, 1, 0, 0 },
                    new float[]{0, 0, 0, 1, 0 },
                    new float[]{0, 0, 0, 0, 1 }
                });
        readonly ColorMatrix defaultMatrix = new ColorMatrix(new float[][]
                {
                    new float[]{1, 0, 0, 0, 0 },
                    new float[]{0, 1, 0, 0, 0 },
                    new float[]{0, 0, 1, 0, 0 },
                    new float[]{0, 0, 0, 1, 0 },
                    new float[]{0, 0, 0, 0, 1 }
                });
        ImageAttributes imageAttributes = new ImageAttributes();
        public Form1()
        {
            InitializeComponent();
            scaledScreenSize = new Point((int)(Screen.PrimaryScreen.Bounds.Width * DPI), (int)(Screen.PrimaryScreen.Bounds.Width * DPI));
            printscreen = new Bitmap(scaledScreenSize.X, scaledScreenSize.Y);
            Timer timer = new Timer();
            timer.Interval = 66;
            timer.Tick += Timer_Tick;
            timer.Start();
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.R:
                    rb_Red.Checked = true;
                    break;
                case Keys.D2:
                case Keys.G:
                    rb_Green.Checked = true;
                    break;
                case Keys.D3:
                case Keys.B:
                    rb_Blue.Checked = true;
                    break;
                case Keys.D4:
                case Keys.A:
                    rb_All.Checked = true;
                    break;
                case Keys.P:
                case Keys.Space:
                    updatePosition = !updatePosition;
                    break;
                case Keys.PageDown:
                    tb_Zoom.Value = Math.Min(tb_Zoom.Value + 1, tb_Zoom.Maximum);
                    break;
                case Keys.PageUp:
                    tb_Zoom.Value = Math.Max(tb_Zoom.Value - 1, tb_Zoom.Minimum);
                    break;
            }
        }
        bool updatePosition = true;
        Point position = new Point(0, 0);
        public int ClampXToScreen(int number)
        {
            return Math.Min(Math.Max(number, 1), scaledScreenSize.X- 1);
        }
        public int ClampYToScreen(int number)
        {
            return Math.Min(Math.Max(number, 1), scaledScreenSize.Y - 1);
        }
        private Channels GetActiveChannel()
        {
            if (rb_Red.Checked == true) { return Channels.Red; }
            else if (rb_Green.Checked == true) { return Channels.Green; }
            else if (rb_Blue.Checked == true) { return Channels.Blue; }
            else return Channels.All;
        }
   
        void RefreshImage_Matrix()
        {
            if (updatePosition)
            {
                position = new Point((int)(Cursor.Position.X * DPI), (int)(Cursor.Position.Y * DPI));
            }
            //activeColor
            Channels activeChannel = GetActiveChannel();

            ColorMatrix colorMatrix;
            switch (activeChannel)
            {
                case Channels.Red:
                    colorMatrix = redMatrix;
                    break;
                case Channels.Green:
                    colorMatrix = greenMatrix;
                    break;
                case Channels.Blue:
                    colorMatrix = blueMatrix;
                    break;
                default:
                    colorMatrix = defaultMatrix;
                    break;
                    
            }
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            DPI = Math.Round(DPI * 2) / 2;
            int sizeX = (int)(pb_MainImage.Width * DPI);
            int sizeY = (int)(pb_MainImage.Height * DPI);
            int zoom = tb_Zoom.Value;
            Size scaledSize = new Size((int)(pb_MainImage.Width * DPI), (int)(pb_MainImage.Height * DPI));
            Bitmap bm_dest = new Bitmap(sizeX * zoom, sizeY * zoom);
                
            //Screenshot
            Graphics printGraphics = Graphics.FromImage(printscreen);
            printGraphics.Clear(Color.Black);
            printGraphics.CopyFromScreen(position.X - (scaledSize.Width / 2) * zoom, position.Y - (scaledSize.Height / 2) * zoom, 0, 0, new Size(scaledSize.Width*zoom, scaledSize.Height * zoom));
            
            Graphics destGraphics = Graphics.FromImage(bm_dest);
            destGraphics.DrawImage(printscreen, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pb_MainImage.Image = bm_dest;
            pb_MainImage.Refresh();

            //Update ColorValues
            Color pixelValues = printscreen.GetPixel(scaledSize.Width / 2, scaledSize.Height / 2);
            Form1 form1 = this;
            form1.Text = "ChannelViewer    RED:" + pixelValues.R + "   GREEN:" + pixelValues.G + "   BLUE:" + pixelValues.B;
            GC.Collect();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            RefreshImage_Matrix();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
