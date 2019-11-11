using System;
using ACM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Modestas",
                LastName = "Alvinskis"
            };
            string expected = "Modestas, Alvinskis";

            //-- ACT
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                LastName = "Alvinskis"
            };
            string expected = "Alvinskis";

            //-- ACT
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Modestas"
            };
            string expected = "Modestas";

            //-- ACT
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer()
            {
                LastName = "Alvinskis",
                EmailAddress = "xmodisx@gmail.com"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer()
            {
                EmailAddress = "xmodisx@gmail.com"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            //-- Arrange
            var customer = new Customer()
            {
                LastName = "Alvinskis"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
