using System;
using System.Collections.Generic;
using System.Text;

namespace AtenaImageCore
{
    public class ImageProcessor
    {
        public int Width { get; set; }
        public int Height { get; set }

        internal ImageProcessor Duplicate()
        {
            throw new NotImplementedException();
        }

        public void AddPixel(int u, int v, int p)
        {

        }

        public int GetPixel(int u, int v)
        {

        }

        /// <summary>
        /// I(u,v)<-abs{I(u,v)}
        /// </summary>
        public void Abs()
        {
        }

        /// <summary>
        /// I(u,v)<-I(u,v) + p
        /// </summary>
        public void Add(int p)
        {

        }

        /// <summary>
        /// I(u,v)<-({I(u,v)/255}^g)*p
        /// </summary>
        public void Gamma(double g)
        {

        }

        /// <summary>
        /// I(u,v)<-255-I(u,v)
        /// </summary>
        public void Invert(int p)
        {

        }

        /// <summary>
        /// I(u,v)<-log10{I(u,v)}
        /// </summary>
        public void Log()
        {

        }

        /// <summary>
        /// I(u,v)<-max{I(u,v),s}
        /// </summary>
        public void Max(double s)
        {

        }

        /// <summary>
        /// I(u,v)<-min{I(u,v),s}
        /// </summary>
        public void Min(double s)
        {

        }

        /// <summary>
        /// I(u,v)<-round{I(u,v)*s}
        /// </summary>
        public void Multiply(double s)
        {

        }

        /// <summary>
        /// I(u,v)<-I(u,v)^2
        /// </summary>
        public void Sqr()
        {

        }

        /// <summary>
        /// I(u,v)<-sqrt{I(u,v)}
        /// </summary>
        public void Sqrt()
        {
        }

        /// <summary>
        /// I1(u,v)<-I1(u,v)+I2(u,v)
        /// </summary>
        public void Add(ImageProcessor ip)
        {
            CopyBits(ip, 0, 0, Blitter.Add);
        }

        /// <summary>
        /// I1(u,v)<-(I1(u,v)+I2(u,v))/2
        /// </summary>
        public void Average(ImageProcessor ip)
        {
            CopyBits(ip, 0, 0, Blitter.Average);

            //TODO: add copy, difference, divide, max, min, mulitply, subtract
        }

        /// <summary>
        /// Applies the binary operation specified by the <paramref name="mode"/> to all
        /// pixel pairs taken from the source image <paramref name="ip"/> and the target image
        /// (the image on which this method is invoked) and stores the result in the targtet
        /// image. <paramref name="u"/> and <paramref name="v"/> are the coordinates where the source
        /// image is inserted into the target image (usually they are 0).
        /// </summary>
        public void CopyBits(ImageProcessor ip, int u, int v, Blitter mode)
        {

        }
    }
}
