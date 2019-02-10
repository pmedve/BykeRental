using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules.Implementation
{
    public class RentManager : IRentManager
    {

        public void Initialize(RentPerDay rent)
        {
            rent.Cost = 20;
        }

        public void Initialize(RentPerHour rent)
        {
            rent.Cost = 5;
        }

        public void Initialize(RentPerWeek rent)
        {
            rent.Cost = 60;
        }

        public void Initialize(FamilyRent rent)
        {
            rent.Discount = 30;
        }

        public float? GetTotalCostRent(Rent rent)
        {            
            return rent.TotalCost();
        }
        /*
        public float? GetTotalCostRent(RentPerWeek rent)
        {
            return rent.TotalCost();
        }

        public float? GetTotalCostRent(RentPerDay rent)
        {            
            return rent.TotalCost();
        }

        public float? GetTotalCostRent(FamilyRent rent)
        {            
            return rent.TotalCost();
        }
        */
        public void FamilyRent_AddRent(FamilyRent familyRent, Rent rent)
        {
            familyRent.AddRent(rent);
        }

        public float? FamilyRent_GetTotalAmount(FamilyRent familyRent)
        {
            if ((familyRent.Count() < 3)||(familyRent.Count() > 5))
                throw new ArgumentException("Family Rental, need include from 3 to 5 Rentals. This Family Rental only have " + familyRent.Count().ToString() + " rents."); 
            return familyRent.TotalCost();
        }
        
    }
}
