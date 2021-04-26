using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pong
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Project name: Pong
        /// Author: Madison Buse Lewis
        /// Date: 14th April 2021
        /// Description: It is a simple pong game in which it uses
        /// the movement of your mouse to control the movement of
        /// the goal keeper. The ball is randomly thrown towards either 
        /// the CPU or the player so they can "kick" the ball to
        /// the direction where the player (or the CPU) can score a point.
        /// The winner gets to serve the ball.
        /// Clicking on the screen of the game will pause the game.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Enabling the visual style of the pong game.
            Application.EnableVisualStyles();

            //Sets the application-wide default for the UseCompatibleTextRendering property
            // to false.
            Application.SetCompatibleTextRenderingDefault(false);

            // Running the application (Form1 has the ball and two paddle designs, the light colored
            // being the player).
            Application.Run(new Form1());
        }
    }
}