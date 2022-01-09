using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zdanie
{
    sealed class MultiBuilding : Building
    {
        int floors;
        int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value < 0)
                    floors = 0;
                else
                    floors = value;
            }
        }
        public MultiBuilding(string a, double l, double w, double h, int f)
            :base(a, l, w, h)
        {
            this.floors = f;
        }
        public string Print()
        {
            string result = base.Print();
            result += $", этажей - {floors}";
            return result;
        }
    }
}
