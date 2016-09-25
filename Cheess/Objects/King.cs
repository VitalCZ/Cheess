using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    class King : Chessman
    {
        public King(string Color, int ID) : base(Color, ID)
        {
            this.WhiteTexture = ContentPipe.LoadTexture("Resources/white/king.png");
            this.BlackTexture = ContentPipe.LoadTexture("Resources/black/king.png");
        }
    }
}
