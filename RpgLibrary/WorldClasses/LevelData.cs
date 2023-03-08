using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary.WorldClasses
{
    public class LevelData
    {
        public string LevelName;
        public string MapName;
        public int MapWidth;
        public int MapHeight;

        private LevelData()
        {
        }

        public LevelData(string levelName, string mapName, int mapWidth, int mapHeight)
        {
            LevelName = levelName;
            MapName = mapName;
            MapWidth = mapWidth;
            MapHeight = mapHeight;
        }

    }
}
