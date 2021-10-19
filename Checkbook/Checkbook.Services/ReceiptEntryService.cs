using Checkbook.Models;
using Checkbook.Repositories;
using System;

namespace Checkbook.Services
{
    public class ReceiptEntryService
    {
        private ICheckbookEntryRepository _checkbookEntryRepository;

        public ReceiptEntryService(ICheckbookEntryRepository checkbookRepo)
        {
            _checkbookEntryRepository = checkbookRepo;
        }

        public void AddReceipt(DateTime purchaseDate, string description, string type, decimal amount,
            Account source, Account destination)
        {
            var entry = new CheckbookEntry(purchaseDate, description, type, amount, source, destination);
            _checkbookEntryRepository.AddEntry(entry);
        }
    }
}
