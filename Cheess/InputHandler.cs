using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;

namespace Cheess
{
    class InputHandler
    {
        public static int GetX(int X, int width)
        {
            for (int i = 0; i < 8; i++)
            {
                if (X >= i * width / 8 && X < (i + 1) * width / 8)
                    return i;
            }
            return 7;
        }

        public static int GetY(int Y, int height)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Y >= j * height / 8 && Y < (j + 1) * height / 8)
                    return j;
            }
            return 7;
        }
    }
}
