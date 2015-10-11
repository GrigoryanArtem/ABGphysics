using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGphysics
{
    class Plane
    {
        private Coordinate _minCoordinate;
        private Coordinate _maxCoordinate;

        #region Constructors

        public Plane(Coordinate minCoordinate, Coordinate maxCoordinate)
        {
            _minCoordinate = minCoordinate;
            _maxCoordinate = maxCoordinate;
        }

        #endregion

        #region Auto implemented properties

        public Coordinate MinCoordinate
        {
            get
            {
                return _minCoordinate;
            }
            set
            {
                _minCoordinate = value;
            }
        }

        public Coordinate MaxCoordinate
        {
            get
            {
                return _maxCoordinate;
            }
            set
            {
                _maxCoordinate = value;
            }
        }

        public double Height
        {
            get
            {
                return Math.Sqrt(Math.Pow(_minCoordinate.Y - _maxCoordinate.Y, 2));
            }
        }

        public double Width
        {
            get
            {
                return Math.Sqrt(Math.Pow(_minCoordinate.X - _maxCoordinate.X, 2));
            }
        }

        #endregion

        #region Main methods

        #endregion
    }
}
