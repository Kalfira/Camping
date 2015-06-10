using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Xadvertise.Models
{
    public class AccountsContext : DbContext
    {
        public IDbSet<Account> Accounts { get; set; }
    }
}