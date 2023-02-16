using System;
using MYLine;
namespace LineLength{

      class Lengthofline{

        public  double Linelegth(Line line){
            double x1 =line.X1;
            double x2 = line.X2;
            double y1 = line.Y1;
            double y2 = line.Y2;

           double length= Math.Sqrt( Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2) );
           return length;


    }

      }
}