using System;
using System.Collections.Generic;
using System.Text;

namespace AtenaImageCore
{
    public class FilterBox3x3 : IPluginFilter
    {
        public void Run(ImageProcessor ip)
        {
            int M = ip.Width;
            int N = ip.Height;
            var copy = ip.Duplicate();

            for (int u = 1; u <= M - 1; u++)
            {
                for (int v = 1; v <= N - 2; v++)
                {
                    int sum = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int p = copy.GetPixel(u + 1, v + j);
                            sum += p;
                        }
                    }
                    int q = (int)(sum / 9.0);
                    ip.PutPixel(u, v, q);
                }
            }
        }
    }
}
