using System;
using System.Collections.Generic;
using System.Text;

namespace seminaroTest
{
    public interface IMill
    {
        void Grind();
    }

    public class Mill : IMill
    {
        public Mill()
        {
            Console.WriteLine("Mill is online");
        }
        public void Grind()
        {
            Console.WriteLine("Grinding in process");
        }
    }
}
