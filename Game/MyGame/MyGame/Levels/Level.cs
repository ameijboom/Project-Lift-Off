﻿using System.Collections;
using System.Collections.Generic;
using GXPEngine;
using TiledMapParser;

namespace MyGame.MyGame.Levels;

public class Level : GameObject
{
    private readonly TiledLoader _tiledLoader;
    public Level(string path)
    {
        _tiledLoader = new TiledLoader($"../../{path}");
        // CreateLevel();
    }

    public void CreateLevel()
    {
        _tiledLoader.autoInstance = true;
        
        _tiledLoader.LoadImageLayers();
        _tiledLoader.LoadTileLayers();
        _tiledLoader.LoadObjectGroups();
    }
}