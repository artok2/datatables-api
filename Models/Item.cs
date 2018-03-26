using System;

namespace Datatables.Api.Models
{  
    public class Item: SearchDetail
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}