using Checkbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkbook.Repositories
{
    class AccountRepository : IAccountRepository
    {
        public IEnumerable<Account> GetAccounts()
        {
            return new List<Account>();
        }
    }
}
