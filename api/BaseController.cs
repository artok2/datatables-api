
    namespace Datatables.Api.api

    {
        using System.Collections;
        using System.Collections.Generic;
        using System.Linq;
        using Microsoft.AspNetCore.Mvc;
        using Microsoft.AspNetCore.Http;
        using Models;
        using api.Response;

   

     //   public abstract class SearchController
        public abstract partial class BaseController : Controller
    {
            protected static IList<TDetail> PageResults<TDetail>(IEnumerable<TDetail> results, Models.SearchRequest request) where TDetail : Models.SearchDetail
        {
                var skip = request.Start;
                var pageSize = request.Length;
                var orderedResults = OrderResults(results, request);
                return pageSize > 0 ? orderedResults.Skip(skip).Take(pageSize).ToList() : orderedResults.ToList();
            }

            private static IEnumerable<TDetail> OrderResults<TDetail>(IEnumerable<TDetail> results, Models.SearchRequest request) where TDetail : Models.SearchDetail
            {
                if (request.Order == null) return results;
                ICollection col = request.Order as ICollection;
                if ((col != null) && (int)col.Count == 0) return results;

                var columnIndex = request.Order[0].Column;
                var sortDirection = request.Order[0].Dir;
                var columnName = request.Columns[columnIndex].Data.AsPropertyName();
                var prop = typeof(TDetail).GetProperty(columnName);
                return sortDirection == "asc" ? results.OrderBy(prop.GetValue) : results.OrderByDescending(prop.GetValue);
            }


        public static ItemSearchResponse GetResponse(ICollection<Item> details, SearchRequest request)
        {
            string search = "";
            if ((request.Search != null) && (request.Search.Value != null))
            {
                search = request.Search.Value;
            }
              
            var results = ApiHelper.FilterItems(details, search).ToList();
            var response = new ItemSearchResponse
            {
                Data = PageResults(results, request),
                Draw = request.Draw,
                RecordsFiltered = results.Count,
                RecordsTotal = details.Count
            };
            return response;
        }
    }
    }


