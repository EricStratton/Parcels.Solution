using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        private double _length { get; set; }
        private double _width { get; set; }
        private double _height { get; set; }
        private double _weight { get; set; }
        private double _cost { get; set; }

        public Parcel(double Length, double Width, double Height, double Weight, double Cost)
        {
            Length = _length;
            Width = _width;
            Height = _height;
            Weight = _weight;
        }

        public static double CalcCost()
        {
            double volumeInch = this._length * this._width * this._height;
            double _cost = volumeInch * .50;
        }
    }
}