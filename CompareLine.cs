using System;
using MYLine ;
using LineLength;

namespace CompareLine{
    public class LineComapre{
           public void linecheck(Line line1 , Line line2){
            Lengthofline obj = new Lengthofline();
          double value1 =  obj.Linelegth(line1);
          double value2 =  obj.Linelegth(line2);
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