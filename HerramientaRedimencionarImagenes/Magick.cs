using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerramientaRedimencionarImagenes
{
    public class Magick
    {
        public  void MinimizaImagen(string path)
        {
            string path2 = @"C:\Users\AMILCAR\source\repos\Delegados\HerramientaRedimencionarImagenes\img\a_mini.jpg";
            using (MagickImage oMagickImage = new MagickImage(path))
            {
                oMagickImage.Resize(300, 0);
                oMagickImage.Write(path2);
            }
        }
    }
}
