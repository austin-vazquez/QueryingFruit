using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingFruit
{
    enum PowerLevel { ROOKIE = 1, SUPERNOVA, CAPTAIN=SUPERNOVA, ADMIRAL, DIVISION_COMMANDER=ADMIRAL, YONKO, FLEET_ADMIRAL=YONKO}

    class Fruit
    {
        //adding comment
        private const int DEFAULT_DIAM = 5;

        private string name;
        private int diameter;
        private string power;
        private PowerLevel powerLevel;

        public Fruit(string name, int diameter)
        {
            this.name = name;
            this.diameter = diameter;
            this.power = "none";
            this.powerLevel = 0;
        }

        public Fruit(string name, string power, PowerLevel powerLevel)
        {
            this.name = name;
            this.diameter = DEFAULT_DIAM;
            this.power = power;
            this.powerLevel = powerLevel;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Diameter
        {
            get { return this.diameter; }
        }

        public string Power
        {
            get { return this.power; }
        }

        public PowerLevel PowerLevel
        {
            get { return this.powerLevel; }
        }

        public bool normalFruit()
        {
            if (this.powerLevel == 0)
                return true;
            return false;
        }

        public override string ToString()
        {
            string str = "";
            if (name.Length >= 9)
                str += "Fruit: " + name + "\tPower: ";
            else
                str += "Fruit: " + name + "\t\tPower: ";
            if (this.power.Length >= 9)
                str += power + "\tLevel: " + powerLevel;
            else
                str += power + "\t\tLevel: " + powerLevel;

            return str;
        }
    }
}
