using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    class Queen : Chessman
    {
        public Queen(string Color, int ID) : base(Color, ID)
        {
            this.WhiteTexture = ContentPipe.LoadTexture("Resources/white/queen.png");
            this.BlackTexture = ContentPipe.LoadTexture("Resources/black/queen.png");
        }
    }
}
