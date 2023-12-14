using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractMgmt.Application.Product.Infrastructure.Data
{

    public class Products
    {
        public string id { get; set; }
        public List<Element> Elements { get; set; }
    }
    public class Element
    {
        public string t { get; set; }
        public string Fee { get; set; }
        public object Price { get; set; }
    }
}
