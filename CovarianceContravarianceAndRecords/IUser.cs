using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravarianceAndRecords;

internal interface IUser<out T>
{
    public T Get(int id);
    //public void Add(T user);
}

internal class SuperUser<T> : IUser<T>
{
    public T Get(int id)
    {
        return Activator.CreateInstance<T>();
    }
}
