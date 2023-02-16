using System ;
using MYLine;
using LineLength;
using Checkline;

namespace LineComparison{

    public class Program{
        
        public static void Main(string[] args){
            Console.WriteLine("Enter the values for the first line:");
            Console.WriteLine("Enter X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Line line1 = new Line(x1, y1, x2, y2);

            Console.WriteLine("Enter the values for the second line:");
            Console.WriteLine("Enter X1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Line line2 = new Line(x1, y1, x2, y2);
            
            CheckLine linecheckobj = new CheckLine();
            linecheckobj.linecheck(line1,line2);
           


        }

    }


}