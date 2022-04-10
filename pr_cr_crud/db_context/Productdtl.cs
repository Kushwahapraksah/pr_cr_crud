using System;
using System.Collections.Generic;

#nullable disable

namespace pr_cr_crud.db_context
{
    public partial class Productdtl
    {
        public int PrdctNo { get; set; }
        public string ProdctName { get; set; }
        public int? Mrp { get; set; }
        public int? Discount { get; set; }
    }
}
