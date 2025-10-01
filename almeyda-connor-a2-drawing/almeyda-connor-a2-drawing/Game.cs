// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color Colored = Random.Color();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Eye Follower");
            Window.ClearBackground(Color.OffWhite);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            DrawEye(50, 50, 25);
        }
        
        void DrawEye(int x,int y,float r)
        {
            // Draws the eyeball
            Draw.FillColor=(Color.White);
            Draw.Circle(x, y, r);
            Draw.FillColor = Colored;
            if (Input.GetMouseX()>x+x/10)
            {
                if (Input.GetMouseY() > y+10)
                {
                    Draw.Circle(x + x / 10, y+y/10, r / 2);
                }
                else if (Input.GetMouseY() < y - 10)
                {
                    Draw.Circle(x + x / 10, y - y / 10, r / 2);
                }
                else
                {
                    Draw.Circle(x + x / 10, y, r / 2);
                }
            }
            else if (Input.GetMouseX() < x-x/10)
            {
                if (Input.GetMouseY() > y + y/10)
                {
                    Draw.Circle(x-x/10, y + y / 10, r / 2);
                }
                else if (Input.GetMouseY() < y - y/10)
                {
                    Draw.Circle(x-x/10, y - y / 10, r / 2);
                }
                else
                {
                    Draw.Circle(x-x/10, y, r / 2);
                }
            }
            else if (Input.GetMouseY() > y + y/10)
            {
                if (Input.GetMouseY() > x + x/10)
                {
                    Draw.Circle(x + x / 10, y + y / 10, r / 2);
                }
                else if (Input.GetMouseY() < x - x/10)
                {
                    Draw.Circle(x - x / 10, y + y / 10, r / 2);
                }
                else
                {
                    Draw.Circle(x - x/10, y + y / 10, r / 2);
                }
            }
            else if (Input.GetMouseY() < y-y/10)
            {
                if (Input.GetMouseY() > x + x/10)
                {
                    Draw.Circle(x + x / 10, y-y/10, r / 2);
                }
                else if (Input.GetMouseY() < x - x/10)
                {
                    Draw.Circle(x - x / 10, y - y / 10, r / 2);
                }
                else
                {
                    Draw.Circle(x - x/10, y - y / 10, r / 2);
                }
            }
            else
            {
                Draw.Circle(x, y, r/1.5f);
            }
        }

        
        
    }

}
