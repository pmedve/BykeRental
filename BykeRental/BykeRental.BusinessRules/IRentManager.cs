using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BykeRental.BusinessRules
{
    public interface IRentManager
    {
        void Initialize(RentPerDay rent);
        void Initialize(RentPerHour rent);
        void Initialize(RentPerWeek rent);
        void Initialize(FamilyRent rent);        
        float? GetTotalCostRent(Rent rent);
      /*  float? GetTotalCostRent(RentPerWeek rent);
        float? GetTotalCostRent(RentPerDay rent);
        float? GetTotalCostRent(FamilyRent rent);*/
        void FamilyRent_AddRent(FamilyRent familyRent, Rent rent);
        float? FamilyRent_GetTotalAmount(FamilyRent familyRent);
       
    }
}
