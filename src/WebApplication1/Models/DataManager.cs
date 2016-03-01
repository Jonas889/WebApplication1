using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DataManager
    {
        static List<Customer> customers = new List<Customer>();

        static DataManager()
        {
            customers.Add(new Customer { Id = 1, CompanyName = "ICA", City = "Sundsvall" });
            customers.Add(new Customer { Id = 1, CompanyName = "Coop", City = "Sundsvall" });
            customers.Add(new Customer { Id = 1, CompanyName = "Konsum", City = "Umeå" });
        }

        public Customer[] GetAllCustomers()
        {
            return customers
                .OrderBy(c => c.CompanyName)
                .ToArray();
        }
        public int GetInt()
        {
            return 1000;
        }
    }
}
