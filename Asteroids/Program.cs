using AsteroidSharp.Models;
using Raylib_CSharp;
using Raylib_CSharp.Windowing;

Time.SetTargetFPS(60);

(int, int) windowDimensions = (800, 480);

Window.Init(windowDimensions.Item1, windowDimensions.Item2, "Asteroids");

var game = new Game(windowDimensions);

while (!Window.ShouldClose())
{
    game.UpdateGame();
    game.DrawGame();
}
Window.Close();
