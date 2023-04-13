using System;
using System.Drawing.Imaging;
using System.Drawing;

namespace HighlightСolor
{
    public class DominationColor
    {
        public Color GetColor(Bitmap bitmap)
        {
            return DominantColor(bitmap);
        }

        private Color DominantColor(Bitmap bmp)
        {
            BitmapData srcData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            int stride = srcData.Stride;
            IntPtr Scan0 = srcData.Scan0;
            int[] totals = new int[] { 0, 0, 0 };
            int[] returnColors = new int[] { 0, 0, 0 };
            int width = bmp.Width;
            int height = bmp.Height;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int color = 0; color < 3; color++)
                        {
                            int idx = (y * stride) + x * 4 + color;
                            totals[color] += p[idx];
                        }
                    }
                }
            }
            returnColors[2] = totals[0] / (width * height);
            returnColors[1] = totals[1] / (width * height);
            returnColors[0] = totals[2] / (width * height);
            bmp.UnlockBits(srcData);
            return InvertColor(Color.FromArgb(returnColors[0], returnColors[1], returnColors[2]));
        }

        private Color InvertColor(Color c)
        {
            return Color.FromArgb(c.A, 0xFF - c.R, 0xFF - c.G, 0xFF - c.B);
        }
    }
}
