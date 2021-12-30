using System;

namespace MakeDetailsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineTool machineTool = new CarMachineTool();
            Detail detail = machineTool.MakeDetail();
            Console.WriteLine();
            CarMachineTool carMachineTool = new CarMachineTool();
            detail = carMachineTool.MakeDetail();
            Console.WriteLine();
            CarDetail carDetail = (CarDetail)carMachineTool.MakeDetail();
            Console.WriteLine("__________________________");


            machineTool = new ShipMachineTool();
            detail = machineTool.MakeDetail();
            Console.WriteLine();
            ShipMachineTool shipMachineTool = new ShipMachineTool();
            detail = shipMachineTool.MakeDetail();
            Console.WriteLine();
            ShipDetail shipDetail = (ShipDetail)shipMachineTool.MakeDetail();
            Console.WriteLine("__________________________");
        

            machineTool = new PlaneMachineTool();
            detail = machineTool.MakeDetail();
            Console.WriteLine();
            PlaneMachineTool planeMachineTool = new PlaneMachineTool();
            detail = planeMachineTool.MakeDetail();
            Console.WriteLine();
            PlaneDetail planeDetail = (PlaneDetail)planeMachineTool.MakeDetail();
            Console.WriteLine();
        }
    }
}
