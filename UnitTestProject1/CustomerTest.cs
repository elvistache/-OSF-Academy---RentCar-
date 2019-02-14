using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentC;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Elvis";
            customer.LastName = "Tache";

            string expected = "Elvis Tache";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
