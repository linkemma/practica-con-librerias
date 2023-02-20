using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace OCRTesseract
{
    public class OCR
    {
        
        public string Constructor12(string pathImage)
        {
            string text = "";
            try
            {
                using(var engie = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    using(var img = Pix.LoadFromFile(pathImage))
                    {
                        using( var page = engie.Process(img))
                        {
                            text = page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
            return text;
        }
    }
}
