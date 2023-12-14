using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractMgmt.Application.Model
{
    public class Elements
    {
        public string t { get; set; }
        public string Fee { get; set; }
        public object Price { get; set; }
    }

    public class ProductsResult
    {
        public string id { get; set; }
        public HashSet<Elements> Elements { get; set; }
    }
}
