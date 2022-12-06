using MathNet.Numerics.LinearAlgebra.Single;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb_separation
{
    internal class ImageGenerator
    {
        public int V { get; set; }
        public int Quantifier { get; set; }

        public ImageGenerator(int v, int quantifier)
        {
            V = v;
            Quantifier = quantifier;
        }

        public Bitmap GenerateImage(int size, int padding)
        {
            int distanceBetweenStripes = Quantifier < 7 ? 0 : Quantifier < 40? 1: 2;
            int paddingForStripes = distanceBetweenStripes * (size - 2 * padding - 1) / Quantifier;
            Bitmap bitmap = new Bitmap(size + paddingForStripes, size);
            float hMax = 360;
            float sMax = 100;

            for (int i=0; i< size - 2*padding; i++)
            {
                for (int j = 0; j < size - 2 * padding; j++)
                {
                    int stripe = (int)((float) i / Quantifier);
                    stripe *= Quantifier;
                    float h = j * hMax / size;
                    float s = stripe * sMax / size;
                    float c = V / 100f * s / 100f;
                    float x = c * (1 - Math.Abs(((h / 60f) % 2) - 1));
                    Vector rgb = getRGB(c, x, h);
                    bitmap.SetPixel(padding + i + distanceBetweenStripes * (i/Quantifier), padding + j, Color.FromArgb((int)rgb[0], (int)rgb[1], (int)rgb[2]));
                }
            }
            return bitmap;
        }

        private Vector getRGB(float c, float x, float h)
        {
            Vector v;
            if(h >= 0 && h < 60)
                v = DenseVector.OfArray(new[] { c, x, 0f });
            else if (h >= 60 && h < 120)
                v = DenseVector.OfArray(new[] { x, c, 0f });
            else if (h >= 120 && h < 180)
                v = DenseVector.OfArray(new[] { 0f, c, x });
            else if (h >= 180 && h < 240)
                v = DenseVector.OfArray(new[] { 0f, x, c });
            else if (h >= 240 && h < 300)
                v = DenseVector.OfArray(new[] { x, 0f, c });
            else
                v = DenseVector.OfArray(new[] { c, 0f, x });

            float m = (V / 100f) - c;
            return DenseVector.OfArray(new[] { (v[0]+m)*255, (v[1] + m) * 255, (v[2] + m) * 255 });
        }
    }
}
