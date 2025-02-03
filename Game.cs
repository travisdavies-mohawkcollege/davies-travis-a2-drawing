// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Variables
        int doorState = 1;
        Color offBlack = new Color("130310");
        Color darkPurple = new Color("1d0518");
        Color lightPurple = new Color("270721");
        Color magenta = new Color("520b20");
        Color darkestRed = new Color("520b20");
        Color darkerRed = new Color("7d0f1f");
        Color strawberry = new Color("a8141d");
        Color red = new Color("d3181c");
        Color lightRed = new Color("ff252b");
        int arrayRandomizer = 0;
        bool isSetup = false;      
        Vector2[] textPositions =
        {
            new Vector2(200, 75),
            new Vector2(95, 300),
            new Vector2(250, 450),
            new Vector2(350, 250)

        };
        
       

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(450, 550);
            Window.SetTitle("Who's at the door?");
            Window.ClearBackground(color: offBlack);
 
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //  Run setup to draw intial image.
            if (isSetup == false)
            {
                DrawFrame(0, 0);
                DrawDoorClosed(0, 0);
                isSetup = true;
            }
            // When the player presses space, the new image is drawn and doorState is increased.
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                if (doorState == 0)
                {
                    Window.ClearBackground(color: offBlack);
                    DrawFrame(0, 0);
                    DrawDoorClosed(0, 0);
                    doorState++;
                }
                else if (doorState == 1)
                {
                    Window.ClearBackground(color: offBlack);
                    DrawFrame(0, 0);
                    DrawDoorAjar(0, 0);
                    doorState++;
                }
                else if (doorState == 2)
                {
                    Window.ClearBackground(color: offBlack);
                    DrawFrame(0, 0);
                    DrawDoorSwing(0, 0);
                    doorState++;
                }
                else if (doorState == 3)
                {
                    Window.ClearBackground(color: offBlack);
                    DrawFrame(0, 0);
                    DrawDoorOpen(0, 0);
                    doorState++;
                }
                else if (doorState == 4)
                {
                    DrawFrame(0, 0);
                    DrawKiller(0, 0);
                    DrawDoorOpen(0, 0);
                    //  Draws text on the screen for each predetermined spot. 
                    for (int textPos = 0; textPos < 4; textPos++) ;
                    {
                        Text.Color = strawberry;
                        Text.Size = 25;
                        Text.Draw("RUN", textPositions[arrayRandomizer]);
                        arrayRandomizer++;
                        if (arrayRandomizer >= 4)
                        {
                            doorState++;
                            arrayRandomizer = 0;
                        }

                    }
                }
                //  Reset the doorState to start the program over.
                else
                {
                    DrawFrame(0, 0);
                    DrawDoorClosed(0, 0);
                    doorState = 0;
                }
            }
        }

           
           

        

        public void DrawFrame(int x, int y)
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.White;
            Draw.FillColor = darkPurple;
            Draw.Quad(1, 0, 450, 1, 300, 150, 150, 150);
            Draw.FillColor = darkPurple;
            Draw.Quad(300, 150, 450, 0, 450, 550, 300, 400);
            Draw.FillColor = lightPurple;
            Draw.Quad(150, 400, 300, 400, 450, 550, 0, 550);
            Draw.FillColor = darkPurple;
            Draw.Quad(1, 0, 150, 150, 150, 400, 1, 550);

        }

        public void DrawDoorClosed(int x, int y)
        {
            Draw.LineColor = Color.White;
            Draw.LineSize = 1;
            Draw.FillColor = lightPurple;
            Draw.Quad(150, 150, 300, 150, 300, 400, 150, 400);
            Draw.FillColor = darkPurple;
            Draw.Circle(275, 275, 10);
        }

        public void DrawDoorAjar(int x, int y)
        {
            Draw.FillColor = lightPurple;
            Draw.Quad(150, 150, 275, 130, 275, 430, 150, 400);
            Draw.FillColor = darkPurple;
            Draw.Circle(250, 280, 10);
        }

        public void DrawDoorSwing(int x, int y)
        {
            Draw.FillColor = lightPurple;
            Draw.Quad(150, 150, 170, 100, 170, 450, 150, 400);
        }

        public void DrawDoorOpen(int x, int y)
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.White;
            Draw.FillColor= lightPurple;
            Draw.Quad(80, 110, 150, 150, 150, 400, 80, 450);
        }
        public void DrawKiller(int x, int y)
        {
            Draw.FillColor = darkestRed;
            //arms
            Draw.LineSize = 3;
            Draw.LineColor = darkerRed;
            Draw.Line(200, 230, 175, 300);
            Draw.Line(250, 230, 275, 300);
            //legs
            Draw.Line(210, 320, 200, 400);
            Draw.Line(240, 320, 250, 400);

            //body
            Draw.Ellipse(225, 275, 50, 120);           
            //shoulders
            Draw.Circle(250, 230, 15);
            Draw.Circle(200, 230, 15);
            //head
            Draw.Circle(225, 188, 30);
           
        }
       
    }

}
