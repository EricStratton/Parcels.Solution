using System.Collections.Generic;
using System;

namespace Parcels.Models
{
    public class Parcel
    {
        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public double Cost { get; set; }

        public Parcel(double length, double width, double height, double weight, double cost)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            Cost = cost;
        }

        public double SetCost()
        {
            double volumeInch = this.Length * this.Width * this.Height;
            double setCost = volumeInch * .50;
            this.Cost = Math.Round(setCost, 2);
            return this.Cost;
        }
    }
}