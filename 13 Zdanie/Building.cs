using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zdanie
{
           class Building
        {
                       string address;
            double Length { get; set; }
            double width { get; set; }
            double heigth { get; set; }
        int Length
        {
            get
            {
                return length;
            }
            set 
            {
                if (value < 0)
                {
                    length = 0;
                }
                else
                    length = value;
                            }
        }

            public Building(string a, double l, double w, double h)
            {
                this.address = a;
                this.length = l;
                this.width = w;
                this.heigth = h;
            }
            public string Print()
            {
                return $"адрес: {address}, длина={length}м, ширина={width}м, высота={heigth}м";
            }
        }
}
