using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Configuration;

namespace Gesture_Recognition_Proj
{
    public partial class Form1 : Form
    {
        IColorSkinDetector skinDetector;

        Image<Bgr, Byte> currentFrame;
        Image<Bgr, Byte> currentFrameCopy;

        Capture grabber;
        AdaptiveSkinDetector detector;

        
        int frameWidth;
        int frameHeight;

        int filteredNum;

        System.Timers.Timer timer = new System.Timers.Timer(1500);
        

        Hsv hsv_min;
        Hsv hsv_max;
        Ycc YCrCb_min;
        Ycc YCrCb_max;

        String debugFingersFiltered="";
        String debugFingersUnfiltered = "";

        bool showContour, showHull, showFingerTrack, showAdditional;

        Seq<Point> hull;
        Seq<Point> filteredHull;
        Seq<MCvConvexityDefect> defects;
        MCvConvexityDefect[] defectArray;
        Rectangle handRect;
        MCvBox2D box;
        Ellipse ellip;
        MemStorage storage = new MemStorage();
        public Form1()
        {
            InitializeComponent();

            //Camera Selection. Not implemented
            //DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            //Video_Device[] WebCams = new Video_Device[_SystemCamereas.Length];
            //for (int i = 0; i < _SystemCamereas.Length; i++)
            //{
            //    WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
            //    Camera_Selection.Items.Add(WebCams[i].ToString());
            //}
            timer.Elapsed += timer_Elapsed;

            try
            {
                grabber = new Emgu.CV.Capture(0);
            }
            catch (Exception)
            {
                
                 grabber = new Emgu.CV.Capture(1);
            }
            grabber.QueryFrame();
            frameWidth = grabber.Width;
            frameHeight = grabber.Height;
            detector = new AdaptiveSkinDetector(1, AdaptiveSkinDetector.MorphingMethod.NONE);
            hsv_min = new Hsv(0, 10*(255/100), 30*(255/100));
            hsv_max = new Hsv(30, 90 * (255 / 100), 95 * (255 / 100));
            YCrCb_min = new Ycc(0, 131, 80);
            YCrCb_max = new Ycc(255, 185, 135);
            box = new MCvBox2D();
            ellip = new Ellipse();

            

            //Application.Idle += new EventHandler(FrameGrabber);        
            //Application.Idle += Application_Idle;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            debugFingersFiltered = "Fingers detected: " + filteredNum.ToString();

            try
            {
                if (filteredNum != 0)
                {
                    System.Media.SystemSounds.Beep.Play();
                    switch (filteredNum)
                    {
                        case 1:
                            if (oneFingerPath.Text != String.Empty)
                                System.Diagnostics.Process.Start(oneFingerPath.Text);
                            break;
                        case 2:
                            if (twoFingerPath.Text != String.Empty)
                                System.Diagnostics.Process.Start(twoFingerPath.Text);
                            break;
                        case 3:
                            if (threeFingerPath.Text != String.Empty)
                                System.Diagnostics.Process.Start(threeFingerPath.Text);
                            break;
                        case 4:
                            if (fourFingerPath.Text != String.Empty)
                                System.Diagnostics.Process.Start(fourFingerPath.Text);
                            break;
                        case 5:
                            if (fiveFingerPath.Text != String.Empty)
                                System.Diagnostics.Process.Start(fiveFingerPath.Text);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid path",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Application_Idle(object sender, EventArgs e)
        {
            
            var image = grabber.QueryFrame();
            image.ROI = Rectangle.Empty;
            Rectangle roi = new Rectangle(frameWidth/2-50, frameHeight/2-50, 100, 100); // set the roi
            image.ROI = roi;
            var livefeed = grabber.QueryFrame();
            livefeed.Draw(roi, new Bgr(Color.Lime), 2);
            imageBoxCamera.Image = livefeed;
            imageBoxSkin.Image = image;
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            debugFingers.Text = debugFingersFiltered;
            debugUnfiltFing.Text = debugFingersUnfiltered;
            
            currentFrame = grabber.QueryFrame();
            if (currentFrame != null)
            {
                currentFrameCopy = currentFrame.Copy();

                //Uncomment to use opencv adaptive skin detector/ uncomment similar lines too
                //Image<Gray, Byte> skin = new Image<Gray, byte>(currentFrameCopy.Width, currentFrameCopy.Height);
                //detector.Process(currentFrameCopy, skin);                

                skinDetector = new CustomYCrCbSkinDetector();
                //skinDetector = new HsvSkinDetector();

                Image<Gray, Byte> skin = skinDetector.DetectSkin(currentFrameCopy, YCrCb_min, YCrCb_max);
                //Image<Gray, Byte> skin = skinDetector.DetectSkin(currentFrameCopy, hsv_min, hsv_max);

                ExtractContourAndHull(skin);

                DrawAndComputeFingersNum();

                imageBoxSkin.Image = skin;
                imageBoxCamera.Image = currentFrame;
            }
        }

        private void ExtractContourAndHull(Image<Gray, byte> skin)
        {
            storage.Clear();
            {

                Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                Contour<Point> biggestContour = null;

                Double Result1 = 0;
                Double Result2 = 0;
                while (contours != null)
                {
                    Result1 = contours.Area;
                    if (Result1 > Result2)
                    {
                        Result2 = Result1;
                        biggestContour = contours;
                    }
                    contours = contours.HNext;
                }

                if (biggestContour != null)
                {
                    Contour<Point> currentContour = biggestContour.ApproxPoly(biggestContour.Perimeter * 0.0025, storage);

                    if (showContour)
                        currentFrame.Draw(currentContour, new Bgr(Color.LimeGreen), 2); 

                    biggestContour = currentContour;


                    hull = biggestContour.GetConvexHull(Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE);
                    box = biggestContour.GetMinAreaRect();
                    PointF[] points = box.GetVertices();

                    Point[] ps = new Point[points.Length];
                    for (int i = 0; i < points.Length; i++)
                        ps[i] = new Point((int)points[i].X, (int)points[i].Y);

                    if (showHull)
                    {
                        currentFrame.DrawPolyline(hull.ToArray(), true, new Bgr(200, 125, 75), 2);
                        currentFrame.Draw(new CircleF(new PointF(box.center.X, box.center.Y), 3), new Bgr(200, 125, 75), 2); 
                    }

                    

                    filteredHull = new Seq<Point>(storage);
                    for (int i = 0; i < hull.Total; i++)
                    {
                        if (Math.Sqrt(Math.Pow(hull[i].X - hull[i + 1].X, 2) + Math.Pow(hull[i].Y - hull[i + 1].Y, 2)) > box.size.Width / 10)
                        {
                            filteredHull.Push(hull[i]);
                        }
                    }

                    defects = biggestContour.GetConvexityDefacts(storage, Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE);

                    defectArray = defects.ToArray();
                }
            }
        }

        private void DrawAndComputeFingersNum()
        {
            int fingerNum = 0;

            if (defects == null)            
                fingerNum = 0;            
            else
            {
                for (int i = 0; i < defects.Total; i++)
                {
                    PointF startPoint = new PointF((float)defectArray[i].StartPoint.X,
                                                    (float)defectArray[i].StartPoint.Y);

                    PointF depthPoint = new PointF((float)defectArray[i].DepthPoint.X,
                                                    (float)defectArray[i].DepthPoint.Y);

                    PointF endPoint = new PointF((float)defectArray[i].EndPoint.X,
                                                    (float)defectArray[i].EndPoint.Y);

                    LineSegment2D startDepthLine = new LineSegment2D(defectArray[i].StartPoint, defectArray[i].DepthPoint);

                    LineSegment2D depthEndLine = new LineSegment2D(defectArray[i].DepthPoint, defectArray[i].EndPoint);

                    CircleF startCircle = new CircleF(startPoint, 5f);

                    CircleF depthCircle = new CircleF(depthPoint, 5f);

                    CircleF endCircle = new CircleF(endPoint, 5f);

                    if ((startCircle.Center.Y < box.center.Y || depthCircle.Center.Y < box.center.Y) && (startCircle.Center.Y < depthCircle.Center.Y) && (Math.Sqrt(Math.Pow(startCircle.Center.X - depthCircle.Center.X, 2) + Math.Pow(startCircle.Center.Y - depthCircle.Center.Y, 2)) > box.size.Height / 6.5))
                    {
                        fingerNum++;
                        if (showFingerTrack)
                            currentFrame.Draw(startDepthLine, new Bgr(Color.Green), 2);
                    }


                    if (showFingerTrack)
                    {
                        currentFrame.Draw(startCircle, new Bgr(Color.Red), 2);
                        currentFrame.Draw(depthCircle, new Bgr(Color.Yellow), 5); 
                    }
                }
            
            }
            debugFingersUnfiltered = "Unfiltered finger count: " + fingerNum.ToString();
            FilterFingers(fingerNum);
            //MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_PLAIN, 4d, 4d);
            //currentFrame.Draw(fingerNum.ToString(), ref font, new Point(50, 150), new Bgr(Color.White));
        }

        private void FilterFingers(int fingerNumber)
        {
            if (fingerNumber == filteredNum)
            {
                return;
            }
            else
            {
                timer.Stop();
                filteredNum = fingerNumber;
                timer.Start();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop(); //bugfix timer 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Executable files (*.exe)|*.exe";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    oneFingerPath.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    oneFingerIcon.Image = new Bitmap(Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap(), new Size(28, 28));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            if (button13.Enabled)
                timer.Start(); //bugfix
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop(); //bugfix timer 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Executable files (*.exe)|*.exe";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    twoFingerPath.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    twoFingerIcon.Image = new Bitmap(Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap(), new Size(28, 28));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            if (button13.Enabled)
                timer.Start(); //bugfix
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop(); //bugfix timer 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Executable files (*.exe)|*.exe";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    threeFingerPath.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    threeFingerIcon.Image = new Bitmap(Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap(), new Size(28, 28));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            if (button13.Enabled)
                timer.Start(); //bugfix
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer.Stop(); //bugfix timer 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Executable files (*.exe)|*.exe";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fourFingerPath.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    fourFingerIcon.Image = new Bitmap(Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap(), new Size(28, 28));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            if (button13.Enabled)
                timer.Start(); //bugfix
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer.Stop(); //bugfix timer 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Executable files (*.exe)|*.exe";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fiveFingerPath.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    fiveFingerIcon.Image = new Bitmap(Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap(), new Size (28,28));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            if (button13.Enabled)
                timer.Start(); //bugfix
        }

        private void debugContour_CheckedChanged(object sender, EventArgs e)
        {
            if (showContour)
                showContour = false;
            else
                showContour = true;
        }

        private void debugHull_CheckedChanged(object sender, EventArgs e)
        {
            if (showHull)
                showHull = false;
            else
                showHull = true;
        }

        private void debugFingerTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (showFingerTrack)
                showFingerTrack = false;
            else
                showFingerTrack = true;
        }

        private void debugAdditional_CheckedChanged(object sender, EventArgs e)
        {
            if (showAdditional)
                showAdditional = false;
            else
                showAdditional = true;
            
            additionalNfo.Visible = showAdditional;
            debugFingers.Visible = showAdditional;
            debugUnfiltFing.Visible = showAdditional;
        }

        private void button13_Click(object sender, EventArgs e) //start cap btn
        {
            button12.Enabled = true;
            button13.Enabled = false;
            Application.Idle += new EventHandler(FrameGrabber);      
        }

        private void button12_Click(object sender, EventArgs e) //stop cap btn
        {
            Application.Idle -= new EventHandler(FrameGrabber);

            timer.Stop();                    
            button12.Enabled = false;
            button13.Enabled = true;
            imageBoxCamera.Image = null;
            imageBoxSkin.Image = null;
        }


        private void saveAppConfig()
        {
            throw new NotImplementedException();
        }

        private void loadAppConfig()
        {
            throw new NotImplementedException();
        }
        
    }
}
