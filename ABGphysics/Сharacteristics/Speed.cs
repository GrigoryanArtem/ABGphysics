using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABGphysics.Сharacteristics;

namespace ABGphysics
{
    class Speed
    {
        private double _value;
        private Angle _angle;

        #region Auto implemented properties

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public Angle Angle
        {
            get
            {
                return _angle;
            }
            set
            {
                _angle = value;
            }
        }

        #endregion

        #region Constructors

        public Speed(double value, Angle angle)
        {
            this.Value = value;
            this.Angle = angle;
        }

        #endregion

        #region Main methods

        public virtual bool IsNull()
        {
            return false;
        }

        #endregion
    }
}
