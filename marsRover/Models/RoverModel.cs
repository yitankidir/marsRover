using marsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marsRover.Models
{
    public class Rover
    {
        #region Field 

        private Plateau _plateau;
        private Position _position;
        private Direction _heading = MainRoverClass.heading;

        #endregion

        public Rover(Plateau plateau, Position position, Direction heading)
        {
            _plateau = plateau;
            _position = position;
            _heading = heading;
        }


        #region Property

        public Plateau plateau
        {
            get { return _plateau; }

            set { _plateau = value; }
        }

        public Position position
        {
            get { return _position; }

            set { _position = value; }
        }

        public Direction heading
        {
            get { return _heading; }

            set { _heading = value; }
        }

        #endregion

    }
}
