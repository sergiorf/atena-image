using System;
using System.Collections.Generic;
using System.Text;

namespace AtenaImageCore
{
    public class FilterMedian : IPluginFilter
    {
        public const int r = 4; // specifies the size of the filter

        public void Run(ImageProcessor ip)
        {
            int M = ip.Width;
            int N = ip.Height;
            var copy = ip.Duplicate();

            // Vector to hold the pixels from (2r+1)x(2r+1) neighborhood
            int[] A = new int[(2*r+1)*(2*r+1)];

            // Index of center vector element
            int n = 2 * (r * r + r);

            for (int u = r; u <= M -r -2; u++)
            {
                for (int v = r; v <= M - r - 2; v++)
                {
                    // Fill the pixel vector A for filter position (u,v)
                    int k = 0;
                    for (int i = -r; i <= r; i++)
                    {
                        for (int j = -r; j <= r; j++)
                        {
                            A[k] = copy.GetPixel(u + i, v + j);
                            k++;
                        }
                    }
                    // Sort vector A and take the center element A[n]
                    Arrays.Sort(A);
                    ip.PutPixel(u, v, A[n]);
                }
            }

        }
    }
}
