using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravarianceAndRecords
{
    internal interface IAnimal<in T>
    {
        public void Add(T value);
    }

    internal class Animal<T> : IAnimal<T>
    {
        public void Add(T value)
        {
           
        }
    }

    public class Bird { }
    public class Hawk : Bird { }
    public class Flamingo : Bird { }


}
