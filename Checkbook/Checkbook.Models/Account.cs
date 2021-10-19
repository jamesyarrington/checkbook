using System;

namespace Checkbook.Models
{
    public class Account
    {
        private string _name;
        private decimal _initialBalance;
        private DateTime _initialBalanceDate;
        private decimal _verifiedBalance;
        private DateTime _verifiedBalanceDate;

        public string Name { get => _name; }
        public decimal InitialBalance { get => _initialBalance; }
        public DateTime InitialBalanceDate { get => _initialBalanceDate; }
        public decimal VerifiedBalance { get => _verifiedBalance; }
        public DateTime VerifiedBalanceDate { get => _verifiedBalanceDate; }
    }
}
