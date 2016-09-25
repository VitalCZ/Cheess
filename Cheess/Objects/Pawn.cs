using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    class Pawn : Chessman
    {
        public Pawn(string Color, int ID) : base(Color, ID)
        {
            this.WhiteTexture = ContentPipe.LoadTexture("Resources/white/pawn.png");
            this.BlackTexture = ContentPipe.LoadTexture("Resources/black/pawn.png");
        }
        
        public bool IsPossible(int newX, int newY, int oldX, int oldY)
        {

            return true;
        }
    }
}
