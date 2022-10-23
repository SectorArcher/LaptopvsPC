using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopvsPC
{
    public class Results
    {
        public int PointsOfPC { get; set; }
        public int PointsOfLaptop { get; set; }

        public Results(int pointsOfPC,int pointsOfLaptop)
        {
            this.PointsOfPC = pointsOfPC;
            this.PointsOfLaptop = pointsOfLaptop;
        }

        public double getPCPercentage()
        {
            double osszPont = PointsOfPC + PointsOfLaptop;
            double pcSzazalek = PointsOfPC / osszPont * 100;
            return pcSzazalek;
        }
        public double getLaptopPercentage()
        {
            double osszPont = PointsOfPC + PointsOfLaptop;
            double laptopSzazalek = PointsOfLaptop / osszPont * 100;
            return laptopSzazalek; 
        }

       
    }
}
