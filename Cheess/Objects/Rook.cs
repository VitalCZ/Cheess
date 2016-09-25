using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    class Rook : Chessman
    {
        public Rook(string Color, int ID) : base(Color, ID)
        {
            this.WhiteTexture = ContentPipe.LoadTexture("Resources/white/rook.png");
            this.BlackTexture = ContentPipe.LoadTexture("Resources/black/rook.png");
        }
    }
}
