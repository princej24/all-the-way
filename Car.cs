using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_the_way
{
    public class Car
    {

        private Engine _engine;
        private List<Wheel> _wheels;

        //

        public Engine Engine
        {

            get { return _engine; }
            set { _engine = value; }

        }

        public List<Wheel> Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }

        public Engine engine { get => _engine; set => _engine = value; }
        public List<Wheel> wheels { get => _wheels; set => _wheels = value; }

        //public 
        //}

    }
}
