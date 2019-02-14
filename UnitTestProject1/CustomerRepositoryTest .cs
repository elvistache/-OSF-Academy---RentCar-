using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentC;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            { 
                Email = "elvis.tache@outlook.com",
                FirstName = "Elvis",
                LastName = "Tache"
            };

             
            //Act
            var actual = customerRepository.Retrieve(1);
             

            //Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);


        }
        }
    }
