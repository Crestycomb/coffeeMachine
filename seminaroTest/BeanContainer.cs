using System;
using System.Collections.Generic;
using System.Text;

namespace seminaroTest
{
    public interface IBeanContainer
    {
        int BeanAmount { get; set; }

        int GetBeans(int amount);
    }

    public class BeanContainer : IBeanContainer
    {
        public int BeanAmount { get; set; } = 1000; // has 1000 beans initially
        public BeanContainer(int amount)
        {
            BeanAmount = amount;
        }

        public int GetBeans(int amount)
        {
            BeanAmount = -amount;
            return BeanAmount;
        }
    }
}
