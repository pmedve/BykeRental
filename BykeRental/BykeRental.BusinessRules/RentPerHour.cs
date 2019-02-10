using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules
{
    public class RentPerHour : Rent
    {
        private float? _cost;
        private int? _hoursQuantity;
 
        public float? Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public int? HoursQuantity
        {
            get { return _hoursQuantity; }
            set { _hoursQuantity = value; }
        }

        public override float? TotalCost()
        {
            return Cost * (HoursQuantity == null ? 1 : HoursQuantity);
        }

    }
}
