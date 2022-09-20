using System.Collections.Generic;
using System.Threading.Tasks;
using Viagogo.Models;

namespace Viagogo.Data
{

    public class SampleTestData
    {
        public static List<Event> GetAllEvents()
        { 
            return new List<Event>
            {
                new Event { Name = "Phantom of the Opera", City = "New York" },
                new Event { Name = "Metallica", City = "Los Angeles" },
                new Event { Name = "Metallica", City = "New York" },
                new Event { Name = "Metallica", City = "Boston" },
                new Event { Name = "LadyGaGa", City = "New York" },
                new Event { Name = "LadyGaGa", City = "Boston" },
                new Event { Name = "LadyGaGa", City = "Chicago" },
                new Event { Name = "LadyGaGa", City = "San Francisco" },
                new Event { Name = "LadyGaGa", City = "Washington" }
            };
        }

        public static  List<Customer> GetAllCustomers()
        {
            return  new List<Customer>{
                new Customer{ Name = "Nathan", City = "New York"},
                new Customer{ Name = "Bob", City = "Boston"},
                new Customer{ Name = "Cindy", City = "Chicago"},
                new Customer{ Name = "Lisa", City = "Los Angeles"}
            };
           
        }
        
    }
  
  
}