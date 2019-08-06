using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    public class Game
    {
        private int width, height;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private bool[,] grid;
        public bool[,] Grid
        {
            get { return grid; }
            set { grid = value; }
        }

        public Game(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            Grid = new bool[Width , Height];
        }

        public int GetNeighbouringCells ( int row , int column )
        {
            var aliveCells = 0;

            return aliveCells;
        }
    }

}
