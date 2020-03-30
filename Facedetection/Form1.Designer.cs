namespace AForgeCamera
{
    partial class Facedetection
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AVPlayer_Cam1 = new AForge.Controls.VideoSourcePlayer();
            this.btn_cam = new System.Windows.Forms.Button();
            this.coBox_CamList = new System.Windows.Forms.ComboBox();
            this.lb_CamList = new System.Windows.Forms.Label();
            this.btn_takePic = new System.Windows.Forms.Button();
            this.pBox_view = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coBox_Resolution = new System.Windows.Forms.ComboBox();
            this.pBox_faceDst = new System.Windows.Forms.PictureBox();
            this.lb_FaceNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckBox_DeSwitch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_faceDst)).BeginInit();
            this.SuspendLayout();
            // 
            // AVPlayer_Cam1
            // 
            this.AVPlayer_Cam1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AVPlayer_Cam1.Location = new System.Drawing.Point(12, 37);
            this.AVPlayer_Cam1.Name = "AVPlayer_Cam1";
            this.AVPlayer_Cam1.Size = new System.Drawing.Size(520, 380);
            this.AVPlayer_Cam1.TabIndex = 0;
            this.AVPlayer_Cam1.Text = "videoSourcePlayer1";
            this.AVPlayer_Cam1.VideoSource = null;
            // 
            // btn_cam
            // 
            this.btn_cam.Location = new System.Drawing.Point(505, 9);
            this.btn_cam.Name = "btn_cam";
            this.btn_cam.Size = new System.Drawing.Size(75, 23);
            this.btn_cam.TabIndex = 1;
            this.btn_cam.Text = "Open";
            this.btn_cam.UseVisualStyleBackColor = true;
            this.btn_cam.Click += new System.EventHandler(this.btn_cam_Click);
            // 
            // coBox_CamList
            // 
            this.coBox_CamList.FormattingEnabled = true;
            this.coBox_CamList.Location = new System.Drawing.Point(71, 11);
            this.coBox_CamList.Name = "coBox_CamList";
            this.coBox_CamList.Size = new System.Drawing.Size(177, 20);
            this.coBox_CamList.TabIndex = 3;
            this.coBox_CamList.SelectedIndexChanged += new System.EventHandler(this.coBox_CamList_SelectedIndexChanged);
            // 
            // lb_CamList
            // 
            this.lb_CamList.AutoSize = true;
            this.lb_CamList.Location = new System.Drawing.Point(12, 14);
            this.lb_CamList.Name = "lb_CamList";
            this.lb_CamList.Size = new System.Drawing.Size(53, 12);
            this.lb_CamList.TabIndex = 4;
            this.lb_CamList.Text = "Camera：";
            // 
            // btn_takePic
            // 
            this.btn_takePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_takePic.Location = new System.Drawing.Point(271, 423);
            this.btn_takePic.Name = "btn_takePic";
            this.btn_takePic.Size = new System.Drawing.Size(75, 23);
            this.btn_takePic.TabIndex = 6;
            this.btn_takePic.Text = "Photograph";
            this.btn_takePic.UseVisualStyleBackColor = true;
            this.btn_takePic.Click += new System.EventHandler(this.btn_takePic_Click);
            // 
            // pBox_view
            // 
            this.pBox_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBox_view.Location = new System.Drawing.Point(14, 423);
            this.pBox_view.Name = "pBox_view";
            this.pBox_view.Size = new System.Drawing.Size(251, 152);
            this.pBox_view.TabIndex = 7;
            this.pBox_view.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resolution Ratio";
            // 
            // coBox_Resolution
            // 
            this.coBox_Resolution.FormattingEnabled = true;
            this.coBox_Resolution.Location = new System.Drawing.Point(361, 11);
            this.coBox_Resolution.Name = "coBox_Resolution";
            this.coBox_Resolution.Size = new System.Drawing.Size(138, 20);
            this.coBox_Resolution.TabIndex = 9;
            this.coBox_Resolution.SelectedIndexChanged += new System.EventHandler(this.coBox_Resolution_SelectedIndexChanged);
            // 
            // pBox_faceDst
            // 
            this.pBox_faceDst.Location = new System.Drawing.Point(538, 37);
            this.pBox_faceDst.Name = "pBox_faceDst";
            this.pBox_faceDst.Size = new System.Drawing.Size(520, 380);
            this.pBox_faceDst.TabIndex = 10;
            this.pBox_faceDst.TabStop = false;
            // 
            // lb_FaceNum
            // 
            this.lb_FaceNum.AutoSize = true;
            this.lb_FaceNum.Location = new System.Drawing.Point(997, 14);
            this.lb_FaceNum.Name = "lb_FaceNum";
            this.lb_FaceNum.Size = new System.Drawing.Size(11, 12);
            this.lb_FaceNum.TabIndex = 11;
            this.lb_FaceNum.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Faces number：";
            // 
            // ckBox_DeSwitch
            // 
            this.ckBox_DeSwitch.AutoSize = true;
            this.ckBox_DeSwitch.Checked = true;
            this.ckBox_DeSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_DeSwitch.Location = new System.Drawing.Point(632, 15);
            this.ckBox_DeSwitch.Name = "ckBox_DeSwitch";
            this.ckBox_DeSwitch.Size = new System.Drawing.Size(120, 16);
            this.ckBox_DeSwitch.TabIndex = 13;
            this.ckBox_DeSwitch.Text = "Detection Switch";
            this.ckBox_DeSwitch.UseVisualStyleBackColor = true;
            // 
            // Facedetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 587);
            this.Controls.Add(this.ckBox_DeSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_FaceNum);
            this.Controls.Add(this.pBox_faceDst);
            this.Controls.Add(this.coBox_Resolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBox_view);
            this.Controls.Add(this.btn_takePic);
            this.Controls.Add(this.lb_CamList);
            this.Controls.Add(this.coBox_CamList);
            this.Controls.Add(this.btn_cam);
            this.Controls.Add(this.AVPlayer_Cam1);
            this.Name = "Facedetection";
            this.Text = "Facedetection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AForgeCamera_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_faceDst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer AVPlayer_Cam1;
        private System.Windows.Forms.Button btn_cam;
        private System.Windows.Forms.ComboBox coBox_CamList;
        private System.Windows.Forms.Label lb_CamList;
        private System.Windows.Forms.Button btn_takePic;
        private System.Windows.Forms.PictureBox pBox_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coBox_Resolution;
        private System.Windows.Forms.PictureBox pBox_faceDst;
        private System.Windows.Forms.Label lb_FaceNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckBox_DeSwitch;
    }
}

