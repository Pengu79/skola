using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Dog: Animal
    {
        private string race;
        private string name;

        public void SetRace(string race) { this.race = race; }
        public string GetRace() { return race; }
        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }
        public string DogInformation()
        {
            return ($"The dogs name is {this.name} and it is a {this.race} its colors are {this.color[0]} and {this.color} and {this.color[1]}");

        }
    }
}
