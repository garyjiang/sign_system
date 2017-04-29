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
            this.ControlBox = false;
            
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
                //this.pictureBox1.Hide();
                this.print_panel1.Hide();
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
            if (pic_list.Count < 6)
            {
                pic_list.Add(sv_img);
                if (pic_list.Count == 6)
                {
                    //MessageBox.Show("照片组已经满，现在开始清除");
                    //将照片组中的照片分别分配给不同的picturebox
                    string a_pic1 = pic_list[0].ToString();
                    string a_pic2 = pic_list[1].ToString();
                    string a_pic3 = pic_list[2].ToString();
                    string a_pic4 = pic_list[3].ToString();
                    string a_pic5 = pic_list[4].ToString();
                    string a_pic6 = pic_list[5].ToString();
                    prt_pb1.Image = System.Drawing.Image.FromFile(a_pic1);
                    prt_pb2.Image = System.Drawing.Image.FromFile(a_pic2);
                    prt_pb3.Image = System.Drawing.Image.FromFile(a_pic3);
                    prt_pb4.Image = System.Drawing.Image.FromFile(a_pic4);
                    prt_pb5.Image = System.Drawing.Image.FromFile(a_pic5);
                    prt_pb6.Image = System.Drawing.Image.FromFile(a_pic6);

                    video_panel.Hide(); //隐藏视频panel
                    print_panel1.Show(); //显示要打印的panel
                    
                }
                
            }
            //if (pic_list.Count == 6)    //检查打印页是否满6张照片，如果满，清楚所有元素，否则添加一个元素
            //{
            //    MessageBox.Show("照片组已经满，现在开始清除");
            //    string a_pic1 = pic_list[0].ToString();
            //    string a_pic2 = pic_list[1].ToString();
            //    string a_pic3 = pic_list[2].ToString();
            //    string a_pic4 = pic_list[3].ToString();
            //    string a_pic5 = pic_list[4].ToString();
            //    string a_pic6 = pic_list[5].ToString();
            //    prt_pb1.Image = System.Drawing.Image.FromFile(a_pic1);
            //    prt_pb2.Image = System.Drawing.Image.FromFile(a_pic2);
            //    prt_pb3.Image = System.Drawing.Image.FromFile(a_pic3);
            //    prt_pb4.Image = System.Drawing.Image.FromFile(a_pic4);
            //    prt_pb5.Image = System.Drawing.Image.FromFile(a_pic5);
            //    prt_pb6.Image = System.Drawing.Image.FromFile(a_pic6);
            //
            //    video_panel.Hide();
            //    print_panel1.Show();
            //    //prt_pb1.Image = System.Drawing.Image.FromFile(string pic_list[0]);
            //
            //    //pic_list.Clear();
            //}
            //else
            //{
            //    pic_list.Add(sv_img); //添加照片路径至数组
            //   //foreach (string i in pic_list)
            //   //{
            //   //    prt_pb1.Image = System.Drawing.Image.FromFile(i); ;
            //   //    
            //   //}
            //}
            
            //pictureBox1.Image = System.Drawing.Image.FromFile(sv_img);
            //if (pictureBox1.Image != null)
            //{
            //    videoSourcePlayer1.Hide();
            //}
        }

        private void prt_pb2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap _NewBitmap = new Bitmap(print_panel1.Width, print_panel1.Height);
            print_panel1.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            e.Graphics.DrawImage(_NewBitmap, 0, 0, _NewBitmap.Width, _NewBitmap.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.printDialog1.Document = this.printDocument1;
            //if (this.printDialog1.ShowDialog() == DialogResult.OK)
            //{
            printDocument1.PrintController = new System.Drawing.Printing.StandardPrintController(); //隐藏打印窗口    
            this.printDocument1.Print(); //直接打印
            //}
        }

        private void bt_rescupture_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image.Dispose();
            //if (pictureBox1.Image != null)
            //{
            //    pictureBox1.Image = null;
            //    videoSourcePlayer1.Show();
            //
            //}
            try
            {
                if (File.Exists(sv_img))
                {

                    File.Delete(sv_img);
                }
            }
            catch (Exception)
            {

            }
        }


        //窗口关闭，如果摄像头开启，则关闭
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "确认要退出吗？", 
                "退出", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if ( dr == DialogResult.Yes )
            {
                e.Cancel = false;
                
                if (!(videoSource == null))
                {
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource = null;
                    }
                }
                try
                {
                    System.Environment.Exit(0);
                }
                catch (Exception)
                {
                    return;
                }
                    

                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

    }
}
