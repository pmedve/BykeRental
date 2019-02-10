using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules
{
    public class RentPerWeek : Rent
    {
        private float? _cost;
        private int? _weeksQuantity;

        public float? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public int? WeeksQuantity
        {
            get { return _weeksQuantity; }
            set { _weeksQuantity = value; }
        }

        public override float? TotalCost()
        {
            return Cost * (WeeksQuantity == null ? 1 : WeeksQuantity); ;            
        }
    }
}
