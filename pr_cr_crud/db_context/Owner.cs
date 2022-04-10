using System;
using System.Collections.Generic;

#nullable disable

namespace pr_cr_crud.db_context
{
    public partial class Owner
    {
        public int Id { get; set; }
        public string UsrName { get; set; }
        public string Password { get; set; }
    }
}
