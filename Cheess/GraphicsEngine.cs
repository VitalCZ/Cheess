using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using Cheess.Objects;

namespace Cheess
{
    class GraphicsEngine
    {
        #region Add references and stuff
        GameWindow window;
        GameEngine GameEngine = new GameEngine();
        InputHandler InputHandler = new InputHandler();

        Texture2D ActiveTile;

        private int X, Y;
        #endregion

        #region Handle Input
        //Manages controlling the chess tiles
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            X = InputHandler.GetX(e.X, window.Width);
            Y = InputHandler.GetY(e.Y, window.Height);

            GameEngine.CheckIfMoveable(X, Y);
            if (GameEngine.Shutdown == true)
                window.Close();
        }
        #endregion

        #region Configuration of MAGIC
        public GraphicsEngine(GameWindow window)
        {
            this.window = window;

            window.Load += Window_Load;
            window.UpdateFrame += Window_UpdateFrame;
            window.RenderFrame += Window_RenderFrame;
            window.Resize += Window_Resize;

            window.MouseDown += Window_MouseDown;
        }

        //Sets up GameWindow
        private void Window_Load(object sender, EventArgs e)
        {
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);
            GL.Enable(EnableCap.AlphaTest);
            GL.AlphaFunc(AlphaFunction.Gequal, 0.1f);

            ActiveTile = ContentPipe.LoadTexture("Resources/activetile.png");
        }
        
        //Fixes image when someone resizes window (shouldn't happen, but still good to have)
        private void Window_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
        }

        //Manages to render image, the true magic happens here
        private void Window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.ClearColor(Color.SaddleBrown);
            GL.ClearDepth(1);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 projMatrix = Matrix4.CreateOrthographicOffCenter(0, window.Width, window.Height, 0, 0, 1);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projMatrix);

            this.DrawBoard();
            this.MarkActive(X, Y);
            this.RenderFigures();

            window.SwapBuffers();
        }

        // Nothing yet
        private void Window_UpdateFrame(object sender, FrameEventArgs e)
        {

        }
        #endregion

        #region Drawing
        //Shows Active Tile
        private void MarkActive(int x, int y)
        {
            if (GameEngine.Clicked == true)
            {
                GL.BindTexture(TextureTarget.Texture2D, this.ActiveTile.ID);
                GL.Enable(EnableCap.Texture2D);

                GL.Begin(PrimitiveType.Quads);
                GL.Color3(Color.GhostWhite);

                GL.TexCoord2(0, 0); GL.Vertex2(window.Width / 8 * x, window.Height / 8 * y);
                GL.TexCoord2(1, 0); GL.Vertex2(window.Width / 8 * (x + 1), window.Height / 8 * y);
                GL.TexCoord2(1, 1); GL.Vertex2(window.Width / 8 * (x + 1), window.Height / 8 * (y + 1));
                GL.TexCoord2(0, 1); GL.Vertex2(window.Width / 8 * x, window.Height / 8 * (y + 1));

                GL.End();
            }
        }

        //Renders Chess figures
        private void RenderFigures()
        {
            GL.Enable(EnableCap.Texture2D);

            for (int a = 1; a <= 8; a++)
            {
                for (int b = 1; b <= 8; b++)
                {
                    if (GameEngine.Board[a - 1, b - 1] != null)
                    {
                        GameEngine.Board[a - 1, b - 1].PrepareGraphic();
                        GL.Begin(PrimitiveType.Quads);
                        GL.Color3(Color.White);
                 
                        GL.TexCoord2(0, 0); GL.Vertex2(window.Width/8 * (b - 1), window.Height/8 * (a - 1));
                        GL.TexCoord2(1, 0); GL.Vertex2(window.Width/8 * b, window.Height/8 * (a - 1));
                        GL.TexCoord2(1, 1); GL.Vertex2(window.Width/8 * b, window.Height/8 * a);
                        GL.TexCoord2(0, 1); GL.Vertex2(window.Width/8 * (b - 1), window.Height/8 * a);

                        GL.End();
                    }
                }
            }
        }

        //Draws the board on screen
        private void DrawBoard()
        {
            GL.Disable(EnableCap.Texture2D);

            GL.Begin(PrimitiveType.Quads);
            for (int a = 1; a <= 8; a++)
            {
                for (int b = 1; b <= 8; b++)
                {
                    if (b % 2 == a % 2) { GL.Color3(Color.Wheat); }
                    else { GL.Color3(Color.SaddleBrown); }
                    GL.Vertex2(window.Width/8 * (b - 1), window.Height/8 * (a - 1));
                    GL.Vertex2(window.Width/8 * (b - 1), window.Height/8 * a);
                    GL.Vertex2(window.Width/8 * b, window.Height/8 * a);
                    GL.Vertex2(window.Width/8 * b, window.Height/8 * (a - 1));
                }
            }
            GL.End();
        }
        #endregion
    }
}
