using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules
{
    public class RentPerDay : Rent
    {
        private float? _cost;
        private int? _daysQuantity;

        public float? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public int? DaysQuantity
        {
            get { return _daysQuantity; }
            set { _daysQuantity = value; }
        }

        public override float? TotalCost()
        {
            return Cost * (DaysQuantity == null?1:DaysQuantity);
        }

    }
}
