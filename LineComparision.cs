using System;
using MYLine;

namespace LineComparison {

    public class LineComparisonClass{

          public  double Linelegth(Line line ){
              double x1 =line.X1;
            double x2 = line.X2;
            double y1 = line.Y1;
            double y2 = line.Y2;
           double length= Math.Sqrt( Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2) );
           return length;


    }
        public void CheckLine(Line line1 , Line line2){
          double value1 =  Linelegth(line1);
          double value2 =  Linelegth(line2);
          if (value1 == value2){
            Console.WriteLine("it is equal");
          }else{
            Console.WriteLine("it is not equal");
          }

        }
        public void CompareLine(Line line1 , Line line2){
              double value1 =  Linelegth(line1);
          double value2 =  Linelegth(line2);
          if (value1 == value2){
            Console.WriteLine("it is equal");
          }else if(value1 < value2 ){
            Console.WriteLine("Line 2 is greater");
          }else{
            Console.WriteLine("Line1 is greater");
          }
        }


    }

}