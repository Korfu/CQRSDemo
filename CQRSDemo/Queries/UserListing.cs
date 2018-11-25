using CQRSDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSDemo.Queries
{
    public class UserListing : QueryData<IEnumerable<UserListingItem>>
    {
    }

    public class UserListingItem
    {
        public string Name { get; set; }
        public string Login { get; set; }
    }

    public class UserListingQueryHandler : IQueryHandler<UserListing>
    {
        public UserListing Handle(UserListing query)
        {
            var result = new List<UserListingItem>()
            {
                new UserListingItem { Name="Konrad", Login="koko" }
            };

            query.Data = result;

            return query;
        }
    }
}
