﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

        }
        static void Draw(int x,int y,char sym )
        {
            Console.SetCursorPosition(x, y);
            Console.Write( sym );
        }
    }
}
