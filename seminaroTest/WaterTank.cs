using System;
using System.Collections.Generic;
using System.Text;

namespace seminaroTest
{
    public interface IWaterTank
    {
        void GetWater();
    }

    public class WaterTank : IWaterTank
    {
        public void GetWater()
        {
            Console.WriteLine("We have water!");
        }
    }
}
