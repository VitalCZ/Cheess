using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheess.Objects
{
    public class Knight : Chessman
    {
        public Knight(string Color, int ID) : base(Color, ID)
        {
            this.WhiteTexture = ContentPipe.LoadTexture("Resources/white/knight.png");
            this.BlackTexture = ContentPipe.LoadTexture("Resources/black/knight.png");
        }
    }
}
