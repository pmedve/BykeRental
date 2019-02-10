# BykeRental
Technical Exercise for Intive - FDV

I used a Visual Studio 2010 to develop the exercise.

I used a simple N tiers architecture. I built a Business Rules and Business Rules Implementation DLLs to make the data model and business rules. Always thinking in the idea to have an architecture that could be upgraded.

The model is basicly an abstract rent class with his childrens: RentPerHour, RentPerDay, RentPerWeek and FamilyRent. The last one is basicly a collection of the another three.
The basic functionality that i did on this exercise is the Total Cost calculation of the rents. (i suposed some business rules that was not explained on the exercise definition)

I used the Visual Studio Test Tools to build a Unit Test with many test methods. To can run the tests you need only execute the BykeRental.Test project. (I setted it like the default Start project and I also uploaded the compiled DLLs on this repository to facilitate execution.)

Thanks again for this opportunity,
Pablo Medvedovsky.
