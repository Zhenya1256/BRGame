using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BrainRingGame.BL.Impl.ImageProcessor
{
    public class AddImageControl
    {
        
        public BitmapImage AddControlImage(MemoryStream stream)
        {
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.CacheOption = BitmapCacheOption.OnLoad;
            imageSource.StreamSource = stream;
            imageSource.EndInit();

            return imageSource;
        }



    }
}
