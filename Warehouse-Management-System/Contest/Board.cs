﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
  public class Board
    {
        public List<Cell> cells { get; set; }
        public int size { get; set; } = 10;
        public Board()
        {
            cells = new List<Cell>();
            for (int i = 1; i <= size; i++)
            {
                for (int j= 1; j<=size ;j++)
                {
                    cells.Add(new Cell(i, j));
                }
            }
        }
        
        public void printBoard()
        {
            cells[9].IsEmpty = false;
            cells[19].IsEmpty = false;
            cells[29].IsEmpty = false;
            cells[39].IsEmpty = false;

            cells[4].IsEmpty = false;
            cells[14].IsEmpty = false;
            cells[24].IsEmpty = false;
            cells[34].IsEmpty = false;

            cells[50].IsEmpty = false;
            cells[51].IsEmpty = false;
            cells[52].IsEmpty = false;
            cells[53].IsEmpty = false;
            cells[54].IsEmpty = false;

            cells[0].IsEmpty = false;
            cells[1].IsEmpty = false;
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (cells[i].IsEmpty)
                {
                    cells[i].printCell();
                    counter++;
                }
                if (!cells[i].IsEmpty)
                {
                    Console.Write("[S]"); ;
                    counter++;

                }
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0;
                }


            }

        }



    }
}
