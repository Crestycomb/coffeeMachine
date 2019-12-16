using System;


namespace seminaroTest
{
    class Program
    {
        static void Main(string[] args)
        {
           /// OperationEvent objOperationEvent = new OperationEvent(new EventViewerLogger());

            CoffeeMachine firstCoffeeMachine = new CoffeeMachine(new WaterTank(), new CoffeePowderProvider(new Mill(), new BeanContainer(500)), new MilkFrother() );
            firstCoffeeMachine.MakeCoffee();
        }
    }
}
