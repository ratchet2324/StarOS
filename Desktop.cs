using System;
using Cosmos.System.Graphics;

namespace StarOS
{
    public class Desktop
    {
        internal static void startGUI ()
        {
            Canvas canvas;
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(Color.FromArgb(200,54,82));
        }
    }
}