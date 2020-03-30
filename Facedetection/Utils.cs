using DlibDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForgeCamera
{
    /// <summary>
    /// Class represents the utility for Face detection
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Load the given image as bitmap format
        /// </summary>
        /// <param name="imageFileFullPath">path of the image to be load</param>
        /// <returns>The bitmap format of the image</returns>
        public static Bitmap LoadImageAsBitmap(string imageFileFullPath)
        {
            try
            {
                return Bitmap.FromFile(imageFileFullPath) as Bitmap;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    string.Format("Failed to load image file {0} as bitmap format. Exception: {1}", 
                    imageFileFullPath,
                    ex.Message));
            }
        }
        /// <summary>
        /// Adjust the rectangle to make sure it is inside the range of the image
        /// </summary>
        /// <param name="rect">rectangle to be adjusted</param>
        /// <param name="img">image for reference</param>
        /// <returns></returns>
        public static DlibDotNet.Rectangle RectangleAdjust(DlibDotNet.Rectangle rect, Array2D<RgbPixel> img)
        {
            DlibDotNet.Rectangle fitRect = new DlibDotNet.Rectangle();
            fitRect.Right = rect.Right < img.Rect.Right ? rect.Right : img.Rect.Right;
            fitRect.Left = rect.Left > img.Rect.Left ? rect.Left : img.Rect.Left;
            fitRect.Top = rect.Top > img.Rect.Top ? rect.Top : img.Rect.Top;
            fitRect.Bottom = rect.Bottom < img.Rect.Bottom ? rect.Bottom : img.Rect.Bottom;
            return fitRect;
        }
    }
}
