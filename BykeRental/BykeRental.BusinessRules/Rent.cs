using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules
{
    public abstract class Rent
    {
        //protected float? _totalCost;

        public abstract float? TotalCost();
    }
}
