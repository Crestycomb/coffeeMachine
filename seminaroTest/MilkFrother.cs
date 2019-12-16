using System;
using System.Collections.Generic;
using System.Text;

namespace seminaroTest
{
    public interface IMilkFrother
    {
        void Froth();
    }

    public class MilkFrother : IMilkFrother
    {
        public MilkFrother()
        {
            Console.WriteLine("Milk frother is online!");
        }
        public void Froth()
        {
            Console.WriteLine("Frothing!");
        }
    }
}
