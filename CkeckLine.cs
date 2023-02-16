using System;
using MYLine ;
using LineLength;

namespace Checkline{
    public class CheckLine {
           public void linecheck(Line line1 , Line line2){
            Lengthofline obj = new Lengthofline();
          double value1 =  obj.Linelegth(line1);
          double value2 =  obj.Linelegth(line2);
          if (value1 == value2){
            Console.WriteLine("it is equal");
          }else{
            Console.WriteLine("it is not equal");
          }
           }
    }
}