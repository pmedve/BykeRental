using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BykeRental.BusinessRules;
using BykeRental.BusinessRules.Implementation;

namespace BykeRental.UnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest_RentManager
    {
        public UnitTest_RentManager()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Rent per hours tests
        [TestMethod]
        public void Rent_Per_Hour_GetCost_ManyHours()
        {
            float expectedCostResult = 15;

            RentPerHour rent = new RentPerHour();
            RentManager rentManager = new RentManager();            
            rentManager.Initialize(rent);   //Initialize Rent By Hour cost            
            rent.HoursQuantity = 3;         //Set rent on 3 hours
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Hour_GetCost_OneHour()
        {
            float expectedCostResult = 5;

            RentPerHour rent = new RentPerHour();
            RentManager rentManager = new RentManager();
            rentManager.Initialize(rent);   //Initialize Rent By Hour cost            
            //rent.HoursQuantity = 3;         //Whitout set any hours.
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Hour_GetCost_WhitoutInitialize()
        {
            RentPerHour rent = new RentPerHour();
            RentManager rentManager = new RentManager();
            //rentManager.Initialize(rent);   //Whitout Initialize
            //rent.HoursQuantity = 3;         //Whitout set any hours.
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.IsNull(totalCostResult);
        }
        #endregion

        #region Rent per days tests
        [TestMethod]
        public void Rent_Per_Day_GetCost_ManyDays()
        {
            float expectedCostResult = 80;

            RentPerDay rent = new RentPerDay();
            RentManager rentManager = new RentManager();
            rentManager.Initialize(rent);   //Initialize Rent By Day cost            
            rent.DaysQuantity = 4;         //Set rent on 4 Days
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Day_GetCost_OneDay()
        {
            float expectedCostResult = 20;

            RentPerDay rent = new RentPerDay();
            RentManager rentManager = new RentManager();
            rentManager.Initialize(rent);   //Initialize Rent By Day cost            
            //rent.DaysQuantity = 3;         //Whitout set any days.
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Day_GetCost_WhitoutInitialize()
        {
            RentPerDay rent = new RentPerDay();
            RentManager rentManager = new RentManager();
            //rentManager.Initialize(rent);   //Whitout Initialize
            //rent.DaysQuantity = 3;         //Whitout set any Days.
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.IsNull(totalCostResult);
        }
        #endregion

        #region Rent per week tests
        [TestMethod]
        public void Rent_Per_Week_GetCost_ManyWeeks()
        {
            float expectedCostResult = 120;

            RentPerWeek rent = new RentPerWeek();
            RentManager rentManager = new RentManager();
            rentManager.Initialize(rent);   //Initialize Rent By Week cost            
            rent.WeeksQuantity = 2;         //Set rent on 2 weeks
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Week_GetCost_OneWeek()
        {
            float expectedCostResult = 60;

            RentPerWeek rent = new RentPerWeek();
            RentManager rentManager = new RentManager();
            rentManager.Initialize(rent);   //Initialize Rent By Week cost            
            //rent.WeeksQuantity = 3;         //Whitout set any Weeks.
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Week_GetCost_WhitoutInitialize()
        {
            RentPerWeek rent = new RentPerWeek();
            RentManager rentManager = new RentManager();
            //rentManager.Initialize(rent);   //Whitout Initialize
            //rent.WeeksQuantity = 3;         //Whitout set any Weeks.
            float? totalCostResult = rentManager.GetTotalCostRent(rent);

            Assert.IsNull(totalCostResult);
        }
        #endregion

        #region Rent per Family tests
        [TestMethod]
        public void Rent_Per_Family_GetCost_3rents()
        {
            float expectedCostResult = (float)(160*(0.7));

            RentPerWeek rent1 = new RentPerWeek();
            RentPerWeek rent2 = new RentPerWeek();
            RentPerDay rent3 = new RentPerDay();

            rent3.DaysQuantity = 2;

            RentManager rentManager = new RentManager();

            rentManager.Initialize(rent1);   //Initialize Rent By Week cost            
            rentManager.Initialize(rent2);   //Initialize Rent By Week cost            
            rentManager.Initialize(rent3);   //Initialize Rent By Week cost            

            FamilyRent rent = new FamilyRent();

            rentManager.Initialize(rent);
            List<Rent> rents = new List<Rent> {rent1, rent2, rent3};
            rent.AddRents(rents);
            /*rent.AddRent(rent1);
            rent.AddRent(rent2);
            rent.AddRent(rent3);*/
            
            float? totalCostResult = rentManager.FamilyRent_GetTotalAmount(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }

        [TestMethod]
        public void Rent_Per_Family_GetCost_5rents()
        {
            float expectedCostResult = (float)((20+15+20+5+5) * (0.7));

            RentPerHour rent1 = new RentPerHour();
            RentPerHour rent2 = new RentPerHour();
            RentPerDay rent3 = new RentPerDay();
            RentPerHour rent4 = new RentPerHour();
            RentPerHour rent5 = new RentPerHour();

            rent1.HoursQuantity = 4;
            rent2.HoursQuantity = 3;            

            RentManager rentManager = new RentManager();

            rentManager.Initialize(rent1);   //Initialize Rent 
            rentManager.Initialize(rent2);   //Initialize Rent 
            rentManager.Initialize(rent3);   //Initialize Rent 
            rentManager.Initialize(rent4);   //Initialize Rent 
            rentManager.Initialize(rent5);   //Initialize Rent 

            FamilyRent rent = new FamilyRent();

            rentManager.Initialize(rent);
            List<Rent> rents = new List<Rent> { rent1, rent2, rent3 };
            rent.AddRents(rents);
            rent.AddRent(rent4);
            rent.AddRent(rent5);

            float? totalCostResult = rentManager.FamilyRent_GetTotalAmount(rent);

            Assert.AreEqual(expectedCostResult, totalCostResult);
        }
        
        [TestMethod]        
        public void Rent_Per_Family_GetCost_2rents()
        {
            RentPerHour rent1 = new RentPerHour();
            RentPerHour rent2 = new RentPerHour();
          
            rent1.HoursQuantity = 2;
            rent2.HoursQuantity = 3;

            RentManager rentManager = new RentManager();

            rentManager.Initialize(rent1);   //Initialize Rent 
            rentManager.Initialize(rent2);   //Initialize Rent 
            
            FamilyRent rent = new FamilyRent();

            rentManager.Initialize(rent);                        
            rent.AddRent(rent1);            //Adding 2 rents
            rent.AddRent(rent2);

            try
            {
                float? totalCostResult = rentManager.FamilyRent_GetTotalAmount(rent);
            }
            catch (Exception ex)
            {                
                Assert.AreEqual<string>(ex.Message, "Family Rental, need include from 3 to 5 Rentals. This Family Rental only have 2 rents.");
            }
        }

        [TestMethod]
        public void Rent_Per_Family_GetCost_6rents()
        {
            RentPerHour rent1 = new RentPerHour();
            RentPerHour rent2 = new RentPerHour();

            RentManager rentManager = new RentManager();

            rentManager.Initialize(rent1);   //Initialize Rent 
            rentManager.Initialize(rent2);   //Initialize Rent 

            FamilyRent rent = new FamilyRent();

            rentManager.Initialize(rent);
            rent.AddRent(rent1);            //Adding 6 rents
            rent.AddRent(rent2);
            rent.AddRent(rent1);
            rent.AddRent(rent2);
            rent.AddRent(rent1);
            rent.AddRent(rent2);

            try
            {
                float? totalCostResult = rentManager.FamilyRent_GetTotalAmount(rent);
            }
            catch (Exception ex)
            {
                Assert.AreEqual<string>(ex.Message, "Family Rental, need include from 3 to 5 Rentals. This Family Rental only have 6 rents.");
            }
        }


        #endregion
    }
}
