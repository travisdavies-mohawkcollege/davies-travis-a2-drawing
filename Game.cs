// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel.Design;
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
        int doorState = 1;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(450, 550);
            Window.SetTitle("Who's at the door?");
            Window.ClearBackground(color: Color.Blue);
            DrawFrame(0, 0);
            DrawDoorClosed(0, 0);
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                if (doorState == 0)
                {
                    Window.ClearBackground(color: Color.Blue);
                    DrawFrame(0,0);
                    DrawDoorClosed(0, 0);
                    doorState++;
                }
                else if (doorState == 1)
                {
                    Window.ClearBackground(color: Color.Blue);
                    DrawFrame(0,0);
                    DrawDoorAjar(0, 0);
                    doorState++;
                }
                else if (doorState == 2)
                {
                    Window.ClearBackground(color: Color.Blue);
                    DrawFrame(0, 0);
                    DrawDoorSwing(0, 0);
                    doorState++;
                }
                else if (doorState == 3)
                {
                    Window.ClearBackground(color: Color.Blue);
                    DrawFrame(0, 0);
                    DrawDoorOpen(0, 0);
                    doorState++;
                }
                else
                {
                    DrawFrame(0, 0);
                    DrawDoorClosed(0, 0);
                    doorState = 0;
                }
            }
            //while (doorState == 3)
            {

            }
           

        }

        public void DrawFrame(int x, int y)
        {
            Draw.LineSize = 1;
            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.White;
            Draw.Quad(1, 0, 450, 1, 300, 150, 150, 150);
            Draw.Quad(300, 150, 450, 0, 450, 550, 300, 400);
            Draw.Quad(150, 400, 300, 400, 450, 550, 0, 550);
            Draw.Quad(1, 0, 150, 150, 150, 400, 1, 550);

        }

        public void DrawDoorClosed(int x, int y)
        {
            Draw.FillColor = Color.Black;
            Draw.Quad(150, 150, 300, 150, 300, 400, 150, 400);
            Draw.Circle(275, 275, 10);
        }

        public void DrawDoorAjar(int x, int y)
        {
            Draw.FillColor = Color.Black;
            Draw.Quad(150, 150, 275, 130, 275, 430, 150, 400);
            Draw.Circle(250, 280, 10);
        }

        public void DrawDoorSwing(int x, int y)
        {
            Draw.FillColor = Color.Black;
            Draw.Quad(150, 150, 170, 100, 170, 450, 150, 400);
        }

        public void DrawDoorOpen(int x, int y)
        {
            Draw.FillColor= Color.Black;
            Draw.Quad(80, 110, 150, 150, 150, 400, 80, 450);
        }
        public void DrawKiller(int x, int y)
        {
            Draw.FillColor = Color.Black;
            Draw.Circle(225, 188, 10);
            Draw.Ellipse(225, 258, 5, 12);
        }
    }

}
