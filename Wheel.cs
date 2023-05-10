using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_the_way
{
    public class Wheel
    {


        private Car _car;
        private int _size;
        private string _brand;

        public Wheel()
        {
        }

        public Wheel(int size, string brand)
        {
            _size = size;
            _brand = brand;
        }

        public Car Car { get => _car; set => _car = value; }
        public int Size { get => _size; set => _size = value; }
        public string Brand { get => _brand; set => _brand = value; }
    }
}
