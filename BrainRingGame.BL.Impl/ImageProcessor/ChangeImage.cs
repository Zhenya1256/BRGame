using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.BL.Impl.ImageProcessor
{
   public class ChangeImage
    {
        public MemoryStream ChangeSize
            (MemoryStream streamImage,int width,int height)
        {
            MemoryStream outImageStream = new MemoryStream();

            Image source = Image.FromStream(streamImage);
            Bitmap bmp = new Bitmap(width, height);
            Graphics graphicsImage = Graphics.FromImage(bmp);

            graphicsImage.DrawImage(source, 0, 0, width, height);

            bmp.Save(outImageStream, ImageFormat.Png);

            return outImageStream;
        }

    }
}
