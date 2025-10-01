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
        // Random Colors
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
            DrawEye(50, 50, 25,225,50,69);
            DrawEye(200, 200, 50,35,67,88);
            DrawEye(70, 325, 75,125,60,80);
            DrawEye(300, 300, 50,0,0,0);
        }

        void DrawEye(int x, int y, float r, int red, int blue, int green)
        {
            // Draws the eyeball
            Draw.FillColor = (Color.White);
            Draw.Circle(x, y, r);
            Color Colored = new Color(red, green, blue);
            Draw.FillColor = (Colored);
            if (Input.GetMouseX() > x + x / r)
                {
                    if (Input.GetMouseY() > y + y / r)
                    {
                        Draw.Circle(x + x / r, y + y / r, r / 2);
                    }
                    else if (Input.GetMouseY() < y - y / r)
                    {
                        Draw.Circle(x + x / r, y - y / r, r / 2);
                    }
                    else
                    {
                        Draw.Circle(x + x / r, y, r / 2);
                    }
                }
                else if (Input.GetMouseX() < x - x / r)
                {
                    if (Input.GetMouseY() > y + y / r)
                    {
                        Draw.Circle(x - x / r, y + y / r, r / 2);
                    }
                    else if (Input.GetMouseY() < y - y / r)
                    {
                        Draw.Circle(x - x / r, y - y / r, r / 2);
                    }
                    else
                    {
                        Draw.Circle(x - x / r, y, r / 2);
                    }
                }
                else if (Input.GetMouseY() > y + y / r)
                {
                    if (Input.GetMouseY() > x + x / r)
                    {
                        Draw.Circle(x + x / r, y + y / r, r / 2);
                    }
                    else if (Input.GetMouseY() < x - x / r)
                    {
                        Draw.Circle(x - x / r, y + y / r, r / 2);
                    }
                    else
                    {
                        Draw.Circle(x - x / r, y + y / r, r / 2);
                    }
                }
                else if (Input.GetMouseY() < y - y / r)
                {
                    if (Input.GetMouseY() > x + x / r)
                    {
                        Draw.Circle(x + x / r, y - y / r, r / 2);
                    }
                    else if (Input.GetMouseY() < x - x / r)
                    {
                        Draw.Circle(x - x / r, y - y / r, r / 2);
                    }
                    else
                    {
                        Draw.Circle(x - x / r, y - y / r, r / 2);
                    }
                }
                else
                {
                    Draw.Circle(x, y, r / 1.5f);
                }
            }
        

        
        
    }

}
