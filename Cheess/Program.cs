using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Cheess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Initialize game
            GameWindow window = new GameWindow(800, 800, new OpenTK.Graphics.GraphicsMode(32, 24, 0, 8));
            GraphicsEngine GraphicsEngine = new GraphicsEngine(window);

            window.Icon = Properties.Resources.Icon;
            window.Title = "Cheess";
            window.WindowBorder = WindowBorder.Fixed;

            window.Run(1.0 / 60.0);

            
        }
    }
}
