using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Animal
    {
        protected string[] color;
        protected int legs;
        protected string sex;

        public void SetColor(params string[] color) { this.color = color; }
        public string[] GetColor() { return color; }
        public void SetLegs(int legs) { this.legs = legs; }
        public int GetLegs() { return legs; }
        public void SetSex(string sex) { this.sex = sex; }
        public string GetSex() { return sex; }
    }
}
