using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules
{
    public class FamilyRent
    {
        private List<Rent> Rents { get; set; }
        private float? _discount;

        public float? TotalCost()
        {
            float? totalCost = (Rents.Sum(x => x.TotalCost()));
            totalCost = totalCost - (totalCost * (Discount / 100));
            return totalCost;                            
        }

        public int Count()
        {
            if (Rents != null) return Rents.Count;
            else return 0;
        }

        public float? Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }


        public void AddRents(List<Rent> rents)
        {            
            if (Rents == null) Rents = new List<Rent>();
            foreach (Rent r in rents)
                Rents.Add(r);
        }

        public void AddRent(Rent rent)
        {
            if (Rents == null) Rents = new List<Rent>();
            Rents.Add(rent);
        }

    }
}
