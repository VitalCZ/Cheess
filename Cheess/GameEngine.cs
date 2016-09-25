using Cheess.Objects;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cheess
{
    class GameEngine
    {
        #region Game setup
        //Setup things
        public static Bishop Bishop;
        public static Knight Knight;
        public static Pawn Pawn;
        public static Queen Queen;
        public static King King;
        public static Rook Rook;
        Random r = new Random();
        public static string color1 { get; private set; } = "black";
        public static string color2 { get; private set; } = "white";
        public static Chessman temp;
        public static string thisturn = color2;
        public static bool Clicked, Shutdown;
        private static int oldX, oldY;

        public GameEngine()
        {
            this.LoadBoard();
        }
        #endregion

        #region Create game board
        //Don't know what this does, but it fixes a warning
        public Chessman[,] Board { get { return board; } set { board = value; } }
        //Creates a board
        private Chessman[,] board;

        //Loads objects into board
        private void LoadBoard()
        {
            this.board = new Chessman[8, 8]
            {
                {Rook=new Rook(color1,1),Knight=new Knight(color1,2),Bishop=new Bishop(color1, 3),Queen=new Queen(color1,4),King=new King(color1,5),Bishop=new Bishop(color1,6),Knight=new Knight(color1,7),Rook=new Rook(color1,8)},
                {Pawn=new Pawn(color1,9),Pawn=new Pawn(color1,10),Pawn=new Pawn(color1,11),Pawn=new Pawn(color1,12),Pawn=new Pawn(color1,13),Pawn=new Pawn(color1,14),Pawn=new Pawn(color1,15),Pawn=new Pawn(color1,16)},
                {null,null,null,null,null,null,null,null,},
                {null,null,null,null,null,null,null,null,},
                {null,null,null,null,null,null,null,null,},
                {null,null,null,null,null,null,null,null,},
                {Pawn=new Pawn(color2,17),Pawn=new Pawn(color2,18),Pawn=new Pawn(color2,19),Pawn=new Pawn(color2,20),Pawn=new Pawn(color2,21),Pawn=new Pawn(color2,22),Pawn=new Pawn(color2,23),Pawn=new Pawn(color2,24)},
                {Rook=new Rook(color2,25),Knight=new Knight(color2,26),Bishop=new Bishop(color2, 27),Queen=new Queen(color2,28),King=new King(color2,29),Bishop=new Bishop(color2,30),Knight=new Knight(color2,31),Rook=new Rook(color2,32)},
            };
        }
        #endregion

        #region Move tiles and check for various stuff
        public bool IsMoveLegal(int X, int Y, int oldY, int oldX)
        {
            //There will be checking for rules
            /*if (Board[oldX, oldY] is Pawn)
            {
                if (board[oldX, oldY].Moved == false)
                {
                    if (oldY == Y)
                        return true;
                }
            }
            return false;*/
            return true; //Temporary, until rules are solved
        }

        public void CheckIfGameEnds(int newX, int newY)
        {
            if (board[newY, newX] is King)
            {
                DialogResult GetAnswer = MessageBox.Show(char.ToUpper(thisturn[0]) + thisturn.Substring(1) + " won!\nCongratulations! :D", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (GetAnswer == DialogResult.OK)
                {
                    board[newY, newX] = temp;
                    board[oldY, oldX] = null;
                    Shutdown = true;
                }
            }
        }

        public void CheckIfMoveable(int X, int Y)
        {
            if (board[Y, X] != null && Clicked == false && board[Y, X].Color == thisturn)
            {
                Clicked = true;
                temp = board[Y, X];
                oldX = X;
                oldY = Y;
            }
            else if (Clicked == true)
            {
                if (Board[Y, X] == null || Board[Y, X].Color != Board[oldY, oldX].Color)
                {
                    Clicked = false;
                    if (IsMoveLegal(X, Y, oldX, oldY) == true)
                        MoveChessPiece(X, Y, oldX, oldY);
                }
            }
        }

        public void PromotePawn(int newX, int newY, int oldX, int oldY)
        {
            if (newY == 0 || newY == 7)
            {
                PawnLevelUp frm = new PawnLevelUp();
                frm.ShowDialog();

                if (frm.tile == "pawn")
                    board[newY, newX] = temp;
                else if (frm.tile == "bishop")
                    board[newY, newX] = new Bishop(thisturn, board[oldY, oldX].ID);
                else if (frm.tile == "knight")
                    board[newY, newX] = new Knight(thisturn, board[oldY, oldX].ID);
                else if (frm.tile == "queen")
                    board[newY, newX] = new Queen(thisturn, board[oldY, oldX].ID);
                else if (frm.tile == "rook")
                    board[newY, newX] = new Rook(thisturn, board[oldY, oldX].ID);
                board[oldY, oldX] = null;
            }
        }

        public void MoveChessPiece(int newX, int newY, int oldX, int oldY)
        {
            CheckIfGameEnds(newX, newY);
            if (board[oldY, oldX] is Pawn && newY == 0 || newY == 7 && board[oldY, oldX] is Pawn)
                PromotePawn(newX, newY, oldX, oldY);
            else
            {
                board[newY, newX] = temp;
                board[oldY, oldX] = null;
            }
            Clicked = false;
            
            this.ToggleTurnColor();
        }

        public void ToggleTurnColor()
        {
            if (thisturn == color1)
                thisturn = color2;
            else
                thisturn = color1;
        }
        #endregion
    }
}
