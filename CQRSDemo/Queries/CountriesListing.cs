using CQRSDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Queries
{
    public class CountryListing : QueryData<IEnumerable<CountryListingItem>>
    {
    }

    public class CountryListingItem
    {
        public string Name { get; set; }
        public string Capital { get; set; }
    }

    public class CountriesListingHandler : IQueryHandler<CountryListing>
    {
        public CountryListing Handle(CountryListing query)
        {
            var result = new List<CountryListingItem>()
            {
                new CountryListingItem { Capital="Lisbon", Name="Portugal"},
                new CountryListingItem { Capital="Madrid", Name="Spain"},
                new CountryListingItem { Capital="Warsaw", Name="Poland"},
                new CountryListingItem { Capital="Ankara", Name="Turkey"}
            };

            query.Data = result;

            return query;
        }
    }
}
