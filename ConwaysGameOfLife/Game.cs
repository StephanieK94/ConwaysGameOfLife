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

            for(var x = row - 1 ; x <= row + 1 ; x++ )
            {
                for(var y = column -1 ; y <= column + 1 ; y++ )
                {
                    if ( !( ( x < 0 || y < 0 ) || ( x >= this.Width || y >= this.Height ) || ( x == row && y == column ) ) )
                    {
                        if ( this.Grid[x , y] == true ) aliveCells++;
                    }
                }
            }

            return aliveCells;
        }
    }

}
