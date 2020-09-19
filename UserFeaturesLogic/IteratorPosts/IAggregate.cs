using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserFeaturesLogic
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
