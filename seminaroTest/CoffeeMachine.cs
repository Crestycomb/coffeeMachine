using System;
using System.Collections.Generic;
using System.Text;

namespace seminaroTest
{
    public interface ICoffeeMachine
    {
        void MakeCoffee();
    }

    public class CoffeeMachine : ICoffeeMachine
    {
        private readonly WaterTank _waterTank;
        private readonly CoffeePowderProvider _coffeePowderProvider;
        private readonly MilkFrother _milkFrother;
        public CoffeeMachine(WaterTank _waterTank, CoffeePowderProvider _coffeePowderProvider, MilkFrother _milkFrother)
        {
            this._waterTank = _waterTank;
            this._coffeePowderProvider = _coffeePowderProvider;
            this._milkFrother = _milkFrother;
        }
        public void MakeCoffee()
        {
            _waterTank.GetWater();
            _coffeePowderProvider.GetPowder();
            _milkFrother.Froth();

            Console.WriteLine("Simple coffee done!");
            Console.WriteLine("end");
        }
    }
}
