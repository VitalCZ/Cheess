using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheess
{
    public partial class PawnLevelUp : Form
    {
        public string tile = "pawn";
        public PawnLevelUp()
        {
            InitializeComponent();
        }

        private void ChangeToBishop_Click(object sender, EventArgs e)
        {
            this.tile = "bishop";
            this.Close();
        }

        private void ChangeToKnight_Click(object sender, EventArgs e)
        {
            this.tile = "knight";
            Close();
        }

        private void ChangeToQueen_Click(object sender, EventArgs e)
        {
            this.tile = "queen";
            Close();
        }

        private void ChangeToRook_Click(object sender, EventArgs e)
        {
            this.tile = "rook";
            Close();
        }
    }
}
