using Checkbook.Models;
using System.Collections.Generic;

namespace Checkbook.Repositories
{
    internal interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}