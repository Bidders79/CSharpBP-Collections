using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;

            return value;
        }

        public IEnumerable<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC bla" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ bla"});
            }

            foreach (var vendor in vendors)
            {
                Console.WriteLine(vendor);
            }
            //Console.WriteLine(vendors[1]);
            return vendors;
        }
        public IEnumerable<Vendor> RetrieveAll()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC bla", Email = "test1@mail.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ bla", Email = "test2@mail.com" });
                vendors.Add(new Vendor() { VendorId = 10, CompanyName = "ABC2 bla Toy", Email = "test3@mail.com" });
                vendors.Add(new Vendor() { VendorId = 15, CompanyName = "ABC64 bla Toy", Email = "test4@mail.com" });
                vendors.Add(new Vendor() { VendorId = 25, CompanyName = "XYZ2 bla", Email = "test4@mail.com" });
                vendors.Add(new Vendor() { VendorId = 11, CompanyName = "ABC4 bla", Email = "test5@mail.com" });
                vendors.Add(new Vendor() { VendorId = 26, CompanyName = "XYZ2 bla", Email = "test6@mail.com" });
                vendors.Add(new Vendor() { VendorId = 100, CompanyName = "ABC87 bla", Email = "test7@mail.com" });
                vendors.Add(new Vendor() { VendorId = 23, CompanyName = "XYZ6 bla", Email = "test8@mail.com" });
            }

            
            return vendors;
        }
        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            //get data form database
            this.Retrieve();

            foreach(var vendor in vendors)
            {
                Console.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }         


    }
}
