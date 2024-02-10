using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Building
    {
        string Adress { get; set; }
        double Length { get; set; }
        double Width { get; set; }
        double Height { get; set; }

        public Building(string adress, double length, double width, double height)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public string Print()
        {
            return $"Адрес здания: {Adress}, Длина здания: {Length}, Ширина здания: {Width}, Высота здания: {Height}";
        }
    }
}
