using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGphysics.Subjects
{
    abstract class Subject
    {
        protected Coordinate _position;
        protected Speed _speed;

        public Coordinate Position
        {
            get
            {
                return _position;
            }
        }

        public Speed @Speed
        {
            get
            {
                return _speed;
            }
        }

        public abstract void Update(uint fps);
    }
}
