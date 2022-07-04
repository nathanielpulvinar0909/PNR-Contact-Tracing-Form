using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace PNR_Contact_Tracing_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //FilterInfoCollection FilterInfoCollection;
        //VideoCaptureDevice captureDevice;


        private void Form4_Load(object sender, EventArgs e)
        {
            //FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo filterInfo in FilterInfoCollection)
            //    cmbbxDevice.Items.Add(filterInfo.Name);
            //cmbbxDevice.SelectedIndex = 0;
        }
        //private void btnStartCamera_Click(object sender, EventArgs e)
        //{
        //    captureDevice = new VideoCaptureDevice(FilterInfoCollection[cmbbxDevice.SelectedIndex].MonikerString);
        //    captureDevice.NewFrame += CaptureDevice_NewFrame;
        //    captureDevice.Start();
        //    timer1.Start();
        //}

        //private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    pctrbxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        //}

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (captureDevice.IsRunning)
            //    captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (pctrbxCamera.Image != null)
            //{

            //}
            //{
            //    BarcodeReader barcodeReader = new BarcodeReader();
            //    Result data = barcodeReader.Decode((Bitmap)pctrbxCamera.Image);
            //    if (data != null)
            //    {
            //        txtbxQRCodeInformation.Text = Result.ToString();
            //        timer1.Stop();
            //        if (captureDevice.IsRunning)
            //            captureDevice.Stop();
            //    }
            //}
        }
    }
}
