namespace Datatables.Api.api.Response
{
    using System.Collections.Generic;
    using Datatables.Api.Models;

    public abstract class SearchResponse<T> where T : SearchDetail
    {
        public int Draw { get; set; }

        public int RecordsTotal { get; set; }

        public int RecordsFiltered { get; set; }

        public IList<T> Data { get; set; }
    }
}
