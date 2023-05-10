using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_the_way
{
    public class Engine
    {
        private Car _car;
        private int _horsepower;
        private int _displacement;
        private string _fuelType;
        public Engine(int horsepower, int displacement, string fuelType)
        {
            _horsepower = horsepower;
            _displacement = displacement;
            _fuelType = fuelType;
        }
        public Car Car { get => _car; set => _car = value; }
        public int Horsepower { get => _horsepower; set => _horsepower = value; }
        public int Displacement { get => _displacement; set => _displacement = value; }
        public string FuelType { get => _fuelType; set => _fuelType = value; }
    }
}
