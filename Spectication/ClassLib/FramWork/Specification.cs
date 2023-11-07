using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.FramWork
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T value ); 
    }


    public class PositiveNumeberSpecificatioin : ISpecification<int>
    {
        public bool IsSatisfiedBy(int value)
        {
            return value > 0;
        }
    }
}
