using System;
using System.Collections.Generic;
using System.Text;

namespace MakeDetailsOOP
{
    public abstract class MachineTool
    {
        public TimeSpan makeTime;
        public MachineTool(TimeSpan time)
        {
            makeTime = time;
        }

        public abstract Detail MakeDetail();
    }

    public class CarMachineTool: MachineTool
    {
        public CarMachineTool() : base(new TimeSpan(00, 30, 00)) { }
        public override Detail MakeDetail()
        {
            return new CarDetail(makeTime);
        }
    }

    public class ShipMachineTool : MachineTool
    {
        public ShipMachineTool() : base(new TimeSpan(01, 00, 00)) { }
        public override Detail MakeDetail()
        {
            return new ShipDetail(makeTime);
        }
    }

    public class PlaneMachineTool : MachineTool
    {
        public PlaneMachineTool() : base(new TimeSpan(01, 30, 00)) { }

        public override Detail MakeDetail()
        {
            return new PlaneDetail(makeTime);
        }
    }


}
