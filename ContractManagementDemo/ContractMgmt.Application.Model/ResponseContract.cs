using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractMgmt.Application.Model
{
    public class Contracts
    {
        public string id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public HashSet<Product> Products { get; set; }
    }

    public class Element
    {
        public string t { get; set; }
        public string Fee { get; set; }
        public object Price { get; set; }
    }

    public class Product
    {
        public string id { get; set; }
        public HashSet<Element> Elements { get; set; }
    }

    public class ResponseContracts
    {
        public Contracts Contracts { get; set; }
    }

}
