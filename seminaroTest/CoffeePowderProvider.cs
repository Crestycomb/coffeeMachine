using System;
using System.Collections.Generic;
using System.Text;

namespace seminaroTest
{
    public interface ICoffeePowderProvider
    {
        void GetPowder();
    }

    public class CoffeePowderProvider : ICoffeePowderProvider
    {
        private readonly Mill _mill;
        private readonly BeanContainer _beanContainer;
        public CoffeePowderProvider(Mill _mill, BeanContainer _beanContainer)
        {
            this._mill = _mill;
            this._beanContainer = _beanContainer;
        }
        public void GetPowder()
        {
            _mill.Grind();
            Console.WriteLine("We have powder!");
        }
    }
}
