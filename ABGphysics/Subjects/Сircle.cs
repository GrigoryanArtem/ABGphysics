using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGphysics.Subjects
{
    class Сircle : Subject
    {
        public Сircle(Coordinate position, Speed speed)
        {
            _position = position;
            _speed = speed;
        }
        public override void Update(uint fps)
        {
            _position.Y = _position.Y + (_speed.Value * Math.Cos(_speed.Angle.ToRadian()) / fps);
            _position.X = _position.X + (_speed.Value * Math.Sin(_speed.Angle.ToRadian()) / fps);
        }
    }
}
