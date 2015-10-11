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

        private List<Subjects.Subject> _subjects;

        #region Constructors

        public Plane(Coordinate minCoordinate, Coordinate maxCoordinate)
        {
            _minCoordinate = minCoordinate;
            _maxCoordinate = maxCoordinate;
            _subjects = new List<Subjects.Subject>();
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

        public List<Subjects.Subject> Subjects
        {
            get
            {
                return _subjects;
            }
        }

        #endregion

        #region Main methods

        public void AddSubject(Subjects.Subject subject)
        {
            _subjects.Add(subject);
        }

        public void Update(uint fps)
        {
            foreach (var subject in _subjects)
            {
                if (subject.Position.X <= _minCoordinate.X || subject.Position.X >= _maxCoordinate.X)
                    subject.Speed.Angle = subject.Speed.Angle.ReverseForY();

                if (subject.Position.Y <= _minCoordinate.Y || subject.Position.Y >= _maxCoordinate.Y)
                    subject.Speed.Angle = subject.Speed.Angle.ReverseForX();

                subject.Update(fps);
            }
        }

        #endregion
    }
}
