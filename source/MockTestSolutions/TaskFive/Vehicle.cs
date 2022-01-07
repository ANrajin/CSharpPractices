using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    public class Vehicle
    {
        public string _name;
        public string _color;
        public int _weight;

        public Vehicle(string name, string color)
        {
            this._name = name;
            this._color = color;
        }

        public Vehicle(string name, string color, int weight)
        {
            this._name = name;
            this._color = color;
            this._weight = weight;
        }
    }
}
