using System;
using Raylib_cs;

namespace Grafik
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Grafikdemo");

      Color hotPink = new Color(255, 105, 180, 255);

      float x = 30;

      while (!Raylib.WindowShouldClose())
      {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
          x += 0.05f;
        }



        Raylib.BeginDrawing();

        Raylib.ClearBackground(hotPink);

        Raylib.DrawRectangle((int) x, 10, 20, 20, Color.BLACK);

        Raylib.EndDrawing();

      }


    }
  }
}
