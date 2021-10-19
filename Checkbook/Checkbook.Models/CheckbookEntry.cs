using System;

namespace Checkbook.Models
{
    public class CheckbookEntry
    {
        private DateTime _purchaseDate;
        private string _description;
        private string _type;
        private decimal _amount;
        private Account _source;
        private Account _destination;

        public CheckbookEntry(DateTime purchaseDate, string description, string type, decimal amount,
            Account source, Account destination)
        {
            _purchaseDate = purchaseDate;
            _description = description;
            _type = type;
            _amount = amount;
            _source = source;
            _destination = destination;
        }

        public DateTime PurchaseDate { get => _purchaseDate; }
        public string Description { get => _description; }
        public string Type { get => _type; }
        public decimal Amount { get => _amount; }
        public Account Source { get => _source; }
        public Account Destination { get => _destination; }
    }
}
