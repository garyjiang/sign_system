namespace ss4pd
{
    partial class Form1
    {
        
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.first_panel1 = new System.Windows.Forms.Panel();
            this.bt_next1 = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.rb_reject = new System.Windows.Forms.RadioButton();
            this.rb_agree = new System.Windows.Forms.RadioButton();
            this.video_panel = new System.Windows.Forms.Panel();
            this.bt_netx_cup = new System.Windows.Forms.Button();
            this.bt_rescupture = new System.Windows.Forms.Button();
            this.bt_cupture1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.print_panel1 = new System.Windows.Forms.Panel();
            this.prt_pb2 = new System.Windows.Forms.PictureBox();
            this.prt_pb5 = new System.Windows.Forms.PictureBox();
            this.prt_pb6 = new System.Windows.Forms.PictureBox();
            this.prt_pb3 = new System.Windows.Forms.PictureBox();
            this.prt_pb4 = new System.Windows.Forms.PictureBox();
            this.prt_pb1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.first_panel1.SuspendLayout();
            this.video_panel.SuspendLayout();
            this.print_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_panel1
            // 
            this.first_panel1.Controls.Add(this.bt_next1);
            this.first_panel1.Controls.Add(this.bt_cancel);
            this.first_panel1.Controls.Add(this.rb_reject);
            this.first_panel1.Controls.Add(this.rb_agree);
            this.first_panel1.Location = new System.Drawing.Point(12, 354);
            this.first_panel1.Name = "first_panel1";
            this.first_panel1.Size = new System.Drawing.Size(760, 165);
            this.first_panel1.TabIndex = 0;
            this.first_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_next1
            // 
            this.bt_next1.Location = new System.Drawing.Point(338, 129);
            this.bt_next1.Name = "bt_next1";
            this.bt_next1.Size = new System.Drawing.Size(75, 23);
            this.bt_next1.TabIndex = 3;
            this.bt_next1.Text = "下一步";
            this.bt_next1.UseVisualStyleBackColor = true;
            this.bt_next1.Click += new System.EventHandler(this.bt_next1_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(224, 129);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // rb_reject
            // 
            this.rb_reject.AutoSize = true;
            this.rb_reject.Location = new System.Drawing.Point(366, 72);
            this.rb_reject.Name = "rb_reject";
            this.rb_reject.Size = new System.Drawing.Size(47, 16);
            this.rb_reject.TabIndex = 1;
            this.rb_reject.Text = "拒绝";
            this.rb_reject.UseVisualStyleBackColor = true;
            // 
            // rb_agree
            // 
            this.rb_agree.AutoSize = true;
            this.rb_agree.Location = new System.Drawing.Point(224, 72);
            this.rb_agree.Name = "rb_agree";
            this.rb_agree.Size = new System.Drawing.Size(47, 16);
            this.rb_agree.TabIndex = 0;
            this.rb_agree.Text = "同意";
            this.rb_agree.UseVisualStyleBackColor = true;
            // 
            // video_panel
            // 
            this.video_panel.Controls.Add(this.bt_netx_cup);
            this.video_panel.Controls.Add(this.bt_rescupture);
            this.video_panel.Controls.Add(this.bt_cupture1);
            this.video_panel.Controls.Add(this.videoSourcePlayer1);
            this.video_panel.Location = new System.Drawing.Point(74, 15);
            this.video_panel.Name = "video_panel";
            this.video_panel.Size = new System.Drawing.Size(585, 504);
            this.video_panel.TabIndex = 1;
            // 
            // bt_netx_cup
            // 
            this.bt_netx_cup.Location = new System.Drawing.Point(390, 466);
            this.bt_netx_cup.Name = "bt_netx_cup";
            this.bt_netx_cup.Size = new System.Drawing.Size(75, 23);
            this.bt_netx_cup.TabIndex = 3;
            this.bt_netx_cup.Text = "下一步";
            this.bt_netx_cup.UseVisualStyleBackColor = true;
            // 
            // bt_rescupture
            // 
            this.bt_rescupture.Location = new System.Drawing.Point(276, 466);
            this.bt_rescupture.Name = "bt_rescupture";
            this.bt_rescupture.Size = new System.Drawing.Size(75, 23);
            this.bt_rescupture.TabIndex = 2;
            this.bt_rescupture.Text = "重拍";
            this.bt_rescupture.UseVisualStyleBackColor = true;
            this.bt_rescupture.Click += new System.EventHandler(this.bt_rescupture_Click);
            // 
            // bt_cupture1
            // 
            this.bt_cupture1.Location = new System.Drawing.Point(162, 466);
            this.bt_cupture1.Name = "bt_cupture1";
            this.bt_cupture1.Size = new System.Drawing.Size(75, 23);
            this.bt_cupture1.TabIndex = 1;
            this.bt_cupture1.Text = "拍照";
            this.bt_cupture1.UseVisualStyleBackColor = true;
            this.bt_cupture1.Click += new System.EventHandler(this.bt_cupture1_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.Location = new System.Drawing.Point(52, 45);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(480, 360);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // print_panel1
            // 
            this.print_panel1.Controls.Add(this.prt_pb2);
            this.print_panel1.Controls.Add(this.prt_pb5);
            this.print_panel1.Controls.Add(this.prt_pb6);
            this.print_panel1.Controls.Add(this.prt_pb3);
            this.print_panel1.Controls.Add(this.prt_pb4);
            this.print_panel1.Controls.Add(this.prt_pb1);
            this.print_panel1.Location = new System.Drawing.Point(126, 1);
            this.print_panel1.Name = "print_panel1";
            this.print_panel1.Size = new System.Drawing.Size(800, 1088);
            this.print_panel1.TabIndex = 2;
            this.print_panel1.Visible = false;
            // 
            // prt_pb2
            // 
            this.prt_pb2.Location = new System.Drawing.Point(406, 9);
            this.prt_pb2.Name = "prt_pb2";
            this.prt_pb2.Size = new System.Drawing.Size(384, 312);
            this.prt_pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prt_pb2.TabIndex = 1;
            this.prt_pb2.TabStop = false;
            this.prt_pb2.Click += new System.EventHandler(this.prt_pb2_Click);
            // 
            // prt_pb5
            // 
            this.prt_pb5.Location = new System.Drawing.Point(8, 645);
            this.prt_pb5.Name = "prt_pb5";
            this.prt_pb5.Size = new System.Drawing.Size(384, 312);
            this.prt_pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prt_pb5.TabIndex = 5;
            this.prt_pb5.TabStop = false;
            // 
            // prt_pb6
            // 
            this.prt_pb6.Location = new System.Drawing.Point(406, 645);
            this.prt_pb6.Name = "prt_pb6";
            this.prt_pb6.Size = new System.Drawing.Size(384, 312);
            this.prt_pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prt_pb6.TabIndex = 4;
            this.prt_pb6.TabStop = false;
            // 
            // prt_pb3
            // 
            this.prt_pb3.Location = new System.Drawing.Point(8, 327);
            this.prt_pb3.Name = "prt_pb3";
            this.prt_pb3.Size = new System.Drawing.Size(384, 312);
            this.prt_pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prt_pb3.TabIndex = 3;
            this.prt_pb3.TabStop = false;
            // 
            // prt_pb4
            // 
            this.prt_pb4.Location = new System.Drawing.Point(406, 327);
            this.prt_pb4.Name = "prt_pb4";
            this.prt_pb4.Size = new System.Drawing.Size(384, 312);
            this.prt_pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prt_pb4.TabIndex = 2;
            this.prt_pb4.TabStop = false;
            // 
            // prt_pb1
            // 
            this.prt_pb1.Location = new System.Drawing.Point(8, 9);
            this.prt_pb1.Name = "prt_pb1";
            this.prt_pb1.Size = new System.Drawing.Size(384, 312);
            this.prt_pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prt_pb1.TabIndex = 0;
            this.prt_pb1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.video_panel);
            this.Controls.Add(this.first_panel1);
            this.Controls.Add(this.print_panel1);
            this.Name = "Form1";
            this.Text = "电子签名系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.first_panel1.ResumeLayout(false);
            this.first_panel1.PerformLayout();
            this.video_panel.ResumeLayout(false);
            this.print_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prt_pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel first_panel1;
        private System.Windows.Forms.Button bt_next1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.RadioButton rb_reject;
        private System.Windows.Forms.RadioButton rb_agree;
        private System.Windows.Forms.Panel video_panel;
        private System.Windows.Forms.Button bt_netx_cup;
        private System.Windows.Forms.Button bt_rescupture;
        private System.Windows.Forms.Button bt_cupture1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Panel print_panel1;
        private System.Windows.Forms.PictureBox prt_pb5;
        private System.Windows.Forms.PictureBox prt_pb6;
        private System.Windows.Forms.PictureBox prt_pb3;
        private System.Windows.Forms.PictureBox prt_pb4;
        private System.Windows.Forms.PictureBox prt_pb2;
        private System.Windows.Forms.PictureBox prt_pb1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

