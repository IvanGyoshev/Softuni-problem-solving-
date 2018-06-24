using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double costs = 0.0d;
            if (service=="standard")
            {
                if (weight < 1) costs = 0.03d;
                else if (weight >= 1 && weight <= 10) costs = 0.05d;
                else if (weight >= 11 && weight <= 40) costs = 0.1d;
                else if (weight >= 41 && weight <= 90) costs = 0.15d;
                else if (weight >= 91 && weight <= 150) costs = 0.2d;
            }
            else if (service == "express")
            {
                if (weight < 1) costs = 1.8*0.03d*weight;
                else if (weight >= 1 && weight <= 10) costs = 1.4*0.05d * weight;
                else if (weight >= 11 && weight <= 40) costs =  1.05*0.1d*weight;
                else if (weight >= 41 && weight <= 90) costs = 0.02*0.15d*weight + 0.15d;
                else if (weight >= 91 && weight <= 150) costs = 1.01*0.2d * weight;
            }
            costs *= distance;
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.",
               weight,costs );
        }
    }
}
