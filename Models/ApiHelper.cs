using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatables.Api.Models
{
    public static class ApiHelper
    {
        public static IEnumerable<Item> FilterItems(IEnumerable<Item> details, string searchText)
        {
            if ((searchText==null) || (searchText==""))
            {
                return details;
            }

            var results = details.Where(x => x.Name.ContainsIgnoringCase(searchText)
                || x.Description.ContainsIgnoringCase(searchText)
             
                );

            return results;
        }
    }
}