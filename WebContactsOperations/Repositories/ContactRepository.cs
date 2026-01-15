using WebContactsOperations.Data;
using WebContactsOperations.Interfaces;
using WebContactsOperations.Models;

namespace WebContactsOperations.Repositories
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(AppDbContext context)
            : base(context) { }

    }
}
