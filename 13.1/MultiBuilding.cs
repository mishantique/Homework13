using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    sealed class MultiBuilding : Building
    {
        private int Floors { get; set; }
        public MultiBuilding(string adress, double length, double width, double height, int floors)
            :base(adress, length, width, height)
        {
            this.Floors = floors;
        }

        new public string Print()
        {
            return base.Print() + $", Количество этажей: {Floors}";
        }
    }
}
