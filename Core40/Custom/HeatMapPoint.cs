using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveCharts.Custom
{
    public class HeatMapPoint : ScatterPoint
    {
        //Inherited
        //public double X { get; set; }
        //public double Y { get; set; }
        //public double Weight { get; set; }
        public string Cards { get; set; }

        public HeatMapPoint()
        {
        }
        public HeatMapPoint(double x, double y, double weight)
        {
            X = x;
            Y = y;
            Weight = weight;
        }

        public HeatMapPoint(double x, double y, double weight, string cards)
        {
            X = x;
            Y = y;
            Weight = weight;
            this.Cards = cards;
        }
    }
}
