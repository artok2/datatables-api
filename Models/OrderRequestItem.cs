using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatables.Api.Models
{
    public class OrderRequestItem
    {
        public int Column { get; set; }
        public string Dir { get; set; }
    }
}
