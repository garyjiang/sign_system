using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.IO;

namespace ss4pd
{
    public partial class Form1 : Form
    {
        string sv_img = null;
        ArrayList pic_list = new ArrayList();
        private FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        public int selectedDeviceIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.video_panel.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_next1_Click(object sender, EventArgs e)
        {
            if (rb_agree.Checked)
            {
                this.first_panel1.Hide();
                //MessageBox.Show("Hello,Text","提示");
                this.video_panel.Show();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                selectedDeviceIndex = 0;
                videoSource = new VideoCaptureDevice(videoDevices[selectedDeviceIndex].MonikerString);
                videoSource.VideoResolution = videoSource.VideoCapabilities[selectedDeviceIndex];
                videoSourcePlayer1.VideoSource = videoSource;
                videoSourcePlayer1.Start();
            }
            else
            {
                rb_reject.Checked = false;


            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            rb_reject.Checked = false;
            rb_agree.Checked = false;
        }

        private void bt_cupture1_Click(object sender, EventArgs e) //拍照按钮
        {
            if (videoSource == null)
                return;
            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            string filenName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".jpg";  //按照日期时间给照片命名

            bitmap.Save(@"E:\Temp\" + filenName, ImageFormat.Jpeg); //保存照片
            bitmap.Dispose();
            //string sv_img = (@"E:\Temp\" + filenName);
            sv_img = (@"E:\Temp\" + filenName);
            if (pic_list.Count == 6)    //检查打印页是否满6张照片，如果满，清楚所有元素，否则添加一个元素
            {
                pic_list.Clear();
            }
            else
            {
                pic_list.Add(sv_img);
            }
            
            //pictureBox1.Image = System.Drawing.Image.FromFile(sv_img);
            //if (pictureBox1.Image != null)
            //{
            //    videoSourcePlayer1.Hide();
            //}
        }
    }
}
