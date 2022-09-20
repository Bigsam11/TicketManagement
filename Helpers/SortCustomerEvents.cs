using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using Viagogo.Data;
using Viagogo.Helper;
using Viagogo.Models;

namespace Viagogo.Helpers
{
    public static class SortCustomerEvents
    {

        public static void ResolveCustomerEvents()
        {

            var customers = SampleTestData.GetAllCustomers();
            var events = SampleTestData.GetAllEvents();

            try
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"---------- Calculating Distance for {customer.Name} from {customer.City}---------------");

                    var distancedEvents = new List<DistancedEvent>();

                    events.ForEach(e =>
                    {
                        distancedEvents.Add(new DistancedEvent
                        {
                            Name = e.Name,
                            City = e.City,
                            Distance = DistanceImpl.GetDistance(customer.City, e.City) == 0 ? 0 : DistanceImpl.GetDistance(customer.City, e.City),
                            Price = ResolvePrice.GetPrice(e)
                        });
                        
                    });


                    // Currently Ordering by Price.
                    //Or better still change to Distance to filter by Distance.

                    var filterOption = Filter.Price;
                    
                    switch (filterOption) {

                        case Filter.Distance:
                            distancedEvents = distancedEvents.OrderBy(e => e.Distance).Take(5).ToList();
                            distancedEvents.ForEach(e =>
                            {
                                AddToEmailImpl.AddToEmail(customer, new Event {City = e.City, Name = e.Name},e.Price);
                            });
                            Console.WriteLine($"---------- Done Calculating Distance for {customer.Name} from {customer.City}---------------");
                            break;
                        
                        case Filter.Price:
                            distancedEvents = distancedEvents.OrderBy(e => e.Price).Take(5).ToList();// statement sequence
                            distancedEvents.ForEach(e =>
                            {
                                AddToEmailImpl.AddToEmail(customer, new Event {City = e.City, Name = e.Name},e.Price);
                            });
                            Console.WriteLine($"---------- Done Calculating Distance for {customer.Name} from {customer.City}---------------");
                            break;
                               
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} was experienced while trying to sort events and customers due to {e.InnerException}");
            }
        }
    }

}