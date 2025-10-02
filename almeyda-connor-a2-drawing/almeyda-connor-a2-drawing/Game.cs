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
        // Index of Eye Positions 
        int[] xOfEye = { 50, 200, 70, 300, 350};
        int[] yOfEye = { 50, 200, 325, 300, 50 };
        float[] rOfEye = { 25, 50, 60, 50, 35};
        // Index of Colour Bases
        int[] red = { 99, 203, 161, 0, 218};
        int[] green = { 127, 137, 202, 0, 38};
        int[] blue = { 25, 103, 241, 0, 46};
        // Colour Customization
        int redOffSet = 0;
        int greenOffSet = 0;
        int blueOffSet = 0;
        
        
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Eye Follower");
            Window.ClearBackground(Random.Color());
            // Shape for Background Triangles
            for (int i = 0; i < Random.Integer(2, 9); i++)
            {
                // Triangle Side Size Randomization
                float x1 = Random.Float(0, 400);
                float x2 = Random.Float(0, 400);
                float x3 = Random.Float(0, 400);
                float y1 = Random.Float(0, 400);
                float y2 = Random.Float(0, 400);
                float y3 = Random.Float(0, 400);
                // Random Colour
                Draw.FillColor = (Random.Color());
                // Triangle Maker
                Draw.Triangle(x1, y1, x2, y2, x3, y3);
            }
            for (int i = 0; i < Random.Integer(2, 9); i++)
            {
                // Triangle Side Size Randomization
                float x1 = Random.Float(0, 400);
                float x2 = Random.Float(0, 400);
                float x3 = Random.Float(0, 400);
                float x4 = Random.Float(0, 400);
                float y1 = Random.Float(0, 400);
                float y2 = Random.Float(0, 400);
                float y3 = Random.Float(0, 400);
                float y4 = Random.Float(0, 400);
                // Random Colour
                Draw.FillColor = (Random.Color());
                // Triangle Maker
                Draw.Quad(x1, y1, x2, y2, x3, y3, x4,y4);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Draw the eyes
            for (int i = 0; i < xOfEye.Length; i++)
            {
                DrawEye(xOfEye[i], yOfEye[i], rOfEye[i]);
                Color Colored = new Color(red[i]+redOffSet, green[i]+greenOffSet, blue[i]+blueOffSet);
                Draw.FillColor = (Colored);
                DrawIris(xOfEye[i], yOfEye[i], rOfEye[i]);
            }
            // Increase red, Decrease green
            if (Input.IsKeyboardKeyPressed(KeyboardInput.R))
            {
                redOffSet+=5;
                greenOffSet -= 5;
            }
            // Increase green, Decrease blue
            if (Input.IsKeyboardKeyPressed(KeyboardInput.G))
            {
                greenOffSet += 5;
                blueOffSet -= 5;
            }
            // Increase blue, Decrease red
            if (Input.IsKeyboardKeyPressed(KeyboardInput.B))
            {
                blueOffSet += 5;
                redOffSet -= 5;
            }
            // Reset Colours
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                redOffSet = 0;
                greenOffSet = 0;
                blueOffSet = 0;
            }
        }

        void DrawEye(int x, int y, float r)
        {
            // Draws the eyeball
            Draw.FillColor = (Color.White);
            Draw.Circle(x, y, r);
            }
        void DrawIris(int x, int y, float r)
        {
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
