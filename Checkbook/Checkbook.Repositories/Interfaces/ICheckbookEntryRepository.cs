using Checkbook.Models;

namespace Checkbook.Repositories
{
    public interface ICheckbookEntryRepository
    {
        void AddEntry(CheckbookEntry entry);
    }
}