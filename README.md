# Tile Editor Project for University (Non-functioning)
A tile editor system that is written in C# with MonoGame Framework. It has two major errors of which no solution has been found. 

## Prerequisites
Before you can run this program, ensure that the following software is installed and functional:
* One of the following operating systems: Windows 7, 8, 8.1, or 10.
* Visual Studio 2019, or newer, and C#.
* Monogame Pipeline and Framework

## Running
1. Download the source code from this repository.
2. Install the latest version of MonoGame and ensure that the correct files for C# have been downloaded.
3. Make sure that the tilesets are loaded into the MonoGame Content Manager and build the program.
4. (NOTE) Many functions either don't work or work partially. Continue at your own risk. These are going to be listed below with pictures.

## ERRORS
![Error1](https://github.com/b-Sprague/UniTileEditor/blob/main/Error%20Pics/error1.PNG?raw=true)
![Error2](https://github.com/b-Sprague/UniTileEditor/blob/main/Error%20Pics/error2.PNG?raw=true)
![Error3](https://github.com/b-Sprague/UniTileEditor/blob/main/Error%20Pics/error3.PNG?raw=true)

## File Summaries
Below is the list of each program file and a brief explanation of its role:

MGRpgLibrary/GameState
* [__GameState.cs__](MGRpgLibrary/GameState.cs) Sets the game state.
* [__GameStateManager.cs__](MGRpgLibrary/GameStateManager.cs) Controls the game states.

MGRpgLibrary
* [__InputHandler.cs__](MGRpgLibrary/InputHandler.cs) Handles inputs from keyboard and mouse.

MGRpgLibrary/Controls
* [__Control.cs__](MGRpgLibrary/Controls/Control.cs) Handles control input.
* [__ControlManager.cs__](MGRpgLibrary/Controls/ControlManager.cs) Manages the control inputs.
* [__Label.cs__](MGRpgLibrary/Controls/Label.cs) Sets labels to inputs.
* [__LinkLabel.cs__](MGRpgLibrary/Controls/LinkLabel.cs) Links labels together.
* [__PictureBox.cs__](MGRpgLibrary/Controls/PictureBox.cs) Works in conjunction with the camera.

MGRpgLibarary/TileEngine
* [__Camera.cs__](MGRpgLibrary/TileEngine/Camera.cs) The camera class for moving around large maps.
* [__Engine.cs__](MGRpgLibrary/TileEngine/Engine.cs) The engine for the tiles.
* [__MapLayer.cs__](MGRpgLibrary/TileEngine/MapLayer.cs) Sets up the tile engine for multiple layers of tiles on top of each other.
* [__Tile.cs__](MGRpgLibrary/TileEngine/Tile.cs) Class for tile item.
* [__TileMap.cs__](MGRpgLibrary/TileEngine/TileMap.cs) Class for setting up the tile map.
* [__TileSet.cs__](MGRpgLibrary/TileEngine/TileSet.cs) Class for setting up and dealing with tilesets.

RpgLibrary/WorldClasses
* [__LevelData.cs__](RpgLibrary/WorldClasses/LevelData.cs) Reads and sets tile data from a xml file.
* [__MapData.cs__](RpgLibrary/WorldClasses/MapData.cs) Reads and sets map data from a xml file.
* [__MapLayerData.cs__](RpgLibrary/WorldClasses/MapLayerData.cs) Reads and sets map layer data from a xml file.
* [__TilesetData.cs__](RpgLibrary/WorldClasses/TilesetData.cs) Reads and sets tileset data from a xml file.

XLevelEditor
* [__FormMain.cs__](XLevelEditor/FormMain.cs) Main form for the level editor.
* [__FormMain.Designer.cs__](XLevelEditor/FormMain.Designer.cs) Designer file for FormMain.
* [__FormNewLayer.cs__](XLevelEditor/FormNewLayer.cs) Form for generating new layers in the editor.
* [__FormNewLayer.Designer.cs__](XLevelEditor/FormNewLayer.Designer.cs) Designer file for FormNewLayer.
* [__FormNewLevel.cs__](XLevelEditor/FormNewLevel.cs) Form for generating new levels in the editor.
* [__FormNewLevel.Designer.cs__](XLevelEditor/FormNewLevel.Designer.cs) Designer file for FormNewLevel.
* [__FormNewTileset.cs__](XLevelEditor/FormNewTileset.cs) Form for generating the current tilesets.
* [__FormNewTileset.Designer.cs__](XLevelEditor/FormNewTileset.Designer.cs) Designer for the FormNewTileset.
* [__MapDisplay.cs__](XLevelEditor/MapDisplay.cs) Class for displaying the map in the editor.

## Authors
*[**Brennan Sprague**](https://github.com/b-Sprague) - "Creator"
