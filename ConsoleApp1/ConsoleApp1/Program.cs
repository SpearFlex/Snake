using System;
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
            Point p1 = new Point(3,6,'#');
            
            p1.Draw();

            List<int> numList = new List<int>();
            numList.Add( 0 );
            numList.Add( 1 );
            numList.Add( 2 );
            Console.ReadLine();

        }


    }
}