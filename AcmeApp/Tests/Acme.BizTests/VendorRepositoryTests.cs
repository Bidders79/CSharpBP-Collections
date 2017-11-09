using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = 42;

            //Act
            var actual = repository.RetrieveValue<int>("Select ...", 42);

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueStringTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = "test";

            //Act
            var actual = repository.RetrieveValue<string>("Select ...", "test");

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>(); ;

            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC bla" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ bla" });

            //Act
            var actual = repository.Retrieve();

            //Assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod()]
        public void RetrieveWithIteratorTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>();

            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC bla" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ bla" });

            //Act
            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var item in vendorIterator)
            {
                Console.WriteLine(item);
            }
            var actual = vendorIterator.ToList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void RetrieveAllTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                { new Vendor() { VendorId = 10, CompanyName = "ABC2 bla Toy", Email = "test3@mail.com" } },
                { new Vendor() { VendorId = 15, CompanyName = "ABC64 bla Toy", Email = "test4@mail.com" } },
            }; 

            //Act
            var vendors = repository.RetrieveAll();

            //var vendorQuery = from v in vendors
            //                  where v.CompanyName.Contains("Toy")
            //                  orderby v.CompanyName
            //                  select v;

            //var vendorQuery = vendors.Where(FilterCompanies).OrderBy(OrderCompaniesByName);

            var vendorQuery = vendors.Where(v => v.CompanyName.Contains("Toy"))
                                     .OrderBy(v => v.CompanyName);

            //Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }


        //private bool FilterCompanies(Vendor v) => v.CompanyName.Contains("Toy");

        //private string OrderCompaniesByName(Vendor v) => v.CompanyName;
        

    }
}