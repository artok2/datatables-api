using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatables.Api.Models
{
 
        public static class Extensions
        {
            public static string AsPropertyName(this string source)
            {
                return char.ToUpper(source[0]) + source.Substring(1);
            }

            public static bool ContainsIgnoringCase(this string source, string substring)
            {
                return source.ToLower().Contains(substring.ToLower());
            }
        }



    }