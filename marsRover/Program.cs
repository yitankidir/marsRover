using marsRover.Enums;
using marsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2);

            Rover rover = new Rover(plateau, position, Direction.N);
            rover.Process("LMLMLMLMM");
            Console.WriteLine(rover.CurrentPosition());

            rover.SetPosition(3, 3, Direction.E);
            rover.Process("MMRMMRMRRM");
            Console.WriteLine(rover.CurrentPosition()); 

        }
    }
}
