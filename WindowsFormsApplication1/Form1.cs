using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class Cmpimg : Form
    {
        public Cmpimg()
        {
            InitializeComponent();
        }
        
        //Function to Resize Image
        public Image ResizeImage(Image original, int targetWidth,int targetHeight)
        {
            double percent = (double)original.Width / targetWidth;
            double percent1 = (double)original.Height / targetHeight;
            int destWidth = (int)(original.Width / percent);
            int destHeight = (int)(original.Height / percent1);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            try
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.DrawImage(original, 0, 0, destWidth, destHeight);
            }
            finally
            {
                g.Dispose();
            }

            return (Image)b;
        }

        //Function called when a compare button is clicked
        private void bComp_Click(object sender, EventArgs e)
        {
           String u1, u2;
           Image image1,image2;
           int total=0,wrong=0;
           double per;
           int X=1,Y=1, h=0, w=0;
           bool flag = true;
           u1 = tUrl1.Text;
           u2 = tURL2.Text;
  
           //Function download image
           using (WebClient webclient = new WebClient())
           {
               try
               {
                   webclient.DownloadFile(u1, "image1.jpg");
                   webclient.DownloadFile(u2, "image2.jpg");
               }
               catch (Exception excep)
               {
                   MessageBox.Show("FILES CANNOT BE DOWNLODED");
                   this.Dispose();
                   return;
               }
           }

           image1 = new Bitmap("image1.jpg");
           image2 = new Bitmap("image2.jpg");
               
           if (image1.Height < image2.Height)
               h = image1.Height;
           else if (image1.Height > image2.Height)
               h = image2.Height;
           else X = 0;

           if (image1.Width < image2.Width)
               w = image1.Width;
           else if (image1.Width > image2.Width)
               w = image2.Width;
           else Y = 0;
           
           //When both image are having different height and width 
           if (X == 1 && Y == 1)
           {
              image1 = ResizeImage(image1, w, h);
              image2 = ResizeImage(image2, w,h);
           }   
           
           Bitmap k1 = new Bitmap(image1);
           Bitmap k2 = new Bitmap(image2);
           
           p1.Load("image1.jpg");
           p1.SizeMode = PictureBoxSizeMode.StretchImage;
           p2.Load("image2.jpg");
           p2.SizeMode = PictureBoxSizeMode.StretchImage;
          
           progressBar1.Maximum = k1.Width;
           for (int i = 0; i < k1.Width; i++)
           {
               for (int j = 0; j < k1.Height; j++)
               {
                   if (k1.GetPixel(i, j) != k2.GetPixel(i, j))
                   {
                       wrong++;
                       flag = false;

                   }
                   total++;
               }
               progressBar1.Value++;
           }  

           per = ((float)wrong*100/ ((float)total));
           per = 100 - per;
           
           if (flag == false)
               MessageBox.Show("Sorry, Images are not same , " + wrong + " wrong pixels found, totaL = " + total + " , " + Math.Round(per, 2) + "% PERCENT SAME");
           else
               MessageBox.Show(" Images are same , " + total + " pixels found, " + Math.Round(per, 0) + "% PERCENT SAME");
           
           //to delete the resources used
           image1.Dispose();
           image2.Dispose();
           k1.Dispose();
           k2.Dispose();
           this.Dispose();
        }
    }
}
