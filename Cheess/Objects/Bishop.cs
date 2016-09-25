using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    class Bishop : Chessman
    {
        public Bishop(string Color, int ID) : base(Color, ID)
        {
            this.WhiteTexture = ContentPipe.LoadTexture("Resources/white/bishop.png");
            this.BlackTexture = ContentPipe.LoadTexture("Resources/black/bishop.png");
        }

        
    }
}
