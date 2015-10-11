using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGphysics.Сharacteristics
{
    enum AnglePosition
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    class Angle
    {
        private double _value;

        public Angle()
        {
            _value = 0;
        }

        public Angle(double value)
        {
            this.Value = value;
        }

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                double temp = value % 360;
                _value = temp < 0 ? 360 + temp : temp;
            }
        }

        public AnglePosition Position
        {
            get
            {
                if (_value >= 0 && _value < 90)
                    return AnglePosition.TopRight;
                else if (_value >= 90 && _value < 180)
                    return AnglePosition.BottomRight;
                else if (_value >= 180 && _value < 270)
                    return AnglePosition.BottomLeft;
                else if (_value >= 270 && _value < 360)
                    return AnglePosition.TopLeft;

                throw new Exception("Error: Wrong angle position");
            }
        }

        public double ToRadian()
        {
            return _value * Math.PI / 180.0;
        }

        public Angle ReverseForY()
        {
            return new Angle(Position == AnglePosition.TopRight ||
                Position == AnglePosition.BottomLeft ? _value - 90 : _value + 90);
        }

        public Angle ReverseForX()
        {
            return new Angle(Position == AnglePosition.TopRight ||
                Position == AnglePosition.BottomLeft ? _value + 90 : _value - 90);
        }
    }
}
