using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    public abstract class Chessman
    {
        public string Color;
        public int ID;
        public bool Moved;
        protected Texture2D WhiteTexture;
        protected Texture2D BlackTexture;

        public Chessman(string Color, int ID)
        {
            this.Color = Color;
            this.ID = ID;
        }

        public void PrepareGraphic()
        {
            if (this.Color == "white")
                GL.BindTexture(TextureTarget.Texture2D, this.WhiteTexture.ID);
            else
                GL.BindTexture(TextureTarget.Texture2D, this.BlackTexture.ID);
        }

        public bool IsPossible(int newX, int newY, int oldX, int oldY, string Chessman)
        {
            if(Chessman == "pawn")
            {
                return true;
            }
            return false;
        }
    }
}
