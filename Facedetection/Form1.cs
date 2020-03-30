using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.IO;

namespace AForgeCamera
{
    public partial class Facedetection : Form
    {
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice captureDevice;
        private VideoCapabilities[] videoCapabilities;
        private VideoCapabilities videoCapabilitie;

        private FaceDetection faceDetection;

        public Facedetection()
        {
            InitializeComponent();
            btn_cam.Enabled = false;
            btn_cam.Text = "Open";
            btn_takePic.Enabled = false;
            pBox_view.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox_faceDst.SizeMode = PictureBoxSizeMode.StretchImage;

            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in CaptureDevices)
            {
                coBox_CamList.Items.Add(filterInfo.Name);
            }
            faceDetection = new FaceDetection();
            faceDetection.FaceDataPath = @"face_data\shape_predictor_5_face_landmarks.dat";
            if (!File.Exists(faceDetection.FaceDataPath))
            {
                throw new Exception("can not find the face_landmarks file");
            }
        }

        private void AForgeCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
                captureDevice.Stop();
            }
            CaptureDevices.Clear();
            AVPlayer_Cam1.VideoSource = null;
            AVPlayer_Cam1.Stop();
        }

        private void coBox_CamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBox_Resolution.Items.Clear();
            FilterInfo filterInfo = CaptureDevices[coBox_CamList.SelectedIndex];
            captureDevice = new VideoCaptureDevice(filterInfo.MonikerString);
            videoCapabilities = captureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilitie in videoCapabilities)
            {
                coBox_Resolution.Items.Add(capabilitie.FrameSize.Width.ToString() +
                "×" + capabilitie.FrameSize.Height.ToString());
            }
            if (coBox_Resolution.Items.Count > 0)
            {
                coBox_Resolution.SelectedIndex = 0;
            }
        }

        private void coBox_Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCapabilitie = videoCapabilities[coBox_Resolution.SelectedIndex];
            btn_cam.Enabled = true;
            btn_takePic.Enabled = true;
            if (AVPlayer_Cam1.IsRunning)
            {
                captureDevice.NewFrame -= new NewFrameEventHandler(FaceDetection);
                
                captureDevice.Stop();
                AVPlayer_Cam1.VideoSource = null;
                AVPlayer_Cam1.VideoSource = null;
                btn_cam.Text = "Open";
            }
        }

        private void btn_cam_Click(object sender, EventArgs e)
        {
            if (btn_cam.Text == "Open")
            {
                captureDevice.VideoResolution = videoCapabilitie;
                AVPlayer_Cam1.VideoSource = captureDevice;
                if (ckBox_DeSwitch.Checked)
                {
                    captureDevice.NewFrame += new NewFrameEventHandler(FaceDetection);
                    btn_takePic.Enabled = false;
                }
                else
                {
                    btn_takePic.Enabled = true;
                }
                ckBox_DeSwitch.Enabled = false;
                captureDevice.SimulateTrigger();
                AVPlayer_Cam1.Start();
                btn_cam.Text = "Close";
                      
            }
            else
            {
                if (ckBox_DeSwitch.Checked)
                { 
                    captureDevice.NewFrame -= new NewFrameEventHandler(FaceDetection);
                }
                ckBox_DeSwitch.Enabled = true;
                pBox_faceDst.Image = null;
                AVPlayer_Cam1.Stop();
                AVPlayer_Cam1.VideoSource = null;
                btn_cam.Text = "Open";
                
            }

        }

        private void FaceDetection(object sender, NewFrameEventArgs eventArgs)
        {
            if (InvokeRequired)
            {
                this.Invoke(new NewFrameEventHandler(FaceDetection), new object[] { sender, eventArgs });
            }
            else
            {
                //Bitmap img = (Bitmap)eventArgs.Frame.Clone();
                int numFaces = 0;
                pBox_faceDst.Image = faceDetection.FaceDetectionFromImage(eventArgs.Frame, out numFaces);
                lb_FaceNum.Text = numFaces.ToString();
            }
        }

        private void btn_takePic_Click(object sender, EventArgs e)
        {
            pBox_view.Image = AVPlayer_Cam1.GetCurrentVideoFrame();
        }
    }
}
