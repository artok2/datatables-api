using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatables.Api.Models
{
    public class SearchRequestItem
    {
        public string Value { get; set; }
        public string Regex { get; set; }
    }
}
