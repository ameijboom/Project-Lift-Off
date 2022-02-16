using System;
using GXPEngine;
using MyGame.MyGame.Levels;

namespace MyGame.MyGame;


public class MyGame : Game
{
	public const bool DEBUG_MODE = false;
	public static EasyDraw DebugCanvas;
	// ReSharper disable once InconsistentNaming
	public static Level Level;

	private MyGame() : base(1408, 768, false, false, pPixelArt: true)
	{
		targetFps = 60;

		Sprite background = new("background.png")
		{
			width = width,
			height = height,
		};
		AddChild(background);
		Level = new Level();
		AddChild(Level);

		UI.Init();

		if (DEBUG_MODE)
		{
			DebugCanvas = new EasyDraw(width, height);
			AddChild(DebugCanvas);
		}

		Console.WriteLine("MyGame initialized");
	}

	// For every game object, Update is called every frame, by the engine:
	private void Update()
	{
		// Gamepad.Update();
		UI.Update();

		if (DEBUG_MODE)
		{
			DebugCanvas.ClearTransparent();
			// Console.WriteLine(GetDiagnostics());
		}
	}

	private static void Main()
	{
		new MyGame().Start();
	}
}
