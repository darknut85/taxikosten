using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxikosten
{
    class Program
    {
        static void Main(string[] args)
        {
            //aantal gereden kilometers
            double km = 1;

            //kosten overdag
            double eight = 0.25;

            //kosten s'nachts
            double eightteen = 0.45;

            //multiplier weekendkosten
            double weekendCost = 1.15;

            double totalCost;

            double CostMIN;

            //gegevens die ingevuld moeten worden
            Console.WriteLine("Total km");
            double TotalKM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total min");
            double TotalMIN = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is it Weekend? (true or false)");
            bool weekend = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Is it >18.00 & <8.00 when starting? (true or false)");
            bool evening = Convert.ToBoolean(Console.ReadLine());

            //kostenberekening
            double CostKM = km * TotalKM;
            if (evening == true)
            {
                CostMIN = eightteen * TotalMIN;
            }
            else
            {
                CostMIN = eight * TotalMIN;
            }
            if (weekend == true)
            {
                totalCost = (CostKM + CostMIN) * weekendCost;
            }
            else
            {
                totalCost = (CostKM + CostMIN);
            }
            Console.WriteLine("The total cost is: " + totalCost + ".");
            Console.ReadLine();
        }
    }
}
// standaard kosten 1,00 / km
// kosten 0,25 / min tussen 8u / 17.59u
// kosten 0,45 / min tussen 18u en 7.59u
// vr 22.00u t/m ma 6.59u +15% (als rit begint in periode)
